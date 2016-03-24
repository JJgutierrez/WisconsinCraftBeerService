using ASPPracticeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPPracticeProject.Controllers
{
    public class HomeController : Controller
    {
        //action methods
        public ActionResult Index()
        {
            //SchoolContext test = new SchoolContext();
            //Student jim = new Student();
            //jim.FirstName = "jim";
            //jim.EnrollmentDate = DateTime.Now;
            //test.Students.Add(jim);
            //test.SaveChanges();
            return View();
        }

        public string About()
        {
            //ViewBag.Message = "Your application description page.";

            return "this is the Home Controller - About Method";
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.Whatever = "Dont use view bag you douche bag";
            return View();
        }
    }
}