using System;

namespace TripTaskEFApp.Controllers
{
    public class TripVM
    {
        public string Destination { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}