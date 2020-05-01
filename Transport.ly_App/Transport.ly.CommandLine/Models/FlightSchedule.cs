using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.ly.CommandLine.Models
{
    /// <summary>
    /// POCO class for flight schedule
    /// </summary>
    public class FlightSchedule
    {
        public int FlightId { get; set; }

        public string Departure { get; set; }

        public string Arrival { get; set; }

        public int Day { get; set; }
    }
}
