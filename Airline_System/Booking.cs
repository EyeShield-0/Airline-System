using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_System
{
    class Booking
    {
        private string date;
        private int bookNum;
        private Flight flight;
        private Customer customer;


        //cons
        public Booking(string date, int bookNum, Flight flight, Customer customer)
        {
            this.date = date;
            this.bookNum = bookNum;
            this.flight = flight;
            this.customer = customer;
        }

        //getters
        public string getDate() { return date; }
        public int getBookNum() { return bookNum; }
        public Flight getFlight() { return flight; }
        public Customer getCustomer() { return customer; }

        public string tostring()
        {
            string s = "";
            s += "Date: " + date + "\tBookNum: " + bookNum;
            return s;

        }

    }
}
