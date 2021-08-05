using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using book.Models;

namespace book.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly DataContext _context;

        public PublisherService(DataContext context)
        {
            _context = context;
        }

        public List<Publisher> GetPublishers()
        {
            return _context.Publishers.ToList();
        }

        public Publisher GetPublisherById(int id)
        {
            return null;
        }
    }
}