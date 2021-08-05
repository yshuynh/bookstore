using System.Collections.Generic;
using book.Models;
using Microsoft.AspNetCore.Mvc;

namespace book.Services
{
    public interface IOrderService
    {
        public Order CreateOrder(Order newOrder, List<CartItem> cart);
        public List<Order> GetListOrder(int userId);
        public Order GetOrderDetail(int orderId);
    }
}