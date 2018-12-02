using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_System
{
    class Customer
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private string phone;


        public Customer(int customerId, string firstName, string lastName, string phone)
        {
            this.customerId = customerId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
        }

        public int getCustomerId() { return customerId; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public string getPhone() { return phone; }

        public override string ToString()
        {
            string s = "Customer " + customerId;
            s = s + "\nName: " + firstName + " " + lastName;
            s = s + "\nPhone: " + phone;

            return s;
        }


    }
}
