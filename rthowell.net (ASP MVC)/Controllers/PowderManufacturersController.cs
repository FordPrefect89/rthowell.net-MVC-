using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using rthowell.net__ASP_MVC_.Models;

namespace rthowell.net__ASP_MVC_.Controllers
{
    public class PowderManufacturersController : Controller
    {
        private LorenDBContext db = new LorenDBContext();

        // GET: PowderManufacturers
        public ActionResult Index()
        {
            return View(db.PowderManufacturers.ToList());
        }

        // GET: PowderManufacturers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PowderManufacturers powderManufacturers = db.PowderManufacturers.Find(id);
            if (powderManufacturers == null)
            {
                return HttpNotFound();
            }
            return View(powderManufacturers);
        }

        // GET: PowderManufacturers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PowderManufacturers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PowderId,PowderMfg,PowderName")] PowderManufacturers powderManufacturers)
        {
            if (ModelState.IsValid)
            {
                db.PowderManufacturers.Add(powderManufacturers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(powderManufacturers);
        }

        // GET: PowderManufacturers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PowderManufacturers powderManufacturers = db.PowderManufacturers.Find(id);
            if (powderManufacturers == null)
            {
                return HttpNotFound();
            }
            return View(powderManufacturers);
        }

        // POST: PowderManufacturers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PowderId,PowderMfg,PowderName")] PowderManufacturers powderManufacturers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(powderManufacturers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(powderManufacturers);
        }

        // GET: PowderManufacturers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PowderManufacturers powderManufacturers = db.PowderManufacturers.Find(id);
            if (powderManufacturers == null)
            {
                return HttpNotFound();
            }
            return View(powderManufacturers);
        }

        // POST: PowderManufacturers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PowderManufacturers powderManufacturers = db.PowderManufacturers.Find(id);
            db.PowderManufacturers.Remove(powderManufacturers);
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
    }
}
