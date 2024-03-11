using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class ReservationManager
    {
        public ReservationManager() {
            getReservationList();
        }
        public static List<Reservation> reservations = [];

        
        public void makeReservation(Flight flight, String name, String citizenship)
        {

            int reservationCount = reservations.Where((e)=> e.Flight.FlightNumber == flight.FlightNumber).Count();

            if(reservationCount == flight.Capacity)
            {
                throw new Exception("Flight is already fully booked. Please choose another.");

            }
            else
            {
                string resFolderPath = Path.Combine(AppContext.BaseDirectory, "res");
                string filePath = Path.Combine(resFolderPath, "reservations.txt");
                Reservation reservation = new Reservation(generateReservationCode(), flight, name, citizenship, "Active");
                File.AppendAllText(filePath, reservation.toString() + "\n");
                reservations.Add(reservation);
            }

        }

        public void getReservationList() {
            string resFolderPath = Path.Combine(AppContext.BaseDirectory, "res");
            string filePath = Path.Combine(resFolderPath, "reservations.txt");
           if(File.Exists(filePath))
            {
                String[] rLines = File.ReadAllLines(filePath);

                reservations.Clear();
                foreach (String line in rLines)
                {
                    string[] lineSplit = line.Split(',');
                    FlightManagement.getFlightList();
                    Flight flight = FlightManagement.getFlightByFlightCode(lineSplit[1])!;
                    Reservation reservation = new Reservation(lineSplit[0], flight, lineSplit[6], lineSplit[7], lineSplit[8]);
                    reservations.Add(reservation);
                }
            }
            else
            {
                File.CreateText(filePath).Dispose();
            }
           
        }

        public List<Reservation> findReservation(String reservationCode, String airline, String fullName)
        {
            return reservations.Where((e) => (e.ReservationCode == reservationCode && ((airline == "" && fullName == e.Name) || (fullName == "" && e.Flight?.Airline == airline) || (e.Flight?.Airline == airline && e.Name == fullName)))).ToList();
        }

        public void updateReservation(Reservation reservation) {
            string resFolderPath = Path.Combine(AppContext.BaseDirectory, "res");
            string filePath = Path.Combine(resFolderPath, "reservations.txt");
            String[] rLines = File.ReadAllLines(filePath);
            int index = reservations.FindIndex(r => r.ReservationCode == reservation.ReservationCode);
            if (index > -1)
            {
                rLines[index] = reservation.toString();
                File.WriteAllLines(filePath, rLines);
            }

        }

        public void cancelReservation(Reservation reservation)
        {
            string resFolderPath = Path.Combine(AppContext.BaseDirectory, "res");
            string filePath = Path.Combine(resFolderPath, "reservations.txt");
            List<String> rLines = File.ReadAllLines(filePath).ToList();
            int index = reservations.FindIndex(r => r.ReservationCode == reservation.ReservationCode);
            if (index > -1)
            {
                rLines.RemoveAt(index);
                File.WriteAllLines(filePath, rLines);
            }

        }


        String generateReservationCode()
        {
            String? lastReservationCode = reservations.Last().ReservationCode;
            String number = FormatNumber(0);
            if (lastReservationCode != null)
            {
                int lastReservationCodeInt = int.Parse(lastReservationCode.Substring(1));
                number = FormatNumber(lastReservationCodeInt + 1);
            }

            int dividend = reservations.Count;
            int divisor = 999;
            int quotient = (dividend / divisor) +1;

            Char letter = GetLetterInAlphabet(quotient);

            return $"{letter}{number}";
        }

        static char GetLetterInAlphabet(int position)
        {
            if (position >= 1 && position <= 26)
            {
                char letter = (char)(position + 64);
                return letter;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Position should be between 1 and 26.");
            }
        }
        static string FormatNumber(int number)
        {
            return number.ToString("D4");
        }
    }
}
