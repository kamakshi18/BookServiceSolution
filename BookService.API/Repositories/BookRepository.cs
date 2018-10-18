using BookService.WebAPI.Data;
using BookService.WebAPI.DTO;
using BookService.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookService.WebAPI.Repositories
{
    public class BookRepository
    {
        private BookServiceContext bookServiceContext;

        public BookRepository(BookServiceContext context)
        {
            bookServiceContext = context;
        }

        public List<Book> List()
        {
            return bookServiceContext.Books
                .Include(b=>b.Author)
                .Include(b =>b.Publisher)
                .ToList();
        }

        public List<BookBasic> ListBasic()
        {
            return bookServiceContext.Books.Select(
                b=>new BookBasic
                {
                    Id = b.Id,
                    Title = b.Title
                }

                ).ToList();
        } 
        public BookDetail GetById(int id)
        {
            return bookServiceContext.Books.Select(b => new BookDetail
            {
                Id = b.Id,
                Title = b.Title,
                ISBN = b.ISBN,
                Year = b.Year,
                Price = b.Price,
                NumberOfPages = b.NumberOfPages,
                AuthorID = b.Author.Id,
                AuthorName = $"{b.Author.LastName} {b.Author.FirstName}",
                PublisherID = b.Publisher.Id,
                PublisherName = b.Publisher.Name,
                FileName = b.FileName
            }).FirstOrDefault(b => b.Id == id);
        }
    }
}
