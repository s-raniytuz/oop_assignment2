using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal abstract class AppFunctions
    {
        public static HashSet<string> fillDepartures(List<Flight> flightList)
        {
            HashSet<string> departures = new HashSet<string>();
            foreach (Flight flight in flightList)
            {
                departures.Add(flight.DepartureAirport);
            }

            return departures;
        }
    }
}
