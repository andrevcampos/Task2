using System.Security.Principal;
using System.Windows.Forms;
using System.Xml;

namespace Task2
{
    public partial class MainForm : Form
    {
        public static MainForm instance;
        public MainForm()
        {
            InitializeComponent();
            instance = this;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ManageCustomer form = new ManageCustomer();
            form.Show();
            this.Hide();
        }
    }
}