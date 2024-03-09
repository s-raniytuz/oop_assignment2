using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class SelectedFlight
    {
        public string FlightNumber {  get; set; }
        public string Airline {  get; set; }
        public string Day {  get; set; }
        public string Time {  get; set; }
        public double Cost {  get; set; }
        public string Name { get; set; }
        public string Citizenship {  get; set; }

        public SelectedFlight()
        {
            FlightNumber = " ";
            Airline = "";
            Day = "";
            Time = "";
            Cost = 0;
            Name = "";
            Citizenship = "";
        }
    }
}
