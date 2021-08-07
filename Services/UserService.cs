using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using book.Models;
using Microsoft.EntityFrameworkCore;

namespace book.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public List<User> GetUsers()
        {
            return null;
        }

        public User GetUserById(int id)
        {
            // var user_query =
            //     from user in _context.Users
            //     where user.Id == id
            //     select user;
            // List<User> user_list = user_query.ToList();
            // if (user_list.Count > 0)
            //     return user_query.ToList()[0];
            // else
            //     return null;
            var user = _context.Users
                .Include(b => b.Cart)
                .AsNoTracking()
                .FirstOrDefault(b => b.Id == id);
            return user;
        }

        public User GetDetailUserById(int id)
        {
            // var user_query =
            //     from user in _context.Users
            //     where user.Id == id
            //     select user;
            // List<User> user_list = user_query.ToList();
            // if (user_list.Count > 0)
            //     return user_query.ToList()[0];
            // else
            //     return null;
            var user = _context.Users
                .Include(b => b.Cart)
                    .ThenInclude(b => b.Book)
                        .ThenInclude(b => b.BookMeta)
                            .ThenInclude(b => b.Publisher)
                .AsNoTracking()
                .FirstOrDefault(b => b.Id == id);
            return user;
        }

        public User GetUserByEmail(string email)
        {
            var user_query =
                from user in _context.Users
                where user.Email == email
                select user;
            List<User> user_list = user_query.ToList();
            if (user_list.Count > 0)
                return user_query.ToList()[0];
            else
                return null;
        }

        public User GetUserByEmailPassword(string email, string password)
        {
            var user_query =
                from user in _context.Users
                where user.Email == email && user.Password == password
                select user;
            List<User> user_list = user_query.ToList();
            if (user_list.Count > 0)
                return user_query.ToList()[0];
            else
                return null;
        }

        public User Register(string email, string password, string name)
        {
            User user = new User{Email=email, Password=password, Name=name};
            _context.Users.Add(user);
            _context.SaveChanges();
            return GetUserByEmail(email);
        }

        public void AddCart(int userId, Book book, int addcartcount)
        {
            CartItem checkItem = _context.CartItem.FirstOrDefault(b => b.UserId==userId && b.BookId==book.Id);
            if (checkItem == null)
            {
                CartItem newCartItem = new CartItem{UserId=userId, BookId=book.Id, Count=addcartcount};
                _context.CartItem.Add(newCartItem);
                _context.SaveChanges();
            }
            else 
            {
                checkItem.Count += addcartcount;
                _context.SaveChanges();
            }
        }

        public void AddCart(int cartId)
        {
            CartItem checkItem = _context.CartItem.FirstOrDefault(b => b.Id == cartId);
            if (checkItem != null)
            {
                checkItem.Count++;
                _context.SaveChanges();
            }
        }

        public void SubCart(int cartId)
        {
            CartItem checkItem = _context.CartItem.FirstOrDefault(b => b.Id == cartId);
            if (checkItem != null)
            {
                
                if (checkItem.Count == 1) DeleteCart(cartId);
                else {
                    checkItem.Count--;
                    _context.SaveChanges();
                }
            }
        }

        public void DeleteCart(int cartId)
        {
            CartItem checkItem = _context.CartItem.FirstOrDefault(b => b.Id == cartId);
            if (checkItem != null)
            {
                _context.CartItem.Remove(checkItem);
                _context.SaveChanges();
            }
        }

        public void ResetCart(int userId)
        {
            User user = GetDetailUserById(userId);
            user.Cart = new List<CartItem>();
            _context.SaveChanges();
        }

        public void UpdateUserInfo(User newUserInfo)
        {
            User user = _context.Users.FirstOrDefault(b => b.Id == newUserInfo.Id);
            user.Name = newUserInfo.Name;
            user.Email = newUserInfo.Email;
            user.Address = newUserInfo.Address;
            user.PhoneNumber = newUserInfo.PhoneNumber;
            _context.SaveChanges();
        }
    }
}