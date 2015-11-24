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
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Photography()
        {
            ViewBag.Title = "Photography";
            ViewBag.PageTitle = "Photography from around the Pacific Northwest";
            return View();
        }

        public ActionResult Games()
        {
            ViewBag.Title = "Computer/Video Games";
            ViewBag.PageTitle = "Computer and video games I play";
            return View();
        }
    }
}