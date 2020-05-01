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
            Console.WriteLine("********** FLIGHT SCHEDULES **********");

            FlightUtility.GenerateFlightSchedules();

            Console.WriteLine("********** FLIGHT ITENARIES **********");

            OrderUtility.GenerateFlightItenaries();

            Console.ReadLine();
        }
    }
}
