using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BrewProject.Models
{
    public class CompanyInitializer: DropCreateDatabaseIfModelChanges<FirmaContext>
    {
        protected override void Seed(FirmaContext context)
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer {FirstName = "Juan", LastName="Gutierrez", Email= "jjgues@live.com", Password = "juan014642", Address="Sussex", City="Sussex",State="Wisconsin", DOB =new DateTime(11/10/1980)},
                new Customer {FirstName = "Drew", LastName="Otteson", Email= "drew.otteson@yahoo.com", Password = "drew1234", Address="west bend", City="Sussex",State="Wisconsin", DOB =new DateTime(5/10/1993)},
            };
            foreach(Customer c in customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();

            List<Product> products = new List<Product>
            {
                new Product {ProductName="Oatmeal Stout", ProductType="Stout" },
                new Product {ProductName="Rustic Road Mosaic SMASH", ProductType="American Pale Ale" },
            };
            foreach(Product p in products)
            {
                context.Products.Add(p);
            }

            context.SaveChanges();

            List<BreweryInfo> breweries = new List<BreweryInfo>
            {
                new BreweryInfo { BreweryName = "Geneva Lake Brewing Company", BreweryAddress="750 Veterans Pkwy, Lake Geneva, WI 53147",Website= "http://www.genevalakebrewingcompany.com", CostumerId=1, ProductId = 1},
                new BreweryInfo { BreweryName = "Rustic Road brewing Company", BreweryAddress="510 56th Street - Kenosha, WI 53140 ",Website= "http://www.rusticbrewing.com/", CostumerId=2, ProductId=2},

            };
            foreach(BreweryInfo b in breweries)
            {
                context.Breweries.Add(b);
            }
            context.SaveChanges();

        }
    }
}