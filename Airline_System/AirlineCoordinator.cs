using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_System
{
    class AirlineCoordinator
    {
        /*The AirlineCoordinator class defines an object that contains a FlightManager and CustomerManager object.
        It has the role of interfacing between the Menu and the Manager classes.*/

        private FlightManager flightMan; //connects to the flight manager class
        private CustomerManager customerMan; //connects to the customer managaer class
        private BookingManager bookingMan; // Connects to the booking manager class


        public AirlineCoordinator(int cSeed, int maxCust, int maxFl, int bSeed, int maxbookNo)
        {
            flightMan = new FlightManager(maxFl);
            customerMan = new CustomerManager(cSeed, maxCust);
            bookingMan = new BookingManager(bSeed, maxbookNo);
        }

        public bool addFlight(int flightNumber, string origin, string destination, int maxSeats)
        {
            return flightMan.addFlight(flightNumber, origin, destination, maxSeats);
        }

        public bool addCustomer(string firstName, string lastName, string phone)
        {
            return customerMan.addCustomer(firstName, lastName, phone);
        }

        public string flightList()
        {
            return flightMan.getFlightList();
        }

        public string customerList()
        {
            return customerMan.getCustomerList();
        }

        public bool deleteCustomer(int customerId)
        {
            return customerMan.deleteCustomer(customerId);
        }

        public bool deleteFlight(int flightId)
        {
            return flightMan.deleteFlight(flightId);
        }


        public bool addBook(int custId, int flightId)
        {

            if (!customerMan.customerExist(custId)) { return false; }
            if (!flightMan.flightExist(flightId)) { return false; }
            if (!flightMan.getFlight(flightId).addPassenger(customerMan.getCustomer(custId))) { return false; } // checks if flights has enough seats
            //also adds a cust to a flight


            if (bookingMan.addBooking(flightMan.getFlight(flightId), customerMan.getCustomer(custId)))
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public string viewBookingList()
        {
            return bookingMan.viewBookingList();

        }

    }

}

