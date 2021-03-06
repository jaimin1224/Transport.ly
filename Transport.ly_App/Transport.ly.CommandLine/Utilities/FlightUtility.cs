﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Transport.ly.CommandLine.Models;

namespace Transport.ly.CommandLine.Utilities
{
    /// <summary>
    /// This class contains flight related utility methods
    /// </summary>
    public class FlightUtility
    {
        public static List<FlightSchedule> GetFlightSchedules()
        {
            // Create an empty list to store flight schedules
            List<FlightSchedule> flights = new List<FlightSchedule>();

            // Add the flight schedules
            flights.Add(new FlightSchedule { FlightId = 0, Departure = "", Arrival = "", Day = 0 });
            flights.Add(new FlightSchedule { FlightId = 1, Departure = "YUL", Arrival = "YYZ", Day = 1 });
            flights.Add(new FlightSchedule { FlightId = 2, Departure = "YUL", Arrival = "YYC", Day = 1 });
            flights.Add(new FlightSchedule { FlightId = 3, Departure = "YUL", Arrival = "YVR", Day = 1 });
            flights.Add(new FlightSchedule { FlightId = 4, Departure = "YUL", Arrival = "YYZ", Day = 2 });
            flights.Add(new FlightSchedule { FlightId = 5, Departure = "YUL", Arrival = "YYC", Day = 2 });
            flights.Add(new FlightSchedule { FlightId = 6, Departure = "YUL", Arrival = "YVR", Day = 2 });

            // return the flights
            return flights;
        }

        public static void GenerateFlightSchedules()
        {
            List<FlightSchedule> flightSchedules = GetFlightSchedules();

            flightSchedules = flightSchedules.Where(x => x.FlightId != 0).ToList(); // remove flight id = 0

            foreach (var item in flightSchedules)
            {
                // Using string interpolation to output the result 
                Console.WriteLine($"Flight: {item.FlightId}, departure: {item.Departure}, arrival: {item.Arrival}, day: {item.Day}");
            }
        }
    }
}
