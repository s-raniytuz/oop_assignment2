using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class FlightManagement
    {
        public static List<Flight> FindFlights(List<Flight> flights, string departureAirport, string arrivalAirport, string day)
        {
            List<Flight> searchList = new List<Flight>();

            foreach (Flight flight in flights)
            {
                if (flight.DepartureAirport == departureAirport && flight.ArrivalAirport == arrivalAirport && flight.DayOfTheWeek == day)
                {
                    searchList.Add(flight);
                }
            }

            return searchList;
        }

    }
}
