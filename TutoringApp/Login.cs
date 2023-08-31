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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //fields cannot be empty
            if (txtUsername.Text == "")
            {
                errorProvider1.SetError(txtUsername, "Please enter a username");
                txtUsername.Focus();
            }
            else if (txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "Please enter a password");
                txtPassword.Focus();
            }
            else
            {
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#457C9E");
        }
    }
}
