using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    public class Reservation
    {
        private string reservationName;
        private DateTime arrivalDate;
        private DateTime departureDate;
        private TimeSpan stay;
        private int price;
        private int averagePrice;

        /// <summary>
        /// The base constructor for a reservation.
        /// </summary>
        public Reservation() { }

        /// <summary>
        /// This constructor stores the reservation dates and calculates the price of the reservation.
        /// </summary>
        /// <param name="arrival">The first day the guest would like to reserve.</param>
        /// <param name="departure">The day the guest would like to leave.</param>
        public Reservation(DateTime arrival, DateTime departure, string reservationName)
        {
            ReservationName = reservationName;
            ArrivalDate = arrival;
            DepartureDate = departure;

            Stay = departure.Subtract(arrival);                             //Calculates the days stayed via .Subtract Method

            while (arrival < departure)                                     //This expression calculates the total price
            {                                                               //By incrementing the Day of the week until
                if ((arrival.DayOfWeek == DayOfWeek.Friday) ||              //The arrival date is equal to the departure
                    (arrival.DayOfWeek == DayOfWeek.Saturday))              //Date and accumulates the Price adjusted for
                { Price += 150; }                                           //The specified TimeSpan

                else Price += 120;
                arrival = arrival.AddDays(1);
            }

            AveragePrice = Price / Stay.Days;                               //Calculates the Average Price
            this.reservationName = reservationName;
        }

        public string ReservationName
        { get { return reservationName; }
            set { reservationName = value; } }

        public DateTime ArrivalDate
        { get { return arrivalDate; }
            set { arrivalDate = value; } }

        public DateTime DepartureDate
        { get { return departureDate; }
            set { departureDate = value; } }

        public TimeSpan Stay
        { get { return stay; }
            set { stay = value; } }

        public int Price
        { get { return price; }
            set { price = value; } }

        public int AveragePrice
        { get { return averagePrice; }
            set { averagePrice = value; } }

        /// <summary>
        /// ReservationName, ArrivalDate, DepartureDate, and Price ToString
        /// </summary>
        /// <returns>Formatted string value</returns>
        public string GetDisplayText()
        {
            string row;
            row = string.Format("{0,-20}{1,10}-{2,-12}({3,-3})",
                ReservationName, ArrivalDate.ToString("d"), 
                DepartureDate.ToString("d"), Price.ToString("c"));

            return row;
        }
    }

    internal class GuestList : IEnumerable
    {
        private List<Reservation> guestList;

        public delegate void ChangedHandler(GuestList reservations);
        public event ChangedHandler Changed;

        public GuestList()
        {
            guestList = new List<Reservation>();
        }

        public int Count => guestList.Count;

        public Reservation this[int i]
        {
            get
            {
                if (i < 0)
                { throw new ArgumentOutOfRangeException(i.ToString()); }
                else if (i > guestList.Count)
                { throw new ArgumentOutOfRangeException(i.ToString()); }

                return guestList[i];
            }
            set
            {
                guestList[i] = value;
                Changed(this);
            }
        }

        /// <summary>
        /// Adds a reservation to the guest list object.
        /// </summary>
        /// <param name="guest">Reservation object</param>
        public void Add(Reservation guest)
        {
            guestList.Add(guest);
            Changed(this);
        }

        public static GuestList operator + (GuestList guestList, Reservation guest)
        {
            guestList.Add(guest);
            return guestList;
        }

        /// <summary>
        /// Removes a reservation from the guest list object
        /// </summary>
        /// <param name="guest">Reservation object</param>
        public void Remove(Reservation guest)
        {
            guestList.Remove(guest);
            Changed(this);
        }

        public static GuestList operator - (GuestList guestList, Reservation guest)
        {
            guestList.Remove(guest);
            return guestList;
        }

        /// <summary>
        /// Fetches the guest list from a text file. 
        /// </summary>
        public void Fill() => guestList = ReservationsDB.GetGuestList();

        /// <summary>
        /// Saves the guest list to the text file.
        /// </summary>
        public void Save() => ReservationsDB.SaveGuestList(guestList);

        public IEnumerator GetEnumerator()
        {
            foreach (Reservation guest in guestList)
            { yield return guest; }
        }
    }
}
