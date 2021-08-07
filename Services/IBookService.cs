using System.Collections.Generic;
using book.Models;
using Microsoft.AspNetCore.Mvc;

namespace book.Services
{
    public interface IBookService
    {
        public List<Book> GetBooks();
        public Book GetBookById(int id);
        public Book GetBookDetailById(int? id);
        public List<Book> GetBooksIndex(string searchString);
        public List<Rating> GetRatings(int id);
    }
}