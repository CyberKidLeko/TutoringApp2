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
using System.IO;

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
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SqlCommand to execute the query
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Appointment", connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable appointmentsTable = new DataTable();
                        adapter.Fill(appointmentsTable);

                        // relative file path to save the report
                        string relativeFilePath = "appointment_report.txt";
                        string fullPath = Path.GetFullPath(relativeFilePath); // Get the full path

                        using (StreamWriter writer = new StreamWriter(fullPath))
                        {
                            // report content
                            writer.WriteLine($"Report Page: {DateTime.Now}");
                            writer.WriteLine($"Total Entries: {appointmentsTable.Rows.Count}");
                            writer.WriteLine();

                            // here im Adding details for each appointment
                            foreach (DataRow row in appointmentsTable.Rows)
                            {
                                writer.WriteLine($"Appointment ID: {row["Appointment_ID"]}");
                                writer.WriteLine($"Student ID: {row["Student_ID"]}");
                                writer.WriteLine($"Tutor ID: {row["Tutor_ID"]}");
                                writer.WriteLine($"Module Code: {row["Module_Code"]}");
                                writer.WriteLine($"Date: {row["Date"]}");
                                writer.WriteLine();
                            }
                        }

                        MessageBox.Show($"Report generated and saved successfully at: {fullPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            // here i was Checking if any row is selected in the dataGridViewTutorReport
            if (dataGridViewTutorReport.SelectedRows.Count > 0)
            {
                
                DataGridViewRow selectedRow = dataGridViewTutorReport.SelectedRows[0];

                
                int tutorID = Convert.ToInt32(selectedRow.Cells["Tutor_ID"].Value);

                //deleting in the database based on the tutorID
                
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

        private void btnStudentGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Student", connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable studentTable = new DataTable();
                        adapter.Fill(studentTable);

                        
                        string relativeFilePath = "student_report.txt";
                        string fullPath = Path.GetFullPath(relativeFilePath); // Get the full path

                        using (StreamWriter writer = new StreamWriter(fullPath))
                        {
                            // report content
                            writer.WriteLine($"Report Page: {DateTime.Now}");
                            writer.WriteLine($"Total Entries: {studentTable.Rows.Count}");
                            writer.WriteLine();

                            //details for each student
                            foreach (DataRow row in studentTable.Rows)
                            {
                                writer.WriteLine($"Student ID: {row["Student_ID"]}");
                                writer.WriteLine($"First Name: {row["Student_FirstName"]}");
                                writer.WriteLine($"Last Name: {row["Student_LastName"]}");
                                writer.WriteLine($"Phone Number: {row["Phone_Number"]}");
                                writer.WriteLine();
                            }
                        }

                        MessageBox.Show($"Report generated and saved successfully at: {fullPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTutorGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Tutor", connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable tutorTable = new DataTable();
                        adapter.Fill(tutorTable);

                        
                        string relativeFilePath = "tutor_report.txt";
                        string fullPath = Path.GetFullPath(relativeFilePath); // Get the full path

                        using (StreamWriter writer = new StreamWriter(fullPath))
                        {
                            
                            writer.WriteLine($"Report Page: {DateTime.Now}");
                            writer.WriteLine($"Total Entries: {tutorTable.Rows.Count}");
                            writer.WriteLine();

                            //details for each tutor
                            foreach (DataRow row in tutorTable.Rows)
                            {
                                writer.WriteLine($"Tutor ID: {row["Tutor_ID"]}");
                                writer.WriteLine($"First Name: {row["Tutor_FirstName"]}");
                                writer.WriteLine($"Last Name: {row["Tutor_LastName"]}");
                                writer.WriteLine($"Phone Number: {row["Phone_Number"]}");
                                writer.WriteLine($"Module Code: {row["Module_Code"]}");
                                writer.WriteLine();
                            }
                        }

                        MessageBox.Show($"Report generated and saved successfully at: {fullPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
