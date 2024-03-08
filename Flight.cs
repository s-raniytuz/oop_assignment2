using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class Flight
    {
        public string FlightNumber { get; set; }
        public string Airline { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public string DayOfTheWeek { get; set; }
        public string Time { get; set; }

        public int Idk { get; set; }
        public double Cost { get; set; }

        public Flight(string flightNumber, string airline, string departureAirport, string arrivalAirport, string day, string time, int idk, double cost)
        {
            FlightNumber = flightNumber;
            Airline = airline;
            DepartureAirport = departureAirport;
            ArrivalAirport = arrivalAirport;
            DayOfTheWeek = day;
            Time = time;
            Idk = idk;
            Cost = cost;
        }

        public string toString()
        {
            return $"Flight number: {FlightNumber}\nAirline: {Airline}\nDeparture Airport: {DepartureAirport}\nArrival Airport: {ArrivalAirport}\nDay: {DayOfTheWeek}\nTime: {Time}\nIdk: {Idk}\nCost: {Cost}\n";
        }
    }
}
