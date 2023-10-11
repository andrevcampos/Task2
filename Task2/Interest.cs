using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Interest : Form
    {
        public static Interest instance;
        Controller controller = new Controller();
        public int index;
        public int accountindex;
        public int balance;
        public int interest;
        public int amount;
        public Interest()
        {
            InitializeComponent();
            instance = this;
            controller.ReadBinaryData();
            ReadIndex();
        }
        public void ReadIndex()
        {
            index = ManageCustomer.index;
            accountindex = SelectCustomer.accountindex2;
            Customer customer = controller.customers[index];
            Account account = customer.accounts[accountindex];
            balance = account.GetBalance;
            int zinterest = account.GetInterest();
            int zinterestmax = account.GetInterestMax();
            label5.Text = "$" + balance.ToString();
            label2.Text = account.Info();

            if (account is Inverstiment)
            {
                Random r = new Random();
                int rInt = r.Next(zinterest, zinterestmax);
                interest = rInt;
                label6.Text = rInt.ToString() + "% (Variable from " + zinterest + "% to " + zinterestmax + "%)";
                amount = (interest * balance) / 100;
                label8.Text = "$" + amount.ToString();
            }
            else
            {
                interest = zinterest;
                label6.Text = interest.ToString() + "%";
                amount = (interest * balance) / 100;
                label8.Text = "$" + amount.ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            controller.Interest(accountindex, amount);
            SelectCustomer form = new SelectCustomer();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            if (MessageBox.Show("Interest successfully Added!", "Interest", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
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
