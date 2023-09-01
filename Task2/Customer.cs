using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    [Serializable]
    public abstract class Customer
    {
        static int nextCustomersID = 1;
        public int customerID;
        private string firstName;
        private string lastName;
        public List<Account> accounts = new List<Account>();
        public Customer(string newFirstName, string newLastName)
        {
            customerID = nextCustomersID;
            nextCustomersID++;
            firstName = newFirstName;
            lastName = newLastName;
        }
        public string getFistName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string getLastName
        {
            get { return lastName; }
            set { lastName = value; }
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
    [Serializable]
    public class StaffAccount : Customer
    {
        private int discount;
        public StaffAccount(string newFirstName, string newLastName) : base(newFirstName, newLastName)
        {
            discount = 50;
        }
    }
    [Serializable]
    public class PublicAccount : Customer
    {
        private int discount;
        public PublicAccount(string newFirstName, string newLastName) : base(newFirstName, newLastName)
        {
            discount = 0;
        }
    }
}
