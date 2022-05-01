using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VipinProfile.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Works()
        {
            ViewBag.Message = "Work Areas in details.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Physical Address, Email and Phone numbers.";

            return View();
        }

        public ActionResult Accomplishments()
        {
            ViewBag.Message = "List of Accomplishments.";

            return View();
        }
        
    }
}