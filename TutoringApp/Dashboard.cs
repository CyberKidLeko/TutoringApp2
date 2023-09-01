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
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ramah\Downloads\Group Project\Group Project\Group Project\TutoringApp\EduGuide.mdf"";Integrated Security=True";
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

        
    }
}
