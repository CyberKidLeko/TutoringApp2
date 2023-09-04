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

namespace TutoringApp
{
    public partial class AdminLogin : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        public string id;
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EduGuide.mdf;Integrated Security=True";

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
                string adminUsername = txtAdmin_ID.Text.Trim();
                string adminPassword = txtPassword.Text;

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "SELECT Username, Password FROM Admin WHERE Username = @Username AND Password = @Password";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Username", adminUsername);
                            command.Parameters.AddWithValue("@Password", adminPassword);

                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                // Admin login successful
                                MessageBox.Show("Admin login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Proceed with the admin tasks or open the admin dashboard form
                                AdminDashboard adminDashboardForm = new AdminDashboard();
                                adminDashboardForm.Show();

                                // Close or hide the login form as needed
                                this.Hide();
                            }
                            else
                            {
                                // Admin login failed
                                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void pbButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Welcome welcome = new Welcome();
            welcome.Show();
        }
    }
    }

