using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TutoringApp
{
    public partial class Login : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        public string id;
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\flore\OneDrive\Documents\TutoringApp2\TutoringApp\EduGuide.mdf;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }
        public string storeID()
        {
            id = txtUser_ID.Text;
            return id;
        }//
        private void btnLogin_Click(object sender, EventArgs e)
        {
            String table = " ";
            string query;
            string username = txtUser_ID.Text;
            string password = txtPassword.Text;

            if (checkBoxIsTutor.Checked == true)
            {
                table = "Tutor";
                query = $"SELECT COUNT(*) FROM {table} WHERE Tutor_ID = @Username AND Password = @Password";

            }
            else
            {
                table = "Student";
                query = $"SELECT COUNT(*) FROM {table} WHERE Student_ID = @Username AND Password = @Password";
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    // Bind the parameters to the values of the username and password
                    SqlParameter usernameParameter = command.Parameters.AddWithValue("@Username", username);
                    SqlParameter passwordParameter = command.Parameters.AddWithValue("@Password", password);

                    // Execute the query
                    int count = (int)command.ExecuteScalar();

                    // Close the connection
                    connection.Close();

                    // Check if the login is valid
                    if (count == 1)
                    {
                        // Login is valid
                        // Display the message box
                        MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string membershipType = getMember();
                        Dashboard dash = new Dashboard();
                        dash.SetLoggedInUser(username, membershipType);
                        dash.SetMembershipType(membershipType); // Set the membership type
                        dash.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Login is invalid
                        MessageBox.Show("Login unsuccessful\nPlease enter correct details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }


                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            storeID();

        }
        public String getMember()
        {
            if (checkBoxIsTutor.Checked)
            {
                return "Tutor";
            }
            else
            {
                return "Student";
            }
        }



        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pbButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Welcome welcome = new Welcome();    
            welcome.Show(); 
        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }
    }
}