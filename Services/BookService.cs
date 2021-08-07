using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using book.Models;
using Microsoft.EntityFrameworkCore;
using System;

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

        public List<Book> GetBooksIndex(string searchString)
        {
            var book_query = from b in _context.Books
                             select b;
            if (!String.IsNullOrEmpty(searchString))
            {
                book_query = book_query.Where(b => b.Title.ToLower().Contains(searchString.ToLower()));
            }
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