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
            mainpage1.Visible = true;
            customercp1.Visible = false;
        }
        public void custmercontrol()
        {
            mainpage1.Visible = false;
            customercp1.Visible = true;
        }
    }
}