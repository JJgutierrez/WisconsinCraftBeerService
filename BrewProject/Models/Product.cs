using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrewProject.Models
{
    public class Product
    {
        public int ProductId { get; set; } 
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public ICollection<BreweryInfo> Breweries { get; set; }


    }
}