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
    public partial class AddCustomer : Form
    {
        public static AddCustomer instance;
        Controller controller = new Controller();
        public AddCustomer()
        {
            InitializeComponent();
            controller.ReadBinaryData();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = textBox1.Text;
            string lastname = textBox2.Text;
            Boolean staffaccount = checkBox1.Checked;

            if (firstname == "")
            {
                MessageBox.Show("First Name Required");
                return;
            }
            if (lastname == "")
            {
                MessageBox.Show("Last Name Required");
                return;
            }
            controller.Adding(firstname, lastname, staffaccount);

            ManageCustomer form = new ManageCustomer();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            if (MessageBox.Show("Account Created successfully", "New Account", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Hide();
                form.Show();
            }
            else
            {
                this.Hide();
                form.Show();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ManageCustomer form = new ManageCustomer();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            this.Hide();
            form.Show();
        }
    }
}
