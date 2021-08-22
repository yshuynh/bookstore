using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using book.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Text.RegularExpressions;

namespace book.Services
{
    public class BookService : IBookService
    {
        private readonly DataContext _context;

        public BookService(DataContext context)
        {
            _context = context;
        }

        public List<Book> GetBooks()
        {
            return null;
        }

        public List<string> GetAllBookTitle()
        {
            var book_query = from b in _context.Books
                             select b.Title;
            return book_query.ToList<string>();
        }

        public Book GetBookById(int id)
        {
            var book_query =
                from book in _context.Books
                where book.Id == id
                select book;
            List<Book> book_list = book_query.ToList();
            if (book_list.Count > 0)
                return book_list.ToList()[0];
            else
                return null;
        }

        public String removeVietnameseTones(String str) {
            str = Regex.Replace(str, "/à|á|ạ|ả|ã|â|ầ|ấ|ậ|ẩ|ẫ|ă|ằ|ắ|ặ|ẳ|ẵ/g","a"); 
            str = Regex.Replace(str, "/è|é|ẹ|ẻ|ẽ|ê|ề|ế|ệ|ể|ễ/g","e"); 
            str = Regex.Replace(str, "/ì|í|ị|ỉ|ĩ/g","i"); 
            str = Regex.Replace(str, "/ò|ó|ọ|ỏ|õ|ô|ồ|ố|ộ|ổ|ỗ|ơ|ờ|ớ|ợ|ở|ỡ/g","o"); 
            str = Regex.Replace(str, "/ù|ú|ụ|ủ|ũ|ư|ừ|ứ|ự|ử|ữ/g","u"); 
            str = Regex.Replace(str, "/ỳ|ý|ỵ|ỷ|ỹ/g","y"); 
            str = Regex.Replace(str, "/đ/g","d");
            str = Regex.Replace(str, "/À|Á|Ạ|Ả|Ã|Â|Ầ|Ấ|Ậ|Ẩ|Ẫ|Ă|Ằ|Ắ|Ặ|Ẳ|Ẵ/g", "A");
            str = Regex.Replace(str, "/È|É|Ẹ|Ẻ|Ẽ|Ê|Ề|Ế|Ệ|Ể|Ễ/g", "E");
            str = Regex.Replace(str, "/Ì|Í|Ị|Ỉ|Ĩ/g", "I");
            str = Regex.Replace(str, "/Ò|Ó|Ọ|Ỏ|Õ|Ô|Ồ|Ố|Ộ|Ổ|Ỗ|Ơ|Ờ|Ớ|Ợ|Ở|Ỡ/g", "O");
            str = Regex.Replace(str, "/Ù|Ú|Ụ|Ủ|Ũ|Ư|Ừ|Ứ|Ự|Ử|Ữ/g", "U");
            str = Regex.Replace(str, "/Ỳ|Ý|Ỵ|Ỷ|Ỹ/g", "Y");
            str = Regex.Replace(str, "/Đ/g", "D");
            // Some system encode vietnamese combining accent as individual utf-8 characters
            // Một vài bộ encode coi các dấu mũ, dấu chữ như một kí tự riêng biệt nên thêm hai dòng này
            str = Regex.Replace(str, "/\u0300|\u0301|\u0303|\u0309|\u0323/g", ""); // ̀ ́ ̃ ̉ ̣  huyền, sắc, ngã, hỏi, nặng
            str = Regex.Replace(str, "/\u02C6|\u0306|\u031B/g", ""); // ˆ ̆ ̛  Â, Ê, Ă, Ơ, Ư
            return str;
        }

        private Boolean isContainInTitle(String title, String str) {
            String titleTrim = removeVietnameseTones(title).ToLower();
            String strTrim = removeVietnameseTones(str).ToLower();
            return titleTrim.Contains(strTrim);
        }

        public List<Book> GetBooksIndex(string searchString)
        {
            var book_query = from b in _context.Books
                             select b;
            List<Book> books = book_query
                .Include(b => b.Category)
                .Include(b => b.SubCategory)
                .Include(b => b.BookMeta)
                    .ThenInclude(bm => bm.Publisher)
                .Include(b => b.BookMeta)
                    .ThenInclude(bm => bm.Author)
                .Include(b => b.CartUsers)
                .Include(b => b.Ratings)
                .AsNoTracking()    
                .ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                String a = removeVietnameseTones("Gươm");
                books = books.FindAll(b => isContainInTitle(b.Title, searchString));
            }
            return books;
        }

        public Book GetBookDetailById(int? id)
        {
            if (id == null)
                return null;

            var book = _context.Books
                .Include(b => b.Category)
                .Include(b => b.SubCategory)
                .Include(b => b.BookMeta)
                    .ThenInclude(bm => bm.Publisher)
                .Include(b => b.BookMeta)
                    .ThenInclude(bm => bm.Author)
                .Include(b => b.Ratings)
                    .ThenInclude(b => b.User)
                .AsNoTracking()
                .FirstOrDefault(b => b.Id == id);
            // var book = _context.Books
            //     .AsNoTracking()
            //     .FirstOrDefault(b => b.Id == id);
            // book.BookMeta = _context.BookMetas
            //     .FirstOrDefault(b => b.Id == book.Id);

            return book;    
        }

        public List<Rating> GetRatings(int id)
        {
            var list = _context.Ratings
                .Include(b => b.User)
                .AsNoTracking()
                .Where(b => b.BookId == id)
                .ToList<Rating>();
            // var book = _context.Books
            //     .AsNoTracking()
            //     .FirstOrDefault(b => b.Id == id);
            // book.BookMeta = _context.BookMetas
            //     .FirstOrDefault(b => b.Id == book.Id);

            return list;    
        }
    }
}