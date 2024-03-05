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
            // Create a new instance of the TripRepository class
            TripRepository tripRepository = new TripRepository();

            // Call the GetTripsRepository method of the tripRepository object
            var trips = tripRepository.GetTripsRepository();

            // Return the trips
            return trips;
        }
        // Now, go to the TripController class

        public bool DeleteTripService(int tripId)
        {
            // Create a new instance of the TripRepository class
            TripRepository tripRepository = new TripRepository();

            // Call the DeleteTripRepository method of the tripRepository object
            var isDeleted = tripRepository.DeleteTripRepository(tripId);

            // Return the isDeleted
            return isDeleted;
        }
    }
}
