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

        private void populateModules()
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

                            cmbModuleFilter.DataSource = moduleNames; // Set the data source
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

        public void SetLoggedInUser(string username, string membershipType)
        {
            loggedInUsername = username;
            LoadAppointmentsForUser(loggedInUsername, membershipType);
        }

        


        private void LoadAppointmentsForUser(string username, string userType)
        {
            string appointmentsQuery = "";

            if (userType == "Tutor")
            {
                // Query appointments for tutors from the TutorAppointments table
                appointmentsQuery = "SELECT * FROM TutorAppointments WHERE Tutor_ID = @Username";
            }
            else if (userType == "Student")
            {
                // Query appointments for students from the StudentAppointments table
                appointmentsQuery = "SELECT * FROM StudentAppointments WHERE Student_ID = @Username";
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

        private void cmbModuleFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedModule = cmbModuleFilter.SelectedItem.ToString();

            // Assuming you have a method that fetches and populates the tutors based on the selected module
            LoadTutorsByModule(selectedModule);
        }

        private void LoadTutorsByModule(string selectedModule)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Tutor_FirstName, Tutor_LastName, Module_Code FROM Tutor WHERE Module_Code = @Module_Code";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Module_Code", selectedModule);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable tutorsTable = new DataTable();
                            adapter.Fill(tutorsTable);

                            dataGridViewAvailableTutors.DataSource = tutorsTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {

            populateModules();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
