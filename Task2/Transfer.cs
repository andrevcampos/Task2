using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Transfer : Form
    {
        public static Transfer instance;
        Controller controller = new Controller();
        public int index;
        public int accountindex;
        public Transfer()
        {
            InitializeComponent();
            instance = this;
            controller.ReadBinaryData();
            ReadIndex();
        }
        public void ReadIndex()
        {
            index = ManageCustomer.index;
            Customer customer = controller.customers[index];

            listBox1.Items.Clear();

            foreach (Account a in customer.accounts)
            {
                listBox1.Items.Add(a.Info());
            }
            listBox1.SelectedIndex = -1;
            foreach (Account a in customer.accounts)
            {
                listBox2.Items.Add(a.Info());
            }
            listBox1.SelectedIndex = -1;

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer customer = controller.customers[index];
            Account account = customer.accounts[listBox1.SelectedIndex];
            int balance = account.GetBalance;
            label4.Visible = true;
            label4.Text = balance.ToString();

            int Fees = account.GetFees();

            if (customer is StaffAccount)
            {
                int stafffee = Fees / 2;
                label6.Text = "Transaction Fee: $" + Fees + " (Staff Account $" + stafffee + ")";
            }
            else
            {
                label6.Text = "Transaction Fee: $" + Fees;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer customer = controller.customers[index];
            Account account = customer.accounts[listBox2.SelectedIndex];
            int balance = account.GetBalance;
            label5.Visible = true;
            label5.Text = balance.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1 || listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("You must select accounts.");
                return;
            }
            Customer customer = controller.customers[index];
            Account fromaccount = customer.accounts[listBox1.SelectedIndex];
            int frombalance = fromaccount.GetBalance;
            Account toaccount = customer.accounts[listBox2.SelectedIndex];
            int tobalance = toaccount.GetBalance;
            int transfer = (int)numericUpDown1.Value;
            int Fees = fromaccount.GetFees();

            if (customer is StaffAccount)
            {
                int stafffee = Fees / 2;
                Fees = stafffee;
            }

            int transferplusfee = transfer + Fees;

            if (listBox1.SelectedIndex == listBox2.SelectedIndex)
            {
                MessageBox.Show("You can't transfer to the same account. Please select different accounts.");
                return;
            }
            if (transfer <= 0)
            {
                MessageBox.Show("The transfer amount must be positive.");
                return;
            }
            if (frombalance < transferplusfee)
            {
                MessageBox.Show("You don't have the funds to transfer this amount.(Incliding Transactions fee)");
                return;
            }
            controller.Transfer(listBox1.SelectedIndex, listBox2.SelectedIndex, transfer, Fees);
            SelectCustomer form = new SelectCustomer();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            if (MessageBox.Show("Transfer successfully done!", "Transfer Money", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
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

        private void button1_Click(object sender, EventArgs e)
        {
            SelectCustomer form = new SelectCustomer();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            this.Hide();
            form.Show();
        }
    }
}
