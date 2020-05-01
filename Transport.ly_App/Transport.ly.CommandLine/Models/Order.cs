using System;
using System.Collections.Generic;
using System.Text;

namespace Transport.ly.CommandLine.Models
{
    /// <summary>
    /// POCO class for order json file
    /// </summary>
    public class Order
    {
        /// <summary>
        /// This property is not present in json file, but we need to be able to perform join
        /// </summary>
        public int FlightId { get; set; }

        public string Destination { get; set; }
    }
}
