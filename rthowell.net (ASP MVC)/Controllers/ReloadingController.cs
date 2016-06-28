using rthowell.net__ASP_MVC_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rthowell.net__ASP_MVC_.Controllers
{
    public class ReloadingController : Controller
    {
        // GET: Reloading
        public ActionResult Index()
        {
            var db = new ReloadingLedgerDBContext();
            var data = from jnk in db.ReloadingLedger
                       select jnk;
            return View(data.ToList());
        }
    }
}