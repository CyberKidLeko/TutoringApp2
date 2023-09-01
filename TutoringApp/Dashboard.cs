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
    public partial class Dashboard : Form
    {
        public string loggedInUsername;
        public string loggedInPassword;
        public string membershipType;
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nkulu\Source\Repos\TutoringApp2\TutoringApp\EduGuide.mdf;Integrated Security=True";
        public Dashboard()
        {
            InitializeComponent();
        }

        //property to hold the logged-in user's membership type
        private string MembershipType { get; set; }

        public void SetMembershipType(string membershipType)
        {
            if (membershipType == "Tutor")
            {
                // Set controls visible for tutors
                Dash.TabPages.Remove(tabPageBookAppointment);
                cmbFilterByModule.Visible=false;
                txtSearchByTutor.Visible = false;
                lblFilterByModule.Visible = false;
                lblSearchByTutor.Visible=false;
            }
            else if (membershipType == "Student")
            {
                // Set controls visible for students
                // ... control visibility settings for students ...
            }
        }


        public void SetLoggedInUser(string username, string membershipType)
        {
            loggedInUsername = username;

            if (membershipType == "Student")
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string studentIDQuery = "SELECT Student_ID FROM Student WHERE Student_ID = @Username";

                        using (SqlCommand command = new SqlCommand(studentIDQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Username", username);

                            object studentIDObj = command.ExecuteScalar();
                            if (studentIDObj != null)
                            {
                                string studentID = studentIDObj.ToString();
                                LoadAppointmentsForUser(studentID, membershipType);
                            }
                            else
                            {
                                MessageBox.Show("Student ID not found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else if (membershipType == "Tutor")
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string tutorIDQuery = "SELECT Tutor_ID FROM Tutor WHERE Tutor_ID = @Username";

                        using (SqlCommand command = new SqlCommand(tutorIDQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Username", username);

                            object tutorIDObj = command.ExecuteScalar();
                            if (tutorIDObj != null)
                            {
                                string tutorID = tutorIDObj.ToString();
                                LoadAppointmentsForUser(tutorID, membershipType);
                            }
                            else
                            {
                                MessageBox.Show("Tutor ID not found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                // Handle other user types if needed
            }
        }



        //

        private void LoadAppointmentsForUser(string username, string membershipType)
        {
            string appointmentsQuery = "";

            if (membershipType == "Tutor")
            {
                // Query appointments for tutors from the Appointments table
                appointmentsQuery = "SELECT * FROM Appointment WHERE Tutor_ID = @Username";
            }
            else if (membershipType == "Student")
            {
                // Query appointments for students from the Appointments table
                appointmentsQuery = "SELECT * FROM Appointment WHERE Student_ID = @Username";
            }
            else
            {
                // Handle invalid user type
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(appointmentsQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable appointmentsTable = new DataTable();
                        adapter.Fill(appointmentsTable);

                        // Populate the DataGridView with appointments
                        dataGridViewAppointments.DataSource = appointmentsTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }






        private void Dashboard_Load(object sender, EventArgs e)
        {
            string username = loggedInUsername; // Use the actual username from the login form
            string membershipType = MembershipType;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Populate the ComboBoxes with module codes
                    string moduleQuery = "SELECT Module_Code FROM Module";

                    using (SqlCommand command = new SqlCommand(moduleQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Create lists to store module codes
                            List<string> moduleCodes1 = new List<string>();
                            List<string> moduleCodes2 = new List<string>();
                            List<string> moduleCodes3 = new List<string>();

                            // Read module codes and distribute them to the ComboBoxes
                            while (reader.Read())
                            {
                                string moduleCode = reader.GetString(0);

                                moduleCodes1.Add(moduleCode);
                                moduleCodes2.Add(moduleCode);
                                moduleCodes3.Add(moduleCode);
                            }

                            // Bind data to ComboBoxes
                            cmbUpdateModule1.DataSource = moduleCodes1;
                            cmbUpdateModule2.DataSource = moduleCodes2;
                            cmbUpdateModule3.DataSource = moduleCodes3;
                        }
                    }

                    // Display user information
                    string userInfoQuery = "";
                    if (membershipType == "Student")
                    {
                        userInfoQuery = "SELECT FirstName, LastName, Email, Student_ID FROM Student WHERE Student_ID = @Username";
                        lblUserType.Text = "Student";
                    }
                    else if (membershipType == "Tutor")
                    {
                        userInfoQuery = "SELECT Tutor_FirstName, Tutor_LastName, Email, Tutor_ID FROM Tutor WHERE Tutor_ID = @Username";
                        lblUserType.Text = "Tutor";
                    }
                    else
                    {
                        // Handle other user types if needed
                        MessageBox.Show("Invalid membership type.");
                        return;
                    }

                    using (SqlCommand command = new SqlCommand(userInfoQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Display user information
                                lblName.Text = reader.GetString(0);
                                lblSurname.Text = reader.GetString(1);
                                lblEmail.Text = reader.GetString(2);
                                lblStudentNo.Text = reader.GetString(3);
                            }
                        }
                    }

                    // Display modules
                    string moduleInfoQuery = "";
                    if (membershipType == "Student")
                    {
                        moduleInfoQuery = "SELECT Module_Code FROM StudentModules WHERE Student_ID = @Username";
                    }
                    else if (membershipType == "Tutor")
                    {
                        moduleInfoQuery = "SELECT Module_Code FROM TutorModules WHERE Tutor_ID = @Username";
                    }

                    using (SqlCommand command = new SqlCommand(moduleInfoQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            List<string> modules = new List<string>();

                            while (reader.Read())
                            {
                                modules.Add(reader.GetString(0));
                            }

                            // Display up to three modules (you can adjust as needed)
                            for (int i = 0; i < Math.Min(modules.Count, 3); i++)
                            {
                                if (i == 0)
                                    lblModule1.Text = modules[i];
                                else if (i == 1)
                                    lblModule2.Text = modules[i];
                                else if (i == 2)
                                    lblModule3.Text = modules[i];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            try
            {
                // Open a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to filter and retrieve data from the 'Tutor' table based on Module_Code
                    string sqlQuery = $"SELECT Tutor_ID, Tutor_FirstName, Tutor_LastName, Module_Code FROM Tutor WHERE Module_Code LIKE '%{keyword}%'";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Create a DataSet to hold the filtered data
                            DataSet ds = new DataSet();
                            adapter.Fill(ds, "Tutor");

                            // Set the DataView's RowFilter to apply the search criteria
                            DataView dataView = ds.Tables["Tutor"].DefaultView;
                            dataView.RowFilter = $"Module_Code LIKE '%{keyword}%'";

                            // Update the DataGridView's data source with the filtered data
                            dataGridViewAvailableTutors.DataSource = dataView;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            
                try
                {
                    // Get the selected row in the dataGridViewAvailableTutors
                    DataGridViewRow selectedRow = dataGridViewAvailableTutors.CurrentRow;

                    if (selectedRow != null)
                    {
                        string studentID = loggedInUsername; // Use the actual Student_ID from the login form
                        string tutorID = selectedRow.Cells["Tutor_ID"].Value.ToString();
                        string moduleCode = selectedRow.Cells["Module_Code"].Value.ToString();
                        DateTime dateTime = dateTimePicker1.Value;
                    
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                        string insertQuery = "INSERT INTO Appointment (Student_ID, Tutor_ID, Module_Code, Date) VALUES (@Student_ID, @Tutor_ID, @Module_Code, @Date)";

                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Student_ID", studentID);
                            command.Parameters.AddWithValue("@Tutor_ID", tutorID);
                            command.Parameters.AddWithValue("@Module_Code", moduleCode);
                            command.Parameters.AddWithValue("@Date", dateTime.Date); // Assuming dateTime is a DateTime object
                            command.ExecuteNonQuery();

                            MessageBox.Show("Booking successful!");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a tutor to book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        private void btnUpdateModule1_Click(object sender, EventArgs e)
        {
            try
            {
                string newModuleCode = cmbUpdateModule1.SelectedItem.ToString();
                string username = loggedInUsername;
                string membershipType = MembershipType;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateModuleQuery = "";

                    if (membershipType == "Student")
                    {
                        // Update the Student table with the new module code
                        updateModuleQuery = "UPDATE Student SET Module_Code = @NewModuleCode WHERE Student_ID = @Username";
                    }
                    else if (membershipType == "Tutor")
                    {
                        // Update the Tutor table with the new module code
                        updateModuleQuery = "UPDATE Tutor SET Module_Code = @NewModuleCode WHERE Tutor_ID = @Username";
                    }
                    else
                    {
                        // Handle other user types if needed
                        MessageBox.Show("Invalid membership type.");
                        return;
                    }

                    using (SqlCommand command = new SqlCommand(updateModuleQuery, connection))
                    {
                        command.Parameters.AddWithValue("@NewModuleCode", newModuleCode);
                        command.Parameters.AddWithValue("@Username", username);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Module updated successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnUpdateModule2_Click(object sender, EventArgs e)
        {
            try
            {
                string newModuleCode = cmbUpdateModule2.SelectedItem.ToString();
                string username = loggedInUsername; 
                string membershipType = MembershipType; 

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateModuleQuery = "";

                    if (membershipType == "Student")
                    {
                        // Update the Student table with the new module code
                        updateModuleQuery = "UPDATE Student SET Module_Code = @NewModuleCode WHERE Student_ID = @Username";
                    }
                    else if (membershipType == "Tutor")
                    {
                        // Update the Tutor table with the new module code
                        updateModuleQuery = "UPDATE Tutor SET Module_Code = @NewModuleCode WHERE Tutor_ID = @Username";
                    }
                    else
                    {
                        // Handle other user types if needed
                        MessageBox.Show("Invalid membership type.");
                        return;
                    }

                    using (SqlCommand command = new SqlCommand(updateModuleQuery, connection))
                    {
                        command.Parameters.AddWithValue("@NewModuleCode", newModuleCode);
                        command.Parameters.AddWithValue("@Username", username);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Module updated successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnUpdateModule3_Click(object sender, EventArgs e)
        {
            try
            {
                string newModuleCode = cmbUpdateModule3.SelectedItem.ToString();
                string username = loggedInUsername;
                string membershipType = MembershipType;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateModuleQuery = "";

                    if (membershipType == "Student")
                    {
                        // Update the Student table with the new module code
                        updateModuleQuery = "UPDATE Student SET Module_Code = @NewModuleCode WHERE Student_ID = @Username";
                    }
                    else if (membershipType == "Tutor")
                    {
                        // Update the Tutor table with the new module code
                        updateModuleQuery = "UPDATE Tutor SET Module_Code = @NewModuleCode WHERE Tutor_ID = @Username";
                    }
                    else
                    {
                        // Handle other user types if needed
                        MessageBox.Show("Invalid membership type.");
                        return;
                    }

                    using (SqlCommand command = new SqlCommand(updateModuleQuery, connection))
                    {
                        command.Parameters.AddWithValue("@NewModuleCode", newModuleCode);
                        command.Parameters.AddWithValue("@Username", username);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Module updated successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnUpdateEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
