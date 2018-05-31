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

        public ActionResult Details(int id)
        {
            var model = _db.BusStops.Find(id);
            return View("Details", model);
        }

        public ActionResult ShowModal()
        {
            return View();
        }

        public ActionResult BusStop(int id)
        {
            var model =
                            from a in _db.Attractions
                            select a;
            var m = model.Where(s => s.BusStopID == id).ToList();


            return View(m);
        }



    }
}
