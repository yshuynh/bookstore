using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using book.Models;
using Microsoft.EntityFrameworkCore;

namespace book.Services
{
    public class OrderService : IOrderService
    {
        private readonly DataContext _context;

        public OrderService(DataContext context)
        {
            _context = context;
        }

        public Order CreateOrder(Order newOrder, List<CartItem> cart) 
        {
            Order order = new Order{Address=newOrder.Address, PhoneNumber=newOrder.PhoneNumber, Name=newOrder.Name, Email=newOrder.Email, UserId=null};
            _context.Orders.Add(order);
            // _context.SaveChanges();
            order.UserId = newOrder.UserId;
            _context.SaveChanges();
            int count = 0;
            int sum = 0;
            foreach (CartItem cartItem in cart)
            {
                var query = _context.CartItem.FirstOrDefault(b => b.Id == cartItem.Id);
                if (query == null) {
                    int id = cartItem.Book.Id;
                    cartItem.Book = null;
                    cartItem.BookId = id;
                    _context.CartItem.Add(cartItem);
                    _context.SaveChanges();
                    query = _context.CartItem.Include(b => b.Book).ThenInclude(b => b.BookMeta).FirstOrDefault(b => b.Id == cartItem.Id);
                    cartItem.Book = query.Book;
                }
                query.OrderId = order.Id;
                query.User = null;
                query.UserId = null;
                count += cartItem.Count;
                sum += cartItem.Count * cartItem.Book.BookMeta.Price;
            }
            order.Count = count;
            order.Cost = sum;
            _context.SaveChanges();
            return GetOrderDetail(order.Id);
        }
        public List<Order> GetListOrder(int userId)
        {
           var query = _context.Orders
                .Include(b => b.Cart)
                    .ThenInclude(b => b.Book)
                        .ThenInclude(b => b.BookMeta)
                            .ThenInclude(b => b.Publisher)
                .AsNoTracking()
                .Where(b => b.UserId == userId);
            return query.ToList<Order>();
        }

        public Order GetOrderDetail(int orderId)
        {
           var query = _context.Orders
                .Include(b => b.Cart)
                    .ThenInclude(b => b.Book)
                        .ThenInclude(b => b.BookMeta)
                            .ThenInclude(b => b.Publisher)
                .AsNoTracking()
                .FirstOrDefault(b => b.Id == orderId);
            return query;
        }
    }
}