using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XSSWebService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Dom()
        {
            ViewBag.Title = "DOM XSS Demonstration";

            return View();
        }

        public ActionResult Persistent()
        {
            ViewBag.Title = "Persistent XSS Demonstration";

            return View();
        }

        public ActionResult Reflective()
        {
            ViewBag.Title = "Reflective XSS Demonstration";

            return View();
        }
    }
}
