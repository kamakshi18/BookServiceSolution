using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}