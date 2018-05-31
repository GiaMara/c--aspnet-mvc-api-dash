using LADOTDash_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LADOTDash_API.Controllers
{
    public class BusStopAttractionController : ApiController
    {

        LADOTDashDB _db = new LADOTDashDB();



        public IEnumerable<BusStopAttractionVM> GetAllAttractions()
        {
            var attractions = _db.BusStopAttractions.ToList();
            return attractions;
        }

        public IHttpActionResult GetAttraction(int id)
        {
            var attractions = _db.BusStopAttractions.ToList();
            var attraction = attractions.FirstOrDefault((p) => p.BusStopID == id);
            if (attraction == null)
            {
                return NotFound();
            }
            return Ok(attraction);
        }
    }
}
