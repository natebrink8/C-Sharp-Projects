using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();
        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
// LMS Step 517, #1 - InsureeController: add logic to calculate a quote based on these guidelines:
                //a.Start with a base of $50 / month.
                insuree.Quote = 50m;        // set base quote to $50
                //b.If the user is 18 or under, add $100 to the monthly total.
                if (DateTime.Now.Year - insuree.DateOfBirth.Year <= 18)
                {
                    insuree.Quote += 100m;
                }
                //c.If the user is from 19 to 25, add $50 to the monthly total.
                if (DateTime.Now.Year - insuree.DateOfBirth.Year <= 25 &&
                    DateTime.Now.Year - insuree.DateOfBirth.Year >= 19)
                {
                    insuree.Quote += 50m;
                }
                //d.If the user is 26 or older, add $25 to the monthly total.
                //Double check your code to ensure all ages are covered.
                if (DateTime.Now.Year - insuree.DateOfBirth.Year >= 26)
                {
                    insuree.Quote += 25m;
                }
                //e.If the car's year is before 2000, add $25 to the monthly total.
                if (insuree.CarYear < 2000)
                {
                    insuree.Quote += 25m;
                }

                //f.If the car's year is after 2015, add $25 to the monthly total.
                if (insuree.CarYear > 2015)
                {
                    insuree.Quote += 25m;
                }

                // g.If the car's Make is a Porsche, add $25 to the price.
                if (insuree.CarMake == "Porsche")
                {
                    insuree.Quote += 25m;
                }

                // h.If the car's Make is a Porsche and its model is a 911 Carrera,
                // add an additional $25 to the price.
                // (Meaning, this specific car will add a total of $50 to the price.)
                if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
                {
                    insuree.Quote += 25m;
                }

                //i.Add $10 to the monthly total for every speeding ticket the user has.
                decimal ticketCharge = insuree.SpeedingTickets * 10m;
                if (insuree.SpeedingTickets > 0)
                {
                    insuree.Quote += ticketCharge;
                }

                //j.If the user has ever had a DUI, add 25 % to the total.
                if (insuree.DUI == true)
                {
                    insuree.Quote *= 1.25m;
                }

                //k.If it's full coverage, add 50% to the total.
                if (insuree.CoverageType == true)
                {
                    insuree.Quote *= 1.5m;
                }

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }













            // ALL conditional quote logic should precede this VIEW RETURN:
            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        //public ActionResult Calculate()
    }
}
