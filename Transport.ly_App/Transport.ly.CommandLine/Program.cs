using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using Transport.ly.CommandLine.Models;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Transport.ly.CommandLine.Utilities;

namespace Transport.ly.CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            List<FlightSchedule> flightSchedules = FlightUtility.GetFlightSchedules();

            flightSchedules = flightSchedules.Where(x => x.FlightId != 0).ToList(); // remove flight = 0

            foreach (var item in flightSchedules)
            {
                // Using string interpolation to output the result 
                Console.WriteLine($"Flight: {item.FlightId}, departure: {item.Departure}, arrival: {item.Arrival}, day: {item.Day}");
            }

            OrderUtility.GenerateFlightItenaries();

            Console.ReadLine();
        }
    }
}
