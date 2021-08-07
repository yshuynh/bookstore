using System.Collections.Generic;
using book.Models;
using Microsoft.AspNetCore.Mvc;

namespace book.Services
{
    public interface IUserService
    {
        public User GetUserByEmailPassword(string email, string password);
        public User Register(string email, string password, string name);
        public User GetUserByEmail(string email);
        public User GetDetailUserById(int id);
        public void AddCart(int userId, Book book, int addcartcount);
        public void AddCart(int cartId);
        public void SubCart(int cartId);
        public void DeleteCart(int cartId);
        public void UpdateUserInfo(User newUserInfo);
        public void ResetCart(int userId);
        public void CreateRating(int userId, int bookId, int rate, string comment);
    }
}