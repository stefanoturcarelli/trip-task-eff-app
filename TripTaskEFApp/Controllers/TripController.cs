using AutoMapper;
using IP_BLL;
using IP_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TripTaskEFApp.Controllers
{
    public class TripController : Controller
    {
        // GET: Trip
        public ActionResult Index()
        {


            return View();
        }

        // Controller
        [HttpGet]
        public JsonResult GetTripsController()
        {
            TripService tripService = new TripService();
            List<TripVM> tripVMs = new List<TripVM>();

            var trips = tripService.GetTripsService();

            Mapper.Initialize(x => x.CreateMap<Trip, TripVM>());

            Mapper.Map(trips, tripVMs);

            return Json(tripVMs, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DeleteTripController(int tripId)
        {
            TripService tripService = new TripService();

            if (tripService.DeleteTripService(tripId))
            {
                return Json("Trip deleted successfully", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("Trip not deleted", JsonRequestBehavior.AllowGet);
            }
        }
    }
}