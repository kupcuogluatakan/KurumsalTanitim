using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fatihocal.Controllers
{
    public class HomepageController : Controller
    {
        // GET: Homepage
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }



        public ActionResult Portfolio()
        {
            return View();
        }


    }
}