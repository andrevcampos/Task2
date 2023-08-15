using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class Customer
    {
        static int nextCustomersID = 1;
        public int customerID;
        private string firstName;
        private string lastName;
        public Customer(string newFirstName, string newLastName)
        {
            customerID = nextCustomersID;
            nextCustomersID++;
            firstName = newFirstName;
            lastName = newLastName;
        }
        public virtual string Info()
        {
            return firstName + " " + lastName;
        }
        public override string ToString()
        {
            return Info();
        }
    }
    public class StaffAccount : Customer
    {
        private int discount;
        public StaffAccount(string newFirstName, string newLastName) : base(newFirstName, newLastName)
        {
            discount = 50;
        }
    }
    public class PublicAccount : Customer
    {
        private int discount;
        public PublicAccount(string newFirstName, string newLastName) : base(newFirstName, newLastName)
        {
            discount = 0;
        }
    }
}
