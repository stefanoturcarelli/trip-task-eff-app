using IP_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TripTaskEFApp.Controllers
{
    public class TempTripController : Controller
    {
        // GET: TempTrip
        public ActionResult Index()
        {
            TripService tr = new TripService();
            var trips = tr.GetAllTrips();
            return View(trips);
        }
    }
}