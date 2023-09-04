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
    public partial class AdminDashboard : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        public string id;
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EduGuide.mdf;Integrated Security=True";

        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

            PopulateAppointmentData();
            PopulateTutorReportData();
            PopulateStudentReportData();


        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

        }

        private void PopulateStudentReportData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Student"; // Select data from the Student table

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable studentReportTable = new DataTable();
                            adapter.Fill(studentReportTable);

                            dataGridViewStudentReport.DataSource = studentReportTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void PopulateTutorReportData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Tutor"; // Select data from the Tutor table

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable tutorReportTable = new DataTable();
                            adapter.Fill(tutorReportTable);

                            dataGridViewTutorReport.DataSource = tutorReportTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private void PopulateAppointmentData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Appointment";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable appointmentTable = new DataTable();
                            adapter.Fill(appointmentTable);

                            dataGridViewAppointmentReport.DataSource = appointmentTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnDeleteTutor_Click(object sender, EventArgs e)
        {
            // Check if any row is selected in the dataGridViewTutorReport
            if (dataGridViewTutorReport.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewTutorReport.SelectedRows[0];

                // Extract the value from the DataGridView for the Tutor_ID column
                int tutorID = Convert.ToInt32(selectedRow.Cells["Tutor_ID"].Value);

                // Perform the deletion in your database based on the tutorID
                
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string deleteQuery = "DELETE FROM Tutor WHERE Tutor_ID = @TutorID";

                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@TutorID", tutorID);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // The row was deleted successfully from the database
                                // Now im removing the row from the DataGridView
                                //dataGridViewTutorReport.Rows.Remove(selectedRow);
                                PopulateTutorReportData();
                                
                                MessageBox.Show("Tutor deleted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Tutor deletion failed. Please try again.");
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
                MessageBox.Show("Please select a tutor to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudentReport.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewStudentReport.SelectedRows[0];
                int studentID = Convert.ToInt32(selectedRow.Cells["Student_ID"].Value);

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string deleteQuery = "DELETE FROM Student WHERE Student_ID = @StudentID";

                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@StudentID", studentID);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // The row was deleted successfully from the database
                                //dataGridViewStudentReport.Rows.Remove(selectedRow);
                                
                                PopulateStudentReportData();

                                MessageBox.Show("Student deleted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Student deletion failed. Please try again.");
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
