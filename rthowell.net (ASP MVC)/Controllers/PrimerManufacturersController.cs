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
    public class PrimerManufacturersController : Controller
    {
        private LorenDBContext db = new LorenDBContext();

        // GET: PrimerManufacturers
        public ActionResult Index()
        {
            return View(db.PrimerManufacturers.ToList());
        }

        // GET: PrimerManufacturers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrimerManufacturers primerManufacturers = db.PrimerManufacturers.Find(id);
            if (primerManufacturers == null)
            {
                return HttpNotFound();
            }
            return View(primerManufacturers);
        }

        // GET: PrimerManufacturers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PrimerManufacturers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PrimerId,MfgName,Type")] PrimerManufacturers primerManufacturers)
        {
            if (ModelState.IsValid)
            {
                db.PrimerManufacturers.Add(primerManufacturers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(primerManufacturers);
        }

        // GET: PrimerManufacturers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrimerManufacturers primerManufacturers = db.PrimerManufacturers.Find(id);
            if (primerManufacturers == null)
            {
                return HttpNotFound();
            }
            return View(primerManufacturers);
        }

        // POST: PrimerManufacturers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PrimerId,MfgName,Type")] PrimerManufacturers primerManufacturers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(primerManufacturers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(primerManufacturers);
        }

        // GET: PrimerManufacturers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrimerManufacturers primerManufacturers = db.PrimerManufacturers.Find(id);
            if (primerManufacturers == null)
            {
                return HttpNotFound();
            }
            return View(primerManufacturers);
        }

        // POST: PrimerManufacturers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PrimerManufacturers primerManufacturers = db.PrimerManufacturers.Find(id);
            db.PrimerManufacturers.Remove(primerManufacturers);
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
