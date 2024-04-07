using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();  // returns CSHTML file
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();  // returns CSHTML file
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Hello there!";

            return View();  // returns CSHTML file
        }
    }
}