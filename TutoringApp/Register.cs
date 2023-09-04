using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TutoringApp
{
    public partial class Register : Form
    {
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EduGuide.mdf;Integrated Security=True";
       
        public Register()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // Inside the Register_Load im populating the combobox
        private void Register_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT Module_Code FROM Module";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            List<string> moduleNames = new List<string>();

                            while (reader.Read())
                            {
                                moduleNames.Add(reader["Module_Code"].ToString());
                            }

                            comboBoxModule.DataSource = moduleNames; // Set the data source
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or display the exception message for debugging
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }


        public string GetModuleCode(string moduleName)
        {
            string moduleCode = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT Module_Code FROM Module WHERE Module_Name = @Module_Name";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Module_Name", moduleName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                moduleCode = reader["Module_Code"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or display the exception message for debugging
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return moduleCode;
        }




        private void btnRegister_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear(); // Clear any previous error icons
            // Get common user inputs from controls
            string name = txtName.Text;
            string surname = txtSurname.Text;
            int User_ID;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            int phone;


            if (string.IsNullOrWhiteSpace(name))
            {
                errorProvider1.SetError(txtName, "Name is required");
            }

            if (string.IsNullOrWhiteSpace(surname))
            {
                errorProvider1.SetError(txtSurname, "Surname is required");
            }

            if (!int.TryParse(txtUserID.Text, out User_ID))
            {
                errorProvider1.SetError(txtUserID, "User ID is required");
            }
           

            if (!int.TryParse(txtPhone.Text, out phone))
            {
                errorProvider1.SetError(txtPhone, "Phone number is required");
            }
            else if (!Regex.IsMatch(txtPhone.Text, @"^\d{9}$"))
            {
                errorProvider1.SetError(txtPhone, "Phone number must be 9 digits long");
                MessageBox.Show("Phone number must be 9 digits long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            if (password.Length < 8)
            {
                errorProvider1.SetError(txtPassword, "The password must be at least 8 characters long.");
            }
            else if (!password.Any(char.IsDigit))
            {
                errorProvider1.SetError(txtPassword, "The password must contain at least 1 number.");
            }
            else if (!password.Any(c => "!@#$%^&*()".Contains(c)))
            {
                errorProvider1.SetError(txtPassword, "The password must contain at least 1 special character.");
            }
            else
            {
                // Password meets all conditions; clear any error icon
                errorProvider1.SetError(txtPassword, "");
            }





            if (password != confirmPassword)
            {
                errorProvider1.SetError(txtConfirmPassword, "The password must contain at least 1 special character.");
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    if (radioButtonStudent.Checked)
                    {
                        

                        string insertQuery = "INSERT INTO Student (Student_ID, [Password], Student_FirstName, Student_LastName, Phone_Number) VALUES (@Student_ID, @Password, @Student_FirstName, @Student_LastName, @Phone_Number)";

                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Student_ID", User_ID);
                            command.Parameters.AddWithValue("@Password", password);
                            command.Parameters.AddWithValue("@Student_FirstName", name);
                            command.Parameters.AddWithValue("@Student_LastName", surname);
                            command.Parameters.AddWithValue("@Phone_Number", phone);

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Registration as student successful!");
                    }
                    else if (radioButtonTutor.Checked)
                    {
                        string selectedModule = (string)comboBoxModule.SelectedItem;
                        string module = comboBoxModule.SelectedValue.ToString();

                        // Check if a module has been selected
                        if (selectedModule == "")
                        {
                            MessageBox.Show("Please select a module", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Get the module code from the selected module
                        string moduleCode = GetModuleCode(selectedModule);

                        string insertQuery = "INSERT INTO Tutor (Tutor_ID, [Password], Tutor_FirstName, Tutor_LastName, Module_Code) VALUES (@Tutor_ID, @Password, @Tutor_FirstName, @Tutor_LastName, @Module_Code)";

                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Tutor_ID", User_ID);
                            command.Parameters.AddWithValue("@Password", password);
                            command.Parameters.AddWithValue("@Tutor_FirstName", name);
                            command.Parameters.AddWithValue("@Tutor_LastName", surname);
                            command.Parameters.AddWithValue("@Module_Code", module);

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Registration as tutor successful!");
                        Login log = new Login();
                        log.Show();
                        this.Hide();
                    }
                    else
                    {
                        errorProvider1.SetError(radioButtonTutor, "Select a Student or tutor");
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void radioButtonTutor_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxModuleDetails.Visible = radioButtonTutor.Checked;
        }

        private void pbButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Welcome welcome = new Welcome();
            welcome.Show();
        }
    }
}
