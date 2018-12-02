using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_System
{
    class Flight
    {
        private int flightNumber;
        private string origin;
        private string destination;
        private int maxSeats;
        private int numPassengers;
        private Customer[] passengerList;


        public Flight(int flightNumber, string origin, string destination, int masSeats)
        {
            this.flightNumber = flightNumber;
            this.origin = origin;
            this.destination = destination;
            maxSeats = masSeats;
            numPassengers = 0;
            passengerList = new Customer[masSeats];

        }
        public int getFlightNumber() { return flightNumber; }
        public string getOrigin() { return origin; }
        public string getDestination() { return destination; }
        public int getMaxSeats() { return maxSeats; }
        public int getNumPassengers() { return numPassengers; }

        // Returns true if passenger has been succesfully added
        public bool addPassenger(Customer a)
        {
            if (numPassengers >= maxSeats) return false;

            passengerList[numPassengers] = a;
            numPassengers++;
            return true;
        }

        public int findPassenger(int custId)
        {

            for (int x = 0; x <= numPassengers; x++)
            {
                if (passengerList[x].getCustomerId() == custId)
                {
                    return custId;
                }
            }

            return -1; //returns -1, an integer that means it's not in the array of passenger list
        }

        //Returns true if passenger has been successfully deleted
        public bool removePassenger(int custId)
        {
            int pos = -1;

            for (int x = 0; x < numPassengers; x++)
            {
                if (passengerList[x].getCustomerId() == custId)
                {
                    pos = x;
                }
            }
            if (pos == -1) return false;
            passengerList[pos] = passengerList[pos - 1];
            numPassengers--;
            return true;
        }

        //Ouputs the passengerList
        public string getPassengerList()
        {
            string s = "";
            Console.WriteLine("Flight List: ");
            Console.WriteLine("Firstname: \t\t Lastname: ");
            for (int x = 0; x <= numPassengers; x++)
            {
                string a = passengerList[x].getFirstName() + "\t\t" + passengerList[x].getLastName() + "\n";
                s += a;
            }
            return s;
        }

        public string toString()
        {
            string s = "Flight Number: " + flightNumber;
            s = s + "\nOrigin: " + origin;
            s = s + "\nDestination:" + destination;
            s = s + "\nNumber of Passengers:" + numPassengers;
            s = s + "\nAvailable seats:" + (maxSeats - numPassengers);
            s = s + getPassengerList();
            return s;

        }

    }
}
