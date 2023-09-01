using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task2
{
    public partial class SelectCustomer : Form
    {
        public static SelectCustomer instance;
        Controller controller = new Controller();
        public int index;
        public int accountindex;
        public SelectCustomer()
        {
            InitializeComponent();
            instance = this;
            controller.ReadBinaryData();
            ReadIndex();

            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label14.Visible = false;
            numericUpDown1.Visible = false;
            button2.Visible = false;
            label15.Visible = false;
            numericUpDown2.Visible = false;
            button3.Visible = false;
            label16.Visible = false;
            label17.Visible = false;

        }
        public void ReadIndex()
        {
            index = ManageCustomer.index;
            Customer customer = controller.customers[index];
            label3.Text = customer.getFistName + " " + customer.getLastName;

            listBox1.Items.Clear();

            foreach (Account a in customer.accounts)
            {
                listBox1.Items.Add(a.Info());
            }
            listBox1.SelectedIndex = -1;
            listBox1.DisplayMember = "balance";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageCustomer form = new ManageCustomer();
            this.Hide();
            form.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SelectCustomer_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer customer = controller.customers[index];
            Account account = customer.accounts[listBox1.SelectedIndex];
            accountindex = listBox1.SelectedIndex;
            //Account account = (Account)listBox1.SelectedItem;

            int Balance = account.Balance();
            label4.Visible = true;
            label5.Visible = true;
            label5.Text = "$" + Balance.ToString();
            int Fees = account.GetFees();
            label6.Visible = true;
            label7.Visible = true;
            label7.Text = "$" + Fees.ToString();

            if (account is Inverstiment)
            {
                string Interest = account.GetInterestrandom();
                label8.Visible = true;
                label9.Visible = true;
                label9.Text = Interest;
            }
            else
            {
                int Interest = account.GetInterest();
                label8.Visible = true;
                label9.Visible = true;
                label9.Text = Interest.ToString() + "%";
            }

            int Overdraft = account.GetOverdraft();
            label10.Visible = true;
            label11.Visible = true;
            label11.Text = "$" + Overdraft.ToString();

            label14.Visible = true;
            numericUpDown1.Visible = true;
            button2.Visible = true;
            button2.Tag = account;

            label15.Visible = true;
            numericUpDown2.Visible = true;
            button3.Visible = true;
            button3.Tag = account;

            label16.Visible = true;
            label17.Visible = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer customer = controller.customers[index];
            Account account = customer.accounts[accountindex];

            int withdrawal = (int)numericUpDown2.Value;
            try
            {
                account.Withdrawal(withdrawal);
            }
            catch (InsufficientFundsException ex)
            {
                // Show a pop-up message with the exception details
                MessageBox.Show(ex.ToString(), "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer customer = controller.customers[index];
            Account account = customer.accounts[accountindex];

            int deposit = (int)numericUpDown1.Value;
            try
            {
                account.Deposit(deposit);
            }
            catch (InvalidDepositException ex)
            {
                // Show a pop-up message with the exception details
                MessageBox.Show(ex.ToString(), "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
