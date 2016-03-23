using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrewProject.Models
{
    public class BreweryInfo
    {
        public int BreweryInfoId { get; set; }
        public string BreweryName { get; set; }
        public string BreweryAddress { get; set; }
        public string Website { get; set; }
        public int CostumerId { get; set; }
        public int ProductId { get; set; }

        public Customer customer { get; set; }
        public Product product { get; set; }
    }
}