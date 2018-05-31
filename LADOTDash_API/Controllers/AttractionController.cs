using LADOTDash_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LADOTDash_API.Controllers
{
    public class AttractionController : ApiController
    {
        LADOTDashDB _db = new LADOTDashDB();



        public IEnumerable<Attraction> GetAllAttractions()
        {
            var attractions = _db.Attractions.ToList();
            return attractions;
        }

        public IHttpActionResult GetAttraction(int id)
        {
            var attractions = _db.Attractions.ToList();
            var attraction = attractions.Where((p) => p.BusStopID == id).ToList();
            if (attraction == null)
            {
                return NotFound();
            }
            return Ok(attraction);
        }
    }
}
