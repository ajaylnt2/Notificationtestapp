using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NotificationTestApp.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult SMTPSettings()
        {
            return View();
        }

        public ActionResult Alerts()
        {
            return View();
        }
        public ActionResult Getdetails()
        {
            return View();
        }
    }
}