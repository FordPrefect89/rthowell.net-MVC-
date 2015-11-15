using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rthowell.net__ASP_MVC_.Controllers
{
    public class HobbiesController : Controller
    {
        // GET: Hobbies
        public ActionResult Photography()
        {
            ViewBag.Title = "Photography around the Pacific Northwest";
            ViewBag.PageTitle = "Photography";
            return View();
        }
    }
}