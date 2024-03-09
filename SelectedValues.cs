using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class SelectedValues
    {
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public string Weekday { get; set; }

        public SelectedValues()
        {
            DepartureAirport = "Any";
            ArrivalAirport = "Any";
            Weekday = "Any";
        }
    }
}
