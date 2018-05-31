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
            var m = from a in _db.Attractions
                    select a;
            var model = m.Where(a => a.BusStopID == id).ToList();
            //var s = _db.BusStops.Find(id);
            var s = _db.BusStops.ToList();
            var b = s.FirstOrDefault(st => st.BusStopID == id);
            var l = b.StopLocation;
            var n = from a in model
                        select new BusStopAttractionVM
                        {
                            BusStopID = a.BusStopID,
                            StopLocation = l,
                            ImgSrc = a.ImgSrc,
                            ImgDescription = a.ImgDescription
                            
                        };
            return View(n);
            //var model = _db.BusStops.Find(id);
            //return View("Details", model);
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
