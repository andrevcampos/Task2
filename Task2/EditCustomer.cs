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
    public partial class EditCustomer : Form
    {
        public static EditCustomer instance;
        Controller controller = new Controller();
        public int index;
        public EditCustomer()
        {
            InitializeComponent();
            controller.ReadBinaryData();
            instance = this;
            ReadIndex();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ManageCustomer form = new ManageCustomer();
            this.Hide();
            form.Show();
        }
        public void ReadIndex()
        {
            index = ManageCustomer.index;
            Customer customer = controller.customers[index];
            textBox1.Text = customer.getFistName;
            textBox2.Text = customer.getLastName;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = textBox1.Text;
            string lastname = textBox2.Text;
            controller.Editing(index, firstname, lastname);

            ManageCustomer form = new ManageCustomer();
            if (MessageBox.Show("Account update successfully", "Update Account", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
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
    }
}
