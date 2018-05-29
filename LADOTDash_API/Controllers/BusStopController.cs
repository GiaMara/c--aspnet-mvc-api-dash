using LADOTDash_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LADOTDash_API.Controllers
{
    public class BusStopController : ApiController
    {

        LADOTDashDB _db = new LADOTDashDB();



        public IEnumerable<BusStop> GetAllBusStops()
        {
            var busstops = _db.BusStops.ToList();
            return busstops;
        }

        public IHttpActionResult GetBusStop(int id)
        {
            var busstops = _db.BusStops.ToList();
            var busstop = busstops.FirstOrDefault((p) => p.BusStopID == id);
            if (busstop == null)
            {
                return NotFound();
            }
            return Ok(busstop);
        }
    }
}
