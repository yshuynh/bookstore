using System.Collections.Generic;
using book.Models;
using Microsoft.AspNetCore.Mvc;

namespace book.Services
{
    public interface IPublisherService
    {
        public List<Publisher> GetPublishers();
        public Publisher GetPublisherById(int id);
    }
}