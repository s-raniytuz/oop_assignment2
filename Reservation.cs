using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class Reservation
    {
        public string ReservationCode { get; set; }
        public Flight Flight { get; set; }
        public string Name { get; set; }
        public string Citizenship { get; set; }
        public string Status { get; set; }

        public Reservation(string reservationCode, Flight flight, string name, string citizenship, String status)
        {
            ReservationCode = reservationCode;
            Flight = flight;
            Name = name;
            Citizenship = citizenship;
            Status = status;
        }

        public string toString()
        {
            return $"{ReservationCode},{Flight.FlightNumber},{Flight.Airline},{Flight.DayOfTheWeek},{Flight.Time},{Flight.Cost},{Name},{Citizenship},{Status}";
        }

    }


}
