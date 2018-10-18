using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookService.WebAPI.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public Publisher()
        {

        }
        // with this constructor it is easir to type data in book service context
        public Publisher(int id, string name, string country)
        {
            Id = id;
            Name = name;
            Country = country;
        }

    }
}
