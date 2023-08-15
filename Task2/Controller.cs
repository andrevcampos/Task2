using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Controller
    {

        public List<Customer> customers = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public void CreateCustomer(string firstname, string lastname, Boolean stallaccount)
        {
            if (stallaccount == true)
            {
                StaffAccount staffAccount = new StaffAccount(firstname, lastname);
                customers.Add(staffAccount);
            }
            else
            {
                PublicAccount publicAccount = new PublicAccount(firstname, lastname);
                customers.Add(publicAccount);
            }
        }

        public void Adding()
        {
            //add
        }
        public void Finding()
        {
            //add
        }
        public void Editing()
        {
            //add
        }
        public void Deleting()
        {
            //add
        }
    }
}
