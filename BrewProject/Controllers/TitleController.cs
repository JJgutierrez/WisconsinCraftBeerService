using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BrewProject.Models;

namespace BrewProject.Controllers
{
    public class TitleController : Controller
    {
        private FirmaContext db = new FirmaContext();
        //
        // GET: /Title/
        public ActionResult Index()
        {
            var customer = db.Customers.ToList();

            return View(customer);
        }
    }
}