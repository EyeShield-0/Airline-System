using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_System
{
    class FlightManager
    {
        private int maxFlights; // maximum flights
        private int numFlights; // serves as a counter for number of flights
        private Flight[] flightList;

        public FlightManager(int maxFlights)
        {
            this.maxFlights = maxFlights;
            numFlights = 0;
            flightList = new Flight[maxFlights];
        }


        public int getMaxFlights() { return maxFlights; }
        public int getNumFlights() { return numFlights; }

        public bool addFlight(int flightNumber, string origin, string destination, int maxSeats)
        {
            if (numFlights >= maxFlights) { return false; }

            // Checks if the flight number is already in the system
            if (flightExist(flightNumber)) { return false; }

            if ((string.IsNullOrEmpty(origin)) || (string.IsNullOrEmpty(destination))) { return false; }

            Flight a = new Flight(flightNumber, origin, destination, maxSeats);

            flightList[numFlights] = a;
            numFlights++;
            return true;
        }

        //returns the position of the  flight
        private int findFlight(int flightNumber)
        {
            int pos = -1;
            for (int x = 0; x < numFlights; x++)
            {
                if (flightList[x].getFlightNumber() == flightNumber)
                    pos = x;
            }
            return pos;
        }

        //returns true if flight exists in the system
        public bool flightExist(int flightNumber)
        {
            int x = findFlight(flightNumber);
            if (x == -1) { return false; }
            return true;
        }

        // gets the pos object Flight in the flightlist.
        public Flight getFlight(int flightNumber)
        {
            int pos = findFlight(flightNumber);
            if (pos == -1) return null; // if it is not in the system , it returns a null flight
            return flightList[pos];

        }

        //deletes a flight in the system
        public bool deleteFlight(int flightNumber)
        {
            
            if (findFlight(flightNumber) == -1) { return false; } // flight doesn't exist return false

            Flight a = getFlight(flightNumber);
            a = flightList[numFlights - 1]; //switches the position of the last number to the object to be deleted
            numFlights--; //deletes the last number of flights
            return true; // flight successfully deleted
        }

        //outputs the flight list
        public string getFlightList()
        {
            
      
            string s = "Flight List:" + Environment.NewLine + Environment.NewLine;
            for (int x = 0; x < numFlights; x++)
            {
                s += Environment.NewLine;
                s += String.Format("{0,-20} {1,-20} {2,-20} {3,-20} {4,-20}", flightList[x].getFlightNumber(), " from ", flightList[x].getOrigin(), " to ", flightList[x].getDestination());
               
            }
            return s;
        }

    }
}
