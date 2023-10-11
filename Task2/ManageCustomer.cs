using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task2
{
    public partial class ManageCustomer : Form
    {
        public static ManageCustomer instance;
        Controller controller = new Controller();
        public static int index = -1;
        public ManageCustomer()
        {
            InitializeComponent();
            instance = this;
            controller.ReadBinaryData();
            DisplayCustomers();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            this.Hide();
            form.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AddCustomer form = new AddCustomer();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            this.Hide();
            form.Show();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBox1.SelectedIndex;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                EditCustomer form = new EditCustomer();
                form.StartPosition = FormStartPosition.Manual;
                form.Location = this.Location;
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You must select a customer");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                DeleteAccount form = new DeleteAccount();
                form.StartPosition = FormStartPosition.Manual;
                form.Location = this.Location;
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You must select a customer");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                SelectCustomer form = new SelectCustomer();
                form.StartPosition = FormStartPosition.Manual;
                form.Location = this.Location;
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You must select a customer");
            }
        }
    }
}
