using BookService.WebAPI.Data;
using BookService.WebAPI.DTO;
using BookService.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookService.WebAPI.Repositories
{
    public class AuthorRepository
    {
        private BookServiceContext bookServiceContext;

        public AuthorRepository(BookServiceContext context)
        {
            bookServiceContext = context;
        }

        public List<Author> List()
        {
            return bookServiceContext.Authors.ToList();
        }

        public List<AuthorBasic> ListBasic()
        {
            return bookServiceContext.Authors.Select(
                a => new AuthorBasic
                {
                    Id = a.Id,
                    Name = a.FirstName + "" + a.LastName 
                }
                ).ToList();
        }
        public Author GetById(int id)
        {
            return bookServiceContext.Authors.FirstOrDefault(p => p.Id == id);
               

        }

    }
}
