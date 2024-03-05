using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_DAL
{
    public class TripRepository
    {
        public List<Trip> GetTripsRepository()
        {
            // Create an instance of the entity model
            ItineraryPlannerEntities itineraryPlannerEntities = new ItineraryPlannerEntities();

            // Call Trip entity to get all trips
            var trips = itineraryPlannerEntities.Trips.ToList();

            return trips;
        }
        // Now, go to IP_BLL/TripService.cs

        public bool DeleteTripRepository(int tripId)
        {
            ItineraryPlannerEntities itineraryPlannerEntities = new ItineraryPlannerEntities();

            var trip = itineraryPlannerEntities.Trips.Where(x => x.TripId == tripId).FirstOrDefault();

            if (trip != null)
            {
                itineraryPlannerEntities.Trips.Remove(trip);
                itineraryPlannerEntities.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

