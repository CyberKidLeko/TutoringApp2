using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutoringApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.IsMdiContainer= true;
            form1.Show();

            Welcome welcome= new Welcome();
            welcome.MdiParent = form1;
            welcome.Show();

            Login login= new Login();
            login.MdiParent = form1;

            Register register = new Register();
            register.MdiParent = form1;

            Dashboard dashboard = new Dashboard();
            dashboard.MdiParent = form1;
        }
    }
}
