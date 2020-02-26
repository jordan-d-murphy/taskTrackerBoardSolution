using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace taskTrackerBoardProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Task Tracker application";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "This is a contact page.";

            return View();
        }
    }
}