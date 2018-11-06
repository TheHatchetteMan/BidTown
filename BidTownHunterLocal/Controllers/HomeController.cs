//-------------------------------------------------------------------------------------------------------------------=
// Developer: Hunter Hatchette
// Accomplished: Modified the Home controller to add Browse, Ending-Soon, Top-Sellers, Account
//--------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BidTownHunterLocal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Browse()
        {
            ViewBag.Message = "Your browse page.";
            return View();
        }

        public ActionResult EndingSoon()
        {
            ViewBag.Message = "Your ending soon page.";
            return View();
        }

        public ActionResult TopSellers()
        {
            ViewBag.Message = "Your Top Sellers Page.";
            return View();
        }
        public ActionResult Account()
        {
            ViewBag.Message = "Your Account Page.";
            return View();
        }
    }
}