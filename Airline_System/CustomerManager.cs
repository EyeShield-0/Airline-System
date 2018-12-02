using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_System
{
    class CustomerManager
    {
        private static int currentCustNo; //static customer number
        private int maxCustomers; // maximum number of customers
        private int numCustomers; // counter for the number of customers
        protected Customer[] cList;

        public CustomerManager(int seed, int maxCus)
        {
            currentCustNo = seed;
            maxCustomers = maxCus;
            numCustomers = 0;
            cList = new Customer[maxCus];
        }

        // Method that adds a customer,returns false if not added
        public bool addCustomer(string firstName, string lastName, string phone)
        {
            if (numCustomers >= maxCustomers)
            {
                return false;
            }

            if ((string.IsNullOrEmpty(firstName)) || (string.IsNullOrEmpty(lastName)) || (string.IsNullOrEmpty(phone))) { return false; }

            Customer a = new Customer(currentCustNo, firstName, lastName, phone);
            currentCustNo++;

            cList[numCustomers] = a;
            numCustomers++;
            return true;
        }

        // Returns -1 if not found 
        private int findCustomer(int custId)
        {
            for (int x = 0; x < numCustomers; x++)
            {
                if (cList[x].getCustomerId() == custId)
                {
                    return x;
                }
            }
            return -1;
        }

        // Returns true if customer exists
        public bool customerExist(int custId)
        {
            int x = findCustomer(custId);
            if (x == -1) return false;

            return true;
        }

        //  Returns the customer object from the list, if not found return a null
        public Customer getCustomer(int custId)
        {
            int pos = findCustomer(custId);
            if (pos == -1) return null;
            return cList[pos];
        }

        //method that deletes the customer in the list, returns true if deleted
        public bool deleteCustomer(int custId)
        {
            if (findCustomer(custId) == -1) { return false; } // customer doesn't exist

            Customer a = getCustomer(custId);
            a = cList[numCustomers - 1];
            numCustomers--;
            return true;
        }

        public string getCustomerList()
        {
            int interId;
            string sNumber = "Number", sName = "Name", sPhone = "Phone", interName, interPhone;

            string s = "Customer List:"+Environment.NewLine+ Environment.NewLine;
            s += String.Format($"{sNumber,-30} {sName, -30} {sPhone, -30}");
            s += Environment.NewLine;
            for (int x = 0; x < numCustomers; x++)
            {
                interId = cList[x].getCustomerId();
                interName = cList[x].getFirstName() + "  "+ cList[x].getLastName();
                interPhone = cList[x].getPhone();
                s += Environment.NewLine;
                s += String.Format($"{interId,-30} {interName, -30} {interPhone, -30}");
               
            }
            return s;

        }

    }
}
