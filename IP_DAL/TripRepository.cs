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
        public List<Trip> GetTrips()
        {
            List<Trip> trips = new List<Trip>();

            // Connect to the database using App.config connection string
            using (SqlConnection conn = new SqlConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("usp_GetAllTrips", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                }
            }
            return trips;
        }
    }

}

