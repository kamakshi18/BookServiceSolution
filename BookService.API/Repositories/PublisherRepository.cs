using BookService.WebAPI.Data;
using BookService.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookService.WebAPI.Repositories
{
    public class PublisherRepository
    {
        private BookServiceContext bookServiceContext;

        public PublisherRepository(BookServiceContext context)
        {
            bookServiceContext = context;
        }

        public List<Publisher> List()
        {
            return bookServiceContext.Publishers.ToList();
        }
        public Publisher GetById(int id)
        {
            return bookServiceContext.Publishers.Where(p => p.Id == id).FirstOrDefault();

        }
    }
}
