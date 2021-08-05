using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using book.Models;
using Microsoft.EntityFrameworkCore;

namespace book.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }

        public List<Category> GetCategories()
        {
            List<Category> categories = _context.Categories
                .Include(b => b.SubCategories)
                .AsNoTracking()    
                .ToList();
            return categories;
        }

        public Category GetCategoryById(int id)
        {
            return null;
        }
    }
}