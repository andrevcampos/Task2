using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using static System.Windows.Forms.LinkLabel;
using System.Reflection;

namespace Task2
{
    class Controller
    {
        public List<Customer> customers = new List<Customer>();
        public void Adding(string firstname, string lastname, bool stallaccount)
        {
            if(stallaccount == true)
            {
                StaffAccount staffAccount = new StaffAccount(firstname, lastname);
                customers.Add(staffAccount);
                WriteBinaryData();
            }
            if (stallaccount == false)
            {
                PublicAccount publicAccount = new PublicAccount(firstname, lastname);
                customers.Add(publicAccount);
                WriteBinaryData();
            }
        }
        public void Editing(int lineIndex, string firstname, string lastname)
        {
            if (lineIndex >= 0 && lineIndex < customers.Count)
            {
                Customer customer = customers[lineIndex];
                customer.getFistName = firstname;
                customer.getLastName = lastname;
                WriteBinaryData();
            }
            else
            {
                Console.WriteLine("Invalid line index.");
            }
        }
        public void Deleting(int index)
        {
            if (index >= 0 && index < customers.Count)
            {
                customers.RemoveAt(index);
                WriteBinaryData();
                Console.WriteLine("Line deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid line index.");
            }
        }
        public void CreateCustmors()
        {
            //Return if already read the file. 
            if(customers.Count > 0)
            {
                //not first run and using serialization.
                return;
            }
            else
            {
                Customer newcustomer1 = new PublicAccount("Andre", "Campos");
                Account newaccount = new Everyday(250);
                newcustomer1.accounts.Add(newaccount);
                Account newaccount1 = new Inverstiment(15, 6, 10, 500);
                newcustomer1.accounts.Add(newaccount1);
                Account newaccount5 = new Omni(10, 6, 500, 100);
                newcustomer1.accounts.Add(newaccount5);
                customers.Add(newcustomer1);

                Customer newcustomer2 = new PublicAccount("Oliver", "Campos");
                Account newaccount2 = new Inverstiment(10, 5, 9, 200);
                newcustomer2.accounts.Add(newaccount2);
                customers.Add(newcustomer2);

                Customer newcustomer3 = new StaffAccount("Beatriz", "Campos");
                Account newaccount3 = new Inverstiment(10, 4, 11, 200);
                newcustomer3.accounts.Add(newaccount3);
                customers.Add(newcustomer3);

                Customer newcustomer4 = new StaffAccount("Miguel", "Campos");
                Account newaccount4 = new Omni(10, 4, 1500, 3000);
                newcustomer4.accounts.Add(newaccount4);
                customers.Add(newcustomer4);

                WriteBinaryData();
            }
        }
        public void CreateAccount(int lineIndex, string type, int balance, int fees, int interest1, int interest2, int overdraft)
        {
            if (lineIndex >= 0 && lineIndex < customers.Count)
            {
                if (type == "Everyday")
                {
                    Account newaccount = new Everyday(balance);
                    Customer customer = customers[lineIndex];
                    customer.accounts.Add(newaccount);
                }
                if (type == "Inverstiment")
                {
                    Account newaccount = new Inverstiment(fees, interest1, interest2, balance);
                    int index = ManageCustomer.index;
                    Customer customer = customers[index];
                    customer.accounts.Add(newaccount);
                }
                if (type == "Omni")
                {
                    Account newaccount = new Omni(fees, interest1, overdraft, balance);
                    int index = ManageCustomer.index;
                    Customer customer = customers[index];
                    customer.accounts.Add(newaccount);
                }
                WriteBinaryData();
            }
            else
            {
                Console.WriteLine("Invalid line index.");
            }
            
        }
        public void DeleteAccount(int accountIndex)
        {
            int index = ManageCustomer.index;
            if(index >= 0 && index < customers.Count)
            {
                Customer customer = customers[index];
                if (accountIndex >= 0 && accountIndex < customer.accounts.Count)
                {
                    customer.accounts.RemoveAt(accountIndex);
                    WriteBinaryData();
                }
                else
                {
                    Console.WriteLine("Invalid line index.");
                }
            }
            else
            {
                Console.WriteLine("Invalid line index.");
            }
        }
        public void WriteBinaryData()
        {
            //create a formatting object
            IFormatter formatter = new BinaryFormatter();

            //Create a new IO stream to write to the file Objects.bin
            Stream stream = new FileStream("objects.bin", FileMode.Create,
            FileAccess.Write, FileShare.None);

            //use the formatter to serialize the collection and send it to the filestream
            formatter.Serialize(stream, customers);

            //close the file
            stream.Close();

        }
        public void ReadBinaryData()
        {
            IFormatter formatter = new BinaryFormatter();
            string filePath = "Objects.bin";
            if(File.Exists(filePath))
            {
                Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                if(stream.Length > 0)
                {
                    customers = (List<Customer>)formatter.Deserialize(stream);
                }
                stream.Close();
            }
            else
            {
                //File does not exist, so ignore or handle as needed.
                Console.WriteLine("File does not exist, ignoring...");
            }
            
        }
    }
}
