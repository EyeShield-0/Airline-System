using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_System
{
    class BookingManager
    {
        private static int currentBookingId;
        private int maxBooking; //maximum number of bookings
        private int numBooking; //counter for bookings
        private Booking[] bookingList;

        //Cons
        public BookingManager(int seed, int maxBooking)
        {
            currentBookingId = seed;
            this.maxBooking = maxBooking;
            numBooking = 0;
            bookingList = new Booking[maxBooking];
        }

        // Behaviours
        private int findBooking(int bookNum)
        {
            //int loc;
            for (int x = 0; x < numBooking; x++)
            {
                if (bookNum == bookingList[x].getBookNum()) return x;
            }
            return -1;
        }
        public int getNumBookings() { return numBooking; }

        public bool addBooking(Flight flight, Customer customer)
        {
            if (numBooking >= maxBooking) return false;

            Booking a = new Booking(DateTime.Now.ToString("M/d/yyyy"), currentBookingId, flight, customer);
            bookingList[numBooking] = a;
            numBooking++;
            currentBookingId++;
            return true;
        }

        public string viewBookingList()
        {
            string s = "Booking List:" + Environment.NewLine + Environment.NewLine;
            
            s += String.Format("{0,-30} {1,-30} {2,-30} {3,-30}", "Date", "BookingNum", "Name", "Flight");
            
            for (int x = 0; x < numBooking; x++)
            {
                s += Environment.NewLine;
                s += String.Format("{0,-30} {1,-30} {2,-30} {3,-30}", bookingList[x].getDate(), bookingList[x].getBookNum(), bookingList[x].getCustomer().getFirstName() + " " + bookingList[x].getCustomer().getLastName(), bookingList[x].getFlight().getFlightNumber());
            }
            return s;
        }


    }
}
