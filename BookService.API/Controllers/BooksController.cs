using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BookService.WebAPI.DTO;
using BookService.WebAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookService.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase//dependency injection
    {
        BookRepository _bookRepository;

        public BooksController(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;

        }
        //api/Books
        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(_bookRepository.List());
        }
        //api/Books/BAsic
        [HttpGet]
        [Route("Basic")]
        public IActionResult GetBooksBasic()
        {
            return Ok(_bookRepository.ListBasic());
            
        }
        [HttpGet("{id")]
        public IActionResult GetBook(int id)
        {
            return Ok(_bookRepository.GetById(id));
        }

        // GET: api/books/imagebyname/book2.jpg
        [HttpGet]
        [Route("ImageByName/{filename}")]
        public IActionResult ImageByFileName(string filename)
        {
            var image = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", filename);
            return PhysicalFile(image, "image/jpeg");
        }

        // GET: api/books/imagebyid/6
        [HttpGet]
        [Route("ImageById/{bookid}")]
        public IActionResult ImageById(int bookid)
        {
            BookDetail book = _bookRepository.GetById(bookid);
            return ImageByFileName(book.FileName);
        }

    }
}