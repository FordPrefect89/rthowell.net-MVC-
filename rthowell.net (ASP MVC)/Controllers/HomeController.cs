using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rthowell.net__ASP_MVC_.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            ViewBag.PageTitle = "Home";
            return View();
        }

        public ActionResult Resume()
        {
            ViewBag.Title = "Richard's Resume";
            ViewBag.PageTitle = "Current Resume";
            return View();
        }

        public ActionResult Photography()
        {
            ViewBag.Title = "Photography";
            ViewBag.PageTitle = "Photos From the Northwest";
            return View();
        }
    }
}