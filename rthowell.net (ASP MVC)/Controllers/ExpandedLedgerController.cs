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
    public class ExpandedLedgerController : Controller
    {
        private LorenDBContext db = new LorenDBContext();

        // GET: ExpandedLedger
        public ActionResult Index()
        {
            return View(db.ExpandedLedger.ToList());
        }

        // GET: ExpandedLedger/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpandedLedger expandedLedger = db.ExpandedLedger.Find(id);
            if (expandedLedger == null)
            {
                return HttpNotFound();
            }
            return View(expandedLedger);
        }

        // GET: ExpandedLedger/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExpandedLedger/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LedgerId,CartrageName,BulletId,BrassId,PowderId,PowderWt,PowderLot,PrimerId,PrimerLot,COAL,AvgFPS,DeltaMin,DeltaMax,Notes")] ExpandedLedger expandedLedger)
        {
            if (ModelState.IsValid)
            {
                db.ExpandedLedger.Add(expandedLedger);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(expandedLedger);
        }

        // GET: ExpandedLedger/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpandedLedger expandedLedger = db.ExpandedLedger.Find(id);
            if (expandedLedger == null)
            {
                return HttpNotFound();
            }
            return View(expandedLedger);
        }

        // POST: ExpandedLedger/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LedgerId,CartrageName,BulletId,BrassId,PowderId,PowderWt,PowderLot,PrimerId,PrimerLot,COAL,AvgFPS,DeltaMin,DeltaMax,Notes")] ExpandedLedger expandedLedger)
        {
            if (ModelState.IsValid)
            {
                db.Entry(expandedLedger).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(expandedLedger);
        }

        // GET: ExpandedLedger/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpandedLedger expandedLedger = db.ExpandedLedger.Find(id);
            if (expandedLedger == null)
            {
                return HttpNotFound();
            }
            return View(expandedLedger);
        }

        // POST: ExpandedLedger/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ExpandedLedger expandedLedger = db.ExpandedLedger.Find(id);
            db.ExpandedLedger.Remove(expandedLedger);
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
