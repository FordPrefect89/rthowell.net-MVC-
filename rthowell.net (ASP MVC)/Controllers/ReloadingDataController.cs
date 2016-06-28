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
    public class ReloadingDataController : Controller
    {
        private LedgerDBContext db = new LedgerDBContext();

        // GET: ReloadingData
        public ActionResult Index(string cartridge)
        {
            ViewBag.Cartridge = (from c in db.ReloadingData select c.Cartridge).Distinct();

            var model = from r in db.ReloadingData
                        where r.Cartridge == cartridge || cartridge == null || cartridge == ""
                        select r;

            return View(model);//(db.ReloadingData.ToList());
        }

        // GET: ReloadingData/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReloadingData reloadingData = db.ReloadingData.Find(id);
            if (reloadingData == null)
            {
                return HttpNotFound();
            }
            return View(reloadingData);
        }

        // GET: ReloadingData/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReloadingData/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Cartridge,DateLoaded,LoadSource,BulletBrand,BulletType,BulletWeight,Powder,PowderWeight,PowderLot,PrimerBrand,PrimerType,PrimerLot,COL,Speed,Notes")] ReloadingData reloadingData)
        {
            if (ModelState.IsValid)
            {
                db.ReloadingData.Add(reloadingData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reloadingData);
        }

        // GET: ReloadingData/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReloadingData reloadingData = db.ReloadingData.Find(id);
            if (reloadingData == null)
            {
                return HttpNotFound();
            }
            return View(reloadingData);
        }

        // POST: ReloadingData/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Cartridge,DateLoaded,LoadSource,BulletBrand,BulletType,BulletWeight,Powder,PowderWeight,PowderLot,PrimerBrand,PrimerType,PrimerLot,COL,Speed,Notes")] ReloadingData reloadingData)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reloadingData).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reloadingData);
        }

        // GET: ReloadingData/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReloadingData reloadingData = db.ReloadingData.Find(id);
            if (reloadingData == null)
            {
                return HttpNotFound();
            }
            return View(reloadingData);
        }

        // POST: ReloadingData/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReloadingData reloadingData = db.ReloadingData.Find(id);
            db.ReloadingData.Remove(reloadingData);
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
