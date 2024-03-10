using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment2
{
    internal abstract class FlightManagement
    {
        public static List<Flight> getFlightList()
        {
            string resDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "res");
            string filename = "flights.csv";
            string filepath = Path.Combine(resDirectory, filename);
            string[] content = File.ReadAllLines(filepath);

            List<Flight> flights = new List<Flight>();

            foreach (string line in content)
            {
                string[] lineSplit = line.Split(',');
                Flight flight = new Flight(lineSplit[0], lineSplit[1], lineSplit[2], lineSplit[3], lineSplit[4], lineSplit[5], Int32.Parse(lineSplit[6]), Double.Parse(lineSplit[7]));
                flights.Add(flight);
            }

            return flights;
        }

        public static HashSet<string> fillDepartures(List<Flight> flightList)
        {
            HashSet<string> departures = new HashSet<string>();
            departures.Add("Any");
            foreach (Flight flight in flightList)
            {
                departures.Add(flight.DepartureAirport);
            }

            return departures;
        }

        public static HashSet<string> fillArrivals(List<Flight> flightList)
        {
            HashSet<string> arrivals = new HashSet<string>();
            arrivals.Add("Any");
            foreach (Flight flight in flightList)
            {
                arrivals.Add(flight.ArrivalAirport);
            }

            return arrivals;
        }
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
