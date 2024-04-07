using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVCTutorial.Models;

namespace WebApplicationMVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            User user = new User();
            user.Id = 1;
            user.FirstName = "Nate";
            user.LastName = "Brink";
            user.Age = 49;

            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "ABOUT IT.";

            throw new Exception("Invalid page.");

            return View();
        }

        public ActionResult Contact(int id=0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}