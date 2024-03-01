using IP_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_BLL
{
    public class TripService
    {
        public List<Trip> GetTripsService()
        {
            List<Trip> trips = new List<Trip>();
            TripRepository tr = new TripRepository();

            trips = tr.GetAllTripsRepository();

            return trips;
        }
    }
}
