using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class Flight
    {
        public string FlightNumber { get; set; }
        public string Airline { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public string DayOfTheWeek { get; set; }
        public string Time { get; set; }

        public int Capacity { get; set; }
        public double Cost { get; set; }

        public Flight(string flightNumber, string airline, string departureAirport, string arrivalAirport, string day, string time, int capacity, double cost)
        {
            FlightNumber = flightNumber;
            Airline = airline;
            DepartureAirport = departureAirport;
            ArrivalAirport = arrivalAirport;
            DayOfTheWeek = day;
            Time = time;
            Capacity = capacity;
            Cost = cost;
        }

        public string toString()
        {
            return $"Flight number: {FlightNumber}\nAirline: {Airline}\nDeparture Airport: {DepartureAirport}\nArrival Airport: {ArrivalAirport}\nDay: {DayOfTheWeek}\nTime: {Time}\nCapacity: {Capacity}\nCost: {Cost}\n";
        }
    }
}
