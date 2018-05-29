using LADOTDash_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LADOTDash_API.Controllers
{
    public class HomeController : Controller
    {
        LADOTDashDB _db = new LADOTDashDB();

        public ActionResult Index()
        {
                return View();
        }

        public ActionResult List()
        {
            var model = _db.BusStops.ToList();

            return View(model);
        }
    }
}
