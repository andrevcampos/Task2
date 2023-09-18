using System.Security.Principal;
using System.Windows.Forms;
using System.Xml;

namespace Task2
{
    public partial class MainForm : Form
    {
        public static MainForm instance;
        Controller controller = new Controller();
        public MainForm()
        {
            InitializeComponent();
            controller.ReadBinaryData();
            // Create customer if runs for the first time.
            controller.CreateCustmors();
            instance = this;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ManageCustomer form = new ManageCustomer();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCustomer form = new AddCustomer();
            this.Hide();
            form.Show();
        }
    }
}