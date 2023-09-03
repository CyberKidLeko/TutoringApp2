using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutoringApp
{
    public partial class Dashboard : Form
    {
        public string loggedInUsername;
        public string loggedInPassword;
        public string membershipType;
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\flore\OneDrive\Documents\TutoringApp2\TutoringApp\EduGuide.mdf;Integrated Security=True";

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
                
                lblFilterByModule.Visible = false;
                
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
            this.membershipType = membershipType;
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


        private void LoadAppointmentsForUser(string username, string membershipType)

        {
            string appointmentsQuery = "";

            if (membershipType == "Tutor")
            {
                appointmentsQuery = "SELECT * FROM Appointment WHERE Tutor_ID = @Username";
            }
            else if (membershipType == "Student")
            {
                appointmentsQuery = "SELECT * FROM Appointment WHERE Student_ID = @Username";
            }
            else
            {
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
            appointmentsQuery = "";

            if (membershipType == "Tutor")
            {
                appointmentsQuery = "SELECT * FROM Appointment WHERE Tutor_ID = @Username";
            }
            else if (membershipType == "Student")
            {
                appointmentsQuery = "SELECT * FROM Appointment WHERE Student_ID = @Username";
            }
            else
            {
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
            PopulateProfileListBox();

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

                            // Read module codes and distribute them to the ComboBoxes
                            while (reader.Read())
                            {
                                string moduleCode = reader.GetString(0);

                                moduleCodes1.Add(moduleCode);
                               
                            }

                            // Bind data to ComboBoxes
                            cmbUpdateModule1.DataSource = moduleCodes1;
                            
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
                string membershipType = this.membershipType; // Use the property instead of the local variable

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
                        // Update the ListBox with the new module code
                        PopulateProfileListBox();
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
         try
            {
                string newPhoneNumber = txtUpdatePhone.Text;
                string username = loggedInUsername;
                string membershipType = this.membershipType;

                if (string.IsNullOrWhiteSpace(newPhoneNumber))
                {
                    MessageBox.Show("Please enter a valid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate that the phone number is exactly 9 digits long
                if (!Regex.IsMatch(newPhoneNumber, @"^\d{9}$"))
                {
                    MessageBox.Show("Phone number must be 9 digits long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updatePhoneQuery = "";

                    if (membershipType == "Student")
                    {
                        // Update the Student table with the new phone number
                        updatePhoneQuery = "UPDATE Student SET Phone_Number = @NewPhoneNumber WHERE Student_ID = @Username";
                    }
                    else if (membershipType == "Tutor")
                    {
                        // Update the Tutor table with the new phone number
                        updatePhoneQuery = "UPDATE Tutor SET Phone_Number = @NewPhoneNumber WHERE Tutor_ID = @Username";
                    }
                    else
                    {
                        // Handle other user types if needed
                        MessageBox.Show("Invalid membership type.");
                        return;
                    }

                    using (SqlCommand command = new SqlCommand(updatePhoneQuery, connection))
                    {
                        command.Parameters.AddWithValue("@NewPhoneNumber", newPhoneNumber);
                        command.Parameters.AddWithValue("@Username", username);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Phone number updated successfully!");
                        // Update the ListBox with the new module code
                        PopulateProfileListBox();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        


        private void cmbUpdateModule1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Check if an appointment is selected in the dataGridViewAppointments
            if (dataGridViewAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to cancel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Assuming you have a column named "Appointment_ID" in your DataGridView
            int appointmentID = Convert.ToInt32(dataGridViewAppointments.SelectedRows[0].Cells["Appointment_ID"].Value);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Define the SQL DELETE query to cancel the appointment based on its ID
                    string deleteQuery = "DELETE FROM Appointment WHERE Appointment_ID = @AppointmentID";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@AppointmentID", appointmentID);

                        // Execute the DELETE query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Appointment canceled successfully!");
                            // Refresh the dataGridViewAppointments to reflect the updated data
                            LoadAppointmentsForUser(loggedInUsername, membershipType);
                        }
                        else
                        {
                            MessageBox.Show("Failed to cancel the appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchByTutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbFilterByModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected module code from the ComboBox
            string selectedModule = cmbFilterByModule.SelectedItem as string;

            if (string.IsNullOrEmpty(selectedModule))
            {
                // If no module is selected, show all appointments (you can change this behavior if needed)
                LoadAppointmentsForUser(loggedInUsername, membershipType);
            }
            else
            {
                // Filter appointments based on the selected module
                FilterAppointmentsByModule(selectedModule);
            }
        }

        private void FilterAppointmentsByModule(string moduleCode)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string filterQuery = "";

                    if (membershipType == "Tutor")
                    {
                        // Filter appointments for tutors by module
                        filterQuery = "SELECT * FROM Appointment WHERE Tutor_ID = @Username AND Module_Code = @ModuleCode";
                    }
                    else if (membershipType == "Student")
                    {
                        // Filter appointments for students by module
                        filterQuery = "SELECT * FROM Appointment WHERE Student_ID = @Username AND Module_Code = @ModuleCode";
                    }
                    else
                    {
                        // guys you can Handle other user types if needed
                        return;
                    }

                    using (SqlCommand command = new SqlCommand(filterQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", loggedInUsername);
                        command.Parameters.AddWithValue("@ModuleCode", moduleCode);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable filteredAppointmentsTable = new DataTable();
                        adapter.Fill(filteredAppointmentsTable);

                        // Populate the DataGridView with filtered appointments
                        dataGridViewAppointments.DataSource = filteredAppointmentsTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PopulateProfileListBox()

        {
            listBoxProfile.Items.Clear();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string profileQuery = "";

                    if (membershipType == "Student")
                    {
                        profileQuery = "SELECT Student_ID, Student_FirstName, Student_LastName, Phone_Number FROM Student WHERE Student_ID = @Username";
                    }
                    else if (membershipType == "Tutor")
                    {
                        profileQuery = "SELECT Tutor_ID, Tutor_FirstName, Tutor_LastName, Phone_Number, Module_Code FROM Tutor WHERE Tutor_ID = @Username";
                    }
                    else
                    {
                        return;
                    }

                    using (SqlCommand command = new SqlCommand(profileQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", loggedInUsername);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int userID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                                string firstName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                                string lastName = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                                int phoneNumber = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);

                                listBoxProfile.Items.Add($"User ID: {userID}");
                                listBoxProfile.Items.Add($"Name: {firstName} {lastName}");
                                listBoxProfile.Items.Add($"Phone Number: {phoneNumber}");

                                if (membershipType == "Tutor")
                                {
                                    string moduleCode = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                                    listBoxProfile.Items.Add($"Module Code: {moduleCode}");
                                }
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

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
           
                string username = loggedInUsername; // Use the logged-in username
                string currentPassword = txtCurrentPassword.Text;
                string newPassword = txtNewPassword.Text;
                string confirmNewPassword = txtConfirmNewPassword.Text;

                string table = membershipType; // Use the logged-in user's role
                string query = $"SELECT Password FROM {table} WHERE {table}_ID = @Username";

                try
                {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        string storedPassword = (command.ExecuteScalar() as string)?.Trim(); // Trim any leading/trailing spaces

                        if (storedPassword != null && storedPassword.Equals(currentPassword, StringComparison.Ordinal))
                        {
                            if (newPassword == confirmNewPassword)
                            {
                                // Update the password
                                string updateQuery = $"UPDATE {table} SET Password = @NewPassword WHERE {table}_ID = @Username";

                                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                                {
                                    updateCommand.Parameters.AddWithValue("@NewPassword", newPassword);
                                    updateCommand.Parameters.AddWithValue("@Username", username);
                                    updateCommand.ExecuteNonQuery();

                                    MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    // Clear the textboxes
                                    txtCurrentPassword.Text = "";
                                    txtNewPassword.Text = "";
                                    txtConfirmNewPassword.Text = "";
                                }
                            }
                            else
                            {
                                MessageBox.Show("New password and confirm password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

            }
            catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {   
                this.Close();
                Welcome welcome = new Welcome();
                welcome.Show();
            }
        }
    }



        // Call this method to populate the ListBox with profile information


    
}
