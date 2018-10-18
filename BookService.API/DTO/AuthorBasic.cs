using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookService.WebAPI.DTO
{
    public class AuthorBasic
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name
        {
            get
            {
                return string.Format("{0}{1}", FirstName, LastName);
            }
        }
    }
}
