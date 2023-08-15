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
    public partial class ManageCustomer : Form
    {
        public static ManageCustomer instance;
        Controller controller = new Controller();
        private Boolean readfile = true;
        public ManageCustomer()
        {
            InitializeComponent();
            instance = this;
            ReadTextFile();
            DisplayCustomers();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void ReadTextFile()
        {
            if (readfile)
            {
                MessageBox.Show("First Name Required");
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
                readfile = false;
            }
        }
        public void DisplayCustomers()
        {
            listBox1.Items.Clear();
            foreach (Customer c in controller.customers)
            {
                listBox1.Items.Add(c.Info());
            }
            listBox1.SelectedIndex = -1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            this.Hide();
            form.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AddCustomer form = new AddCustomer();
            this.Hide();
            form.Show();
        }
    }
}
