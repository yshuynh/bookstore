using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using book.Models;
using book.Services;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace book.Controllers
{
    public class HomeController : Controller
    {
        public static List<CartItem> tempCart;
        private readonly ILogger<HomeController> _logger;

        private readonly IBookService _bookService;
        private readonly ICategoryService _categoryService;
        private readonly IPublisherService _publisherService;
        private readonly IUserService _userService;
        private readonly IOrderService _orderService;

        public HomeController(ILogger<HomeController> logger,
            IBookService bookService,
            ICategoryService categoryService,
            IPublisherService publisherService,
            IUserService userService,
            IOrderService orderService)
        {
            _logger = logger;
            _bookService = bookService;
            _categoryService = categoryService;
            _publisherService = publisherService;
            _userService = userService;
            _orderService = orderService;
            tempCart = new List<CartItem>();
            tempCart.Add(new CartItem{Book=_bookService.GetBookById(1)});
        }

        private void UpdateBaseInfoForLayout() 
        {
            User userLogged = HttpContext.Session.Get<User>("user_login");
            List<CartItem> cart;
            if (userLogged != null) 
            {
                User user = _userService.GetDetailUserById(userLogged.Id);
                if (user.Cart.Count == 0) cart = new List<CartItem>();
                else cart = user.Cart.ToList<CartItem>();
                HttpContext.Session.Set<List<CartItem>>("cart", cart);

            }
            else 
            {
                cart = HttpContext.Session.Get<List<CartItem>>("cart");
                if (cart == null)
                {
                    // Book book = _bookService.GetBookDetailById(1);
                    cart = new List<CartItem>();
                    // cart.Add(new CartItem{Book=book});
                    HttpContext.Session.Set<List<CartItem>>("cart", cart);
                }
            }
            if (userLogged != null) {
                User user = _userService.GetDetailUserById(userLogged.Id);
                ViewBag.User = user;
            } else {
                ViewBag.User = new User{Id=-1, Email="", PhoneNumber="", Address="", Name=""};
            }

            // var userString = HttpContext.Session.GetString("login");
            // User userLogged = null;
            // List<CartItem> cart;
            // if (userString != null)
            // {
            //     userLogged = JsonConvert.DeserializeObject<User>(userString);
            //     User user = _userService.GetDetailUserById(userLogged.Id);
            //     if (user.Cart.Count == 0) cart = new List<CartItem>();
            //     else cart = user.Cart as List<CartItem>;
            // }
            // else 
            // {
            //     cart = tempCart;
            // }
            // // List<CartItem> cart2 = new List<CartItem>();
            // for (int i=0; i<((byte)cart.Count); i++) {
            //     cart[i].Book = _bookService.GetBookDetailById(cart[i].Book.Id);
            // }
            // ViewBag.Cart = cart;
        }

        public IActionResult Index(string searchString, string order, int category=-1, int subCategory=-1, int page=1)
        {
            ViewBag.Order = order;
            string queryString = HttpContext.Request.QueryString.Value;
            ViewBag.QueryString = queryString;
            ViewData["CurrentFilter"] = searchString;
            List<Book> books = _bookService.GetBooksIndex(searchString);
            List<Category> categories = _categoryService.GetCategories();
             if (subCategory != -1) {
                books = books.FindAll(b => b.SubCategory.Id == subCategory);
                Category categoryObj = categories.Find(b => b.SubCategories.Any(c => c.Id == subCategory));
                ViewBag.SubCategory = categoryObj.SubCategories.ToList().Find(c => c.Id == subCategory);
                ViewBag.Category = categoryObj;
            } else if (category != -1) {
                books = books.FindAll(b => b.Category.Id == category);
                ViewBag.Category = categories.Find(b => b.Id == category);
            }
            int pageSize = 20;
            ViewBag.MaxPage = (int)(books.Count+pageSize-1)/pageSize;
            if (order == "bestseller")
                books = books.OrderByDescending(o => o.CartUsers.Where(c => c.OrderId != null).ToList().Sum(b => b.Count)).ToList<Book>();
            else
                books = books.OrderByDescending(o=>o.Id).ToList();
            books = books.GetRange(pageSize*(page-1), Math.Min(pageSize, books.Count - pageSize*(page-1)));
            ViewBag.Page = page;
            List<Publisher> publishers = _publisherService.GetPublishers();

            var objTuple = new Tuple<List<Category>, List<Publisher>, List<Book>>(categories, publishers, books);
            UpdateBaseInfoForLayout();
            return View(objTuple);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Cart()
        {
            UpdateBaseInfoForLayout();
            return View();
        }

        public IActionResult Detail(int id, bool addcart, int addcartcount)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = _bookService.GetBookDetailById(id);
            if (book == null)
            {
                return NotFound();
            }
            // Check action addcart
            if (addcart) 
            {
                User userLogged = HttpContext.Session.Get<User>("user_login");
                if (userLogged == null)
                {
                    List<CartItem> cart = HttpContext.Session.Get<List<CartItem>>("cart");
                    if (cart == null) {
                        cart = new List<CartItem>();
                    }
                    bool isDuplicate = false;
                    for (int i=0; i<cart.Count; i++) {
                        if (cart[i].Book.Id == book.Id) {
                            cart[i].Count += addcartcount;
                            isDuplicate = true;
                            break;
                        }
                    }
                    if (!isDuplicate) cart.Add(new CartItem{Book=book, Count=addcartcount, Id=cart.Count});
                    HttpContext.Session.Set<List<CartItem>>("cart", cart);
                }
                else
                {
                    _userService.AddCart(userLogged.Id, book);
                }
            }

            UpdateBaseInfoForLayout();
            return View("Detail", book);
        }

        public IActionResult ChangeCartItem(string btnaction, int cartItemId)
        {
            User userLogged = HttpContext.Session.Get<User>("user_login");
            List<CartItem> cart = HttpContext.Session.Get<List<CartItem>>("cart");
            if (btnaction == "add") {
                if (userLogged != null)
                    _userService.AddCart(cartItemId);
                else
                    cart.Find(b => b.Id == cartItemId).Count++;
            }
            if (btnaction == "sub") {
                if (userLogged != null)
                    _userService.SubCart(cartItemId);
                else {
                    CartItem item = cart.Find(b => b.Id == cartItemId);
                    item.Count--;
                    if (item.Count == 0) cart.Remove(item); 
                }
            }
            if (btnaction == "delete") {
                if (userLogged != null)
                    _userService.DeleteCart(cartItemId);
                else
                    cart.Remove(cart.Find(b => b.Id == cartItemId));
            }
            HttpContext.Session.Set<List<CartItem>>("cart", cart);
            return RedirectToAction("cart");
        }

        public IActionResult Buy()
        {
            UpdateBaseInfoForLayout();
            return View();
        }

        public IActionResult BuyExcute(Order order)
        {
            if (order.UserId == -1) order.UserId = null;
            List<CartItem> cart = HttpContext.Session.Get<List<CartItem>>("cart");
            order.User = HttpContext.Session.Get<User>("user_login");
            Order newOrder = _orderService.CreateOrder(order, cart);
            return Redirect("/home/orderdetail?orderId=" + newOrder.Id);
        }

        public IActionResult Orders()
        {
            User userLogged = HttpContext.Session.Get<User>("user_login");
            List<Order> orders = _orderService.GetListOrder(userLogged.Id);
            ViewBag.Orders = orders;
            return View();
        }

        public IActionResult OrderDetail(int orderId)
        {
            Order order = _orderService.GetOrderDetail(orderId);
            ViewBag.Order = order;
            return View();
        }

        // public IActionResult Account()
        // {
        //     User userLogged = HttpContext.Session.Get<User>("user_login");
        //     if (userLogged == null) return NotFound();
        //     User user = _userService.GetDetailUserById(userLogged.Id);
        //     ViewBag.User = user;
        //     return View();
        // }
        // public IActionResult AccountSaveInfo(User newUserInfo)
        // {
        //     _userService.UpdateUserInfo(newUserInfo);
        //     return RedirectToAction("account", "home");
        // }
    }
}
