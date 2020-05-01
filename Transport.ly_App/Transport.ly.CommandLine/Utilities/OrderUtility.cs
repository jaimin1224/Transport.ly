using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Transport.ly.CommandLine.Models;

namespace Transport.ly.CommandLine.Utilities
{
    /// <summary>
    /// This class contains order related utility methods
    /// </summary>
    public class OrderUtility
    {
        public static void GenerateFlightItenaries()
        {
            // get json file
            var ordersJson = File.ReadAllText("Data/coding-assigment-orders.json");

            Dictionary<string, Order> orders = JsonConvert.DeserializeObject<Dictionary<string, Order>>(ordersJson);

            // set appropriate flight id for each order
            int YYZOrderCount = 0, YYCOrderCount = 0, YVROrderCount = 0;

            foreach (var item in orders)
            {
                if (item.Value.Destination == "YYZ")
                {
                    if (YYZOrderCount < 20)
                    {
                        item.Value.FlightId = 1;
                    }
                    else
                    {
                        item.Value.FlightId = 4;
                    }

                    YYZOrderCount++;
                }
                else if (item.Value.Destination == "YYC")
                {
                    if (YYCOrderCount < 20)
                    {
                        item.Value.FlightId = 2;
                    }
                    else
                    {
                        item.Value.FlightId = 5;
                    }

                    YYCOrderCount++;
                }
                else if (item.Value.Destination == "YVR")
                {
                    if (YVROrderCount < 20)
                    {
                        item.Value.FlightId = 3;
                    }
                    else
                    {
                        item.Value.FlightId = 6;
                    }

                    YVROrderCount++;
                }
                else
                {
                    // not scheduled flight
                    // keep flight id = 0
                    continue;
                }
            }

            List<FlightSchedule> flightSchedules = FlightUtility.GetFlightSchedules();

            var query = from order in orders
                        join flightsch in flightSchedules
                        on order.Value.FlightId equals flightsch.FlightId
                        select new
                        {
                            order = order.Key,
                            flightNumber = flightsch.FlightId,
                            departure = flightsch.Departure,
                            arrival = flightsch.Arrival,
                            day = flightsch.Day
                        };

            foreach (var item in query)
            {
                if (item.flightNumber != 0)
                {
                    Console.WriteLine($"order: {item.order}, flightNumber: {item.flightNumber}, departure: {item.departure}, arrival: {item.arrival}, day: {item.day}");
                }
                else
                {
                    Console.WriteLine($"order: {item.order}, flightNumber: not scheduled");
                }
            }
        }
    }
}
