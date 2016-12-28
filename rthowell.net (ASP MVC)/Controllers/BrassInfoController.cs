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
    public class BrassInfoController : Controller
    {
        private LorenDBContext db = new LorenDBContext();

        // GET: BrassInfo
        public ActionResult Index()
        {
            return View(db.BrassInfo.ToList());
        }

        // GET: BrassInfo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BrassInfo brassInfo = db.BrassInfo.Find(id);
            if (brassInfo == null)
            {
                return HttpNotFound();
            }
            return View(brassInfo);
        }

        // GET: BrassInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BrassInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BrassId,Caliber,BrassMfg,BrassWeight,Quantity,BrassLength")] BrassInfo brassInfo)
        {
            if (ModelState.IsValid)
            {
                db.BrassInfo.Add(brassInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(brassInfo);
        }

        // GET: BrassInfo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BrassInfo brassInfo = db.BrassInfo.Find(id);
            if (brassInfo == null)
            {
                return HttpNotFound();
            }
            return View(brassInfo);
        }

        // POST: BrassInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BrassId,Caliber,BrassMfg,BrassWeight,Quantity,BrassLength")] BrassInfo brassInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(brassInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(brassInfo);
        }

        // GET: BrassInfo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BrassInfo brassInfo = db.BrassInfo.Find(id);
            if (brassInfo == null)
            {
                return HttpNotFound();
            }
            return View(brassInfo);
        }

        // POST: BrassInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BrassInfo brassInfo = db.BrassInfo.Find(id);
            db.BrassInfo.Remove(brassInfo);
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
