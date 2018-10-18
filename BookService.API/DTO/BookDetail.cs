using BookService.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookService.WebAPI.DTO
{
    public class BookDetail
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        [Display(Name = "#")]
        public int NumberOfPages { get; set; }
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public int PublisherID { get; set; }
        public string PublisherName { get; set; }
        public string FileName { get; set; }
        public int Year { get; set; }
        public Decimal Price { get; set; }
    }
}
