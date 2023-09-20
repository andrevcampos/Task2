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
using System.Windows.Forms;
using System.Xml;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using PdfSharpCore.Pdf.IO;

namespace Task2
{
    /// <summary>
    /// This is the Controller Class
    /// </summary>
    class Controller
    {
        /// <summary>
        /// List of all customers registered
        /// </summary>
        public List<Customer> customers = new List<Customer>();

        /// <summary>
        /// Add new customers
        /// </summary>
        /// <param name="firstname">first name of the customer</param>
        /// <param name="lastname">last name of the customer</param>
        /// <param name="stallaccount">Is this going to be Staff Account</param>
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
        /// <summary>
        /// Edit Selected Customer
        /// </summary>
        /// <param name="lineIndex">index from the customer list</param>
        /// <param name="firstname">new firts name from the customer</param>
        /// <param name="lastname">new last name from the custoemr</param>
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
        /// <summary>
        /// Delete Customers
        /// </summary>
        /// <param name="index">index of the customer from the list</param>
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
        /// <summary>
        /// Create new customers
        /// </summary>
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
        /// <summary>
        /// Create New bank account to the customer
        /// </summary>
        /// <param name="lineIndex">index from the customer list</param>
        /// <param name="type">what type of account we are creating</param>
        /// <param name="balance">the initial balance</param>
        /// <param name="fees">account fee for transactions</param>
        /// <param name="interest1">interest</param>
        /// <param name="interest2">interest when account required variable interest</param>
        /// <param name="overdraft">the limit of overdraft from the new customer</param>
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
        /// <summary>
        /// Delete bank account from the customer
        /// </summary>
        /// <param name="accountIndex">account index from the customer account list</param>
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
        /// <summary>
        /// Transfer money from one account to another
        /// </summary>
        /// <param name="fromaccountIndex">index from the account list that is going to tranasfer the money</param>
        /// <param name="toaccountIndex">index from the account list that is going to receive the money</param>
        /// <param name="amount">the amount to transfer</param>
        /// <param name="fees">the fee that will be charge</param>
        public void Transfer(int fromaccountIndex, int toaccountIndex, int amount, int fees)
        {
            int index = ManageCustomer.index;
            Customer customer = customers[index];
            Account fromaccount = customer.accounts[fromaccountIndex];
            Account toaccount = customer.accounts[toaccountIndex];
            int amountwithfee = amount + fees;
            toaccount.Deposit(amount);
            fromaccount.Withdrawal(amountwithfee);
            WriteBinaryData();
        }
        /// <summary>
        /// Interest to be added to the customer account
        /// </summary>
        /// <param name="accountIndex">index from the account list to be added the interest</param>
        /// <param name="amount">the amount that will be deposit or withdraw</param>
        public void Interest(int accountIndex, int amount)
        {
            int index = ManageCustomer.index;
            Customer customer = customers[index];
            Account account = customer.accounts[accountIndex];
            account.Deposit(amount);
            WriteBinaryData();
        }
        /// <summary>
        /// This will save the information
        /// </summary>
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
        /// <summary>
        /// This will load the information
        /// </summary>
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
        /// <summary>
        /// Generate the Customer list and accounts 
        /// </summary>
        /// <param name="xmlFilePath">the file that will be saved.</param>
        public void GenerateXmlReport(string xmlFilePath)
        {
            try
            {
                // Create an XML document
                XmlDocument xmlDoc = new XmlDocument();

                // Create the root element
                XmlElement root = xmlDoc.CreateElement("CustomerReport");
                xmlDoc.AppendChild(root);

                // Add customer data to the XML document
                foreach (Customer customer in customers)
                {
                    XmlElement customerElement = xmlDoc.CreateElement("Customer");
                    root.AppendChild(customerElement);

                    // Add customer details
                    XmlElement firstNameElement = xmlDoc.CreateElement("FirstName");
                    firstNameElement.InnerText = customer.getFistName;
                    customerElement.AppendChild(firstNameElement);

                    XmlElement lastNameElement = xmlDoc.CreateElement("LastName");
                    lastNameElement.InnerText = customer.getLastName;
                    customerElement.AppendChild(lastNameElement);

                    // Add customer accounts (if applicable)
                    if (customer.accounts.Count > 0)
                    {
                        XmlElement accountsElement = xmlDoc.CreateElement("Accounts");
                        customerElement.AppendChild(accountsElement);

                        foreach (Account account in customer.accounts)
                        {
                            XmlElement accountElement = xmlDoc.CreateElement("Account");
                            accountsElement.AppendChild(accountElement);

                            XmlElement accountTypeElement = xmlDoc.CreateElement("AccountType");
                            accountTypeElement.InnerText = account.GetType().Name;
                            accountElement.AppendChild(accountTypeElement);

                            // Add more account details here
                        }
                    }
                }

                // Save the XML document to the specified file path
                xmlDoc.Save(xmlFilePath);

                Console.WriteLine("XML report generated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error generating XML report: {ex.Message}");
            }
        }
    }
}
