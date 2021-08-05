using System.Collections.Generic;
using book.Models;
using Microsoft.AspNetCore.Mvc;

namespace book.Services
{
    public interface ICategoryService
    {
        public List<Category> GetCategories();
        public Category GetCategoryById(int id);
    }
}