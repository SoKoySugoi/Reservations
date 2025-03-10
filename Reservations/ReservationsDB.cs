using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    internal class ReservationsDB
    {
        private const string dir = @"..\..\Text_Files";
        private const string path = dir + @"\Reservations.txt";

        /// <summary>
        /// A StreamReader assigns reservations to the guest list from a text file.
        /// </summary>
        /// <returns>The guest list object</returns>
        public static List<Reservation> GetGuestList()
        {
            List<Reservation> guests = new List<Reservation>();

            StreamReader txtReader = new StreamReader(
                new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            while (!txtReader.EndOfStream)
            { 
                string line = txtReader.ReadLine();
                string[] columns = line.Split('|');

                Reservation guest = new Reservation();
                guest.ReservationName = columns[0];
                guest.ArrivalDate = Convert.ToDateTime(columns[1]);
                guest.DepartureDate = Convert.ToDateTime(columns[2]);
                guest.Stay = guest.DepartureDate.Subtract(guest.ArrivalDate);
                guest.Price = Convert.ToInt32(columns[4]);
                guest.AveragePrice = Convert.ToInt32(columns[5]);

                guests.Add(guest);
            }
            txtReader.Close();

            return guests;
        }

        /// <summary>
        /// A StreamWriter saves the guest list to a text file
        /// </summary>
        /// <param name="guestList">GuestList object</param>
        public static void SaveGuestList(List<Reservation> guestList)
        {
            StreamWriter txtWriter = new StreamWriter(
                new FileStream(path,FileMode.Create, FileAccess.Write));
            foreach (Reservation reservation in guestList)
            {
                txtWriter.Write(reservation.ReservationName + "|");
                txtWriter.Write(reservation.ArrivalDate.ToShortDateString() + "|");
                txtWriter.Write(reservation.DepartureDate.ToShortDateString() + "|");
                txtWriter.Write(reservation.Stay.TotalDays.ToString() + "|");
                txtWriter.Write(reservation.Price + "|");
                txtWriter.WriteLine(reservation.AveragePrice);
            }
            txtWriter.Close();
        }
    }
}
