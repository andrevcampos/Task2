using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class customercp : UserControl
    {
        public static customercp instance;
        Controller controller = new Controller();
        public customercp()
        {
            InitializeComponent();
            instance = this;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReadTextFile()
        {
            string[] strArray;

            var myfile = new StreamReader("../../../data.txt");
            while (!myfile.EndOfStream)
            {
                strArray = myfile.ReadLine().Split(',');
                if (strArray[2] == "true")
                {
                    controller.CreateCustomer(strArray[0], strArray[1], true);
                }
                else
                {
                    controller.CreateCustomer(strArray[0], strArray[1], false);
                }
            }
            myfile.Close();
            DisplayCustomers();
        }
        public void DisplayCustomers()
        {
            //make sure listbox is empty
            listBox1.Items.Clear();
            //Add the book titles to the listBox
            foreach (Customer c in controller.customers)
            {
                listBox1.Items.Add(c.Info());
            }
            //Select the first item
            listBox1.SelectedIndex = -1;
        }

        private void customercp_Load(object sender, EventArgs e)
        {
        }
    }
}
