using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrewProject.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public DateTime DOB { get; set; }
        public ICollection<BreweryInfo> Breweries { get; set; }

    }
}