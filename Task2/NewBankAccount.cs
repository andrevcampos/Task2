using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class NewBankAccount : Form
    {
        public static NewBankAccount instance;
        Controller controller = new Controller();
        int index;
        public NewBankAccount()
        {
            index = ManageCustomer.index;
            InitializeComponent();
            controller.ReadBinaryData();
            instance = this;
            comboBox1.Items.Add("Everyday");
            comboBox1.Items.Add("Inverstiment");
            comboBox1.Items.Add("Omni");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectCustomer form = new SelectCustomer();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int accountindex = comboBox1.SelectedIndex;
            if (accountindex == 0)
            {
                //Everyday Account
                hideobjects();
                numericUpDownBalance.Visible = true;
                label4.Visible = true;
                button2.Visible = true;

            }
            if (accountindex == 1)
            {
                //Inverstiment Account
                hideobjects();
                numericUpDownBalance.Visible = true;
                label4.Visible = true;
                label6.Visible = true;
                numericUpDownFees.Visible = true;
                label8.Visible = true;
                numericUpDownInterest1.Visible = true;
                numericUpDownInterest2.Visible = true;
                button2.Visible = true;
            }
            if (accountindex == 2)
            {
                //Omni Account
                hideobjects();
                numericUpDownBalance.Visible = true;
                label4.Visible = true;
                label6.Visible = true;
                numericUpDownFees.Visible = true;
                label8.Visible = true;
                numericUpDownInterest1.Visible = true;
                label10.Visible = true;
                numericUpDownOverdraft.Visible = true;
                button2.Visible = true;

            }
        }
        private void hideobjects()
        {
            numericUpDownBalance.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            numericUpDownFees.Visible = false;
            label8.Visible = false;
            numericUpDownInterest1.Visible = false;
            numericUpDownInterest2.Visible = false;
            label10.Visible = false;
            numericUpDownOverdraft.Visible = false;
            button2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int accountindex = comboBox1.SelectedIndex;
            //string type, int balance, int fees, int interest1, int interest2, int overdraft
            int balance = (int)numericUpDownBalance.Value;
            int fees = (int)numericUpDownFees.Value;
            int interest1 = (int)numericUpDownInterest1.Value;
            int interest2 = (int)numericUpDownInterest2.Value;
            int overdraft = (int)numericUpDownOverdraft.Value;

            //Everyday Account
            if (accountindex == 0)
            {
                if (balance < 0)
                {
                    MessageBox.Show("Invalid numbers! Balancecan't be negative.");
                    return;
                }
                controller.CreateAccount(index, "Everyday", balance, fees, interest1, interest2, overdraft);
            }

            //Inverstiment Account
            if (accountindex == 1)
            {
                if (balance < 0 || fees < 0 || interest1 < 0 || interest1 > interest2 || interest2 < 0 || interest2 < interest1 || overdraft < 0)
                {
                    MessageBox.Show("Invalid numbers! Balance, Free, Interest and Overdraft can't be negative.");
                    return;
                }
                controller.CreateAccount(index, "Inverstiment", balance, fees, interest1, interest2, overdraft);

            }

            //Omni Account
            if (accountindex == 2)
            {
                if (balance < 0 || fees < 0 || interest1 < 0 || overdraft < 0)
                {
                    MessageBox.Show("Invalid numbers! Balance, Free, Interest and Overdraft can't be negative.");
                    return;
                }
                controller.CreateAccount(index, "Omni", balance, fees, interest1, interest2, overdraft);
            }

            SelectCustomer form = new SelectCustomer();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            if (MessageBox.Show("Account created successfully", "New Bank Account", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                form.Show();
                this.Hide();
            }
            else
            {
                this.Hide();
                form.Show();
            }
        }
    }
}
