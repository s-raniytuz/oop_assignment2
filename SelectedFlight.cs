using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            FlightNumber = "";
            Airline = "";
            Day = "";
            Time = "";
            Cost = 0;
            Name = "";
            Citizenship = "";
        }

        public string getWriteString()
        {
            return $"{FlightNumber}, {Airline}, {Day}, {Time}, {Cost.ToString()}, {Name}, {Citizenship}";
        }

        public void reserveFlight()
        {
            // this shit is not working idk why
            string resDirectory = Path.Combine(AppContext.BaseDirectory, "res");
            string filename = "reservations.txt";
            string filepath = Path.Combine(resDirectory, filename);
            string selectedFlightString = $"{FlightNumber}, {Airline}, {Day}, {Time}, {Name}, {Citizenship}" + Environment.NewLine;
            File.AppendAllText(filepath, selectedFlightString);
        }
    }
}
