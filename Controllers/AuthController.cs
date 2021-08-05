using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using book.Models;
using book.Services;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace book.Controllers
{
    public class AuthController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IBookService _bookService;
        private readonly ICategoryService _categoryService;
        private readonly IPublisherService _publisherService;
        private readonly IUserService _userService;
        private readonly IOrderService _orderService;

        public AuthController(ILogger<HomeController> logger,
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
        }
        public IActionResult Login(string email, string password)
        {
            User user = _userService.GetUserByEmailPassword(email, password);
            if (user != null) 
            {
                HttpContext.Session.SetString("login", JsonConvert.SerializeObject(user));
                HttpContext.Session.Set<User>("user_login", user);
                return Redirect("/home/index");
            }
            return RedirectToAction("index", "home");
        }

        private bool CheckExistUser(string email) {
            User user = _userService.GetUserByEmail(email);
            return user != null;
        }

        public IActionResult Register(string email, string password1, string password2, string name)
        {
            if (CheckExistUser(email)) return RedirectToAction("index", "home");

            User user = _userService.Register(email, password1, name);
            if (user != null) 
            {
                HttpContext.Session.SetString("login", JsonConvert.SerializeObject(user));
                return Redirect("/home/index");
            }
            return RedirectToAction("index", "home");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("user_login");
            HttpContext.Session.Remove("cart");
            return Redirect("/home/index");
        }
        public IActionResult Account()
        {
            User userLogged = HttpContext.Session.Get<User>("user_login");
            if (userLogged == null) return NotFound();
            User user = _userService.GetDetailUserById(userLogged.Id);
            ViewBag.User = user;
            return View();
        }
        public IActionResult AccountSaveInfo(User newUserInfo)
        {
            _userService.UpdateUserInfo(newUserInfo);
            return RedirectToAction("account", "auth");
        }
        public IActionResult Orders()
        {
            return View();
        }
    }
}
