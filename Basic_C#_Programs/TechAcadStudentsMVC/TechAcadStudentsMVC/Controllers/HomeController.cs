﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechAcadStudentsMVC.Models;

namespace TechAcadStudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page  |  GET AT ME.";

            return View();
        }

        public ActionResult Instructor(int id = 0)
        {
            ViewBag.Id = id;

            Instructor dayTimeInstructor = new Instructor
            {
                Id = 1,
                FirstName = "Erik",
                LastName = "Gross"
            };

            return View(dayTimeInstructor);
        }

        public ActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                    Id = 1,
                    FirstName = "Dwayne",
                    LastName = "Johnson"
                },
                new Instructor
                {
                    Id = 2,
                    FirstName = "Roman",
                    LastName = "Reigns"
                },
                new Instructor
                {
                    Id = 3,
                    FirstName = "Opie",
                    LastName = "Dopey"
                }
            };

            return View(instructors);
        }
    }
}