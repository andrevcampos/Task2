using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task2
{
    public partial class DeleteAccount : Form
    {
        public static DeleteAccount instance;
        Controller controller = new Controller();
        public int index;
        public DeleteAccount()
        {
            InitializeComponent();
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
            controller.ReadTextFile();
            Customer customer = controller.customers[index];
            label4.Text = customer.getFistName;
            label5.Text = customer.getLastName;
        }
    }
}
