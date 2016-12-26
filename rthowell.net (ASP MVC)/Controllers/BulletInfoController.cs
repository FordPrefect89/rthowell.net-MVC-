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
    public class BulletInfoController : Controller
    {
        private LorenDBContext db = new LorenDBContext();

        // GET: BulletInfo
        public ActionResult Index()
        {
            return View(db.BulletInfo.ToList());
        }

        // GET: BulletInfo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BulletInfo bulletInfo = db.BulletInfo.Find(id);
            if (bulletInfo == null)
            {
                return HttpNotFound();
            }
            return View(bulletInfo);
        }

        // GET: BulletInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BulletInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BulletId,Mfg,Type,Caliber,Weight")] BulletInfo bulletInfo)
        {
            if (ModelState.IsValid)
            {
                db.BulletInfo.Add(bulletInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bulletInfo);
        }

        // GET: BulletInfo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BulletInfo bulletInfo = db.BulletInfo.Find(id);
            if (bulletInfo == null)
            {
                return HttpNotFound();
            }
            return View(bulletInfo);
        }

        // POST: BulletInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BulletId,Mfg,Type,Caliber,Weight")] BulletInfo bulletInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bulletInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bulletInfo);
        }

        // GET: BulletInfo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BulletInfo bulletInfo = db.BulletInfo.Find(id);
            if (bulletInfo == null)
            {
                return HttpNotFound();
            }
            return View(bulletInfo);
        }

        // POST: BulletInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BulletInfo bulletInfo = db.BulletInfo.Find(id);
            db.BulletInfo.Remove(bulletInfo);
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
