namespace TutoringApp
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dataGridViewAppointmentReport = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeleteTutor = new System.Windows.Forms.Button();
            this.btnTutorGenerate = new System.Windows.Forms.Button();
            this.dataGridViewTutorReport = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnStudentGenerate = new System.Windows.Forms.Button();
            this.dataGridViewStudentReport = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointmentReport)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTutorReport)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentReport)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(124)))), ((int)(((byte)(158)))));
            this.tabPage1.Controls.Add(this.btnGenerate);
            this.tabPage1.Controls.Add(this.dataGridViewAppointmentReport);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Appointments";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(6, 342);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(156, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dataGridViewAppointmentReport
            // 
            this.dataGridViewAppointmentReport.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewAppointmentReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointmentReport.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewAppointmentReport.Name = "dataGridViewAppointmentReport";
            this.dataGridViewAppointmentReport.RowHeadersWidth = 51;
            this.dataGridViewAppointmentReport.RowTemplate.Height = 24;
            this.dataGridViewAppointmentReport.Size = new System.Drawing.Size(756, 330);
            this.dataGridViewAppointmentReport.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(124)))), ((int)(((byte)(158)))));
            this.tabPage2.Controls.Add(this.btnDeleteTutor);
            this.tabPage2.Controls.Add(this.btnTutorGenerate);
            this.tabPage2.Controls.Add(this.dataGridViewTutorReport);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tutors";
            // 
            // btnDeleteTutor
            // 
            this.btnDeleteTutor.Location = new System.Drawing.Point(302, 354);
            this.btnDeleteTutor.Name = "btnDeleteTutor";
            this.btnDeleteTutor.Size = new System.Drawing.Size(155, 23);
            this.btnDeleteTutor.TabIndex = 4;
            this.btnDeleteTutor.Text = "Delete Tutor";
            this.btnDeleteTutor.UseVisualStyleBackColor = true;
            this.btnDeleteTutor.Click += new System.EventHandler(this.btnDeleteTutor_Click);
            // 
            // btnTutorGenerate
            // 
            this.btnTutorGenerate.Location = new System.Drawing.Point(6, 355);
            this.btnTutorGenerate.Name = "btnTutorGenerate";
            this.btnTutorGenerate.Size = new System.Drawing.Size(156, 23);
            this.btnTutorGenerate.TabIndex = 3;
            this.btnTutorGenerate.Text = "Generate Report";
            this.btnTutorGenerate.UseVisualStyleBackColor = true;
            this.btnTutorGenerate.Click += new System.EventHandler(this.btnTutorGenerate_Click);
            // 
            // dataGridViewTutorReport
            // 
            this.dataGridViewTutorReport.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewTutorReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTutorReport.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewTutorReport.Name = "dataGridViewTutorReport";
            this.dataGridViewTutorReport.RowHeadersWidth = 51;
            this.dataGridViewTutorReport.RowTemplate.Height = 24;
            this.dataGridViewTutorReport.Size = new System.Drawing.Size(756, 330);
            this.dataGridViewTutorReport.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(124)))), ((int)(((byte)(158)))));
            this.tabPage3.Controls.Add(this.btnDeleteStudent);
            this.tabPage3.Controls.Add(this.btnStudentGenerate);
            this.tabPage3.Controls.Add(this.dataGridViewStudentReport);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 396);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Students";
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(302, 354);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(155, 23);
            this.btnDeleteStudent.TabIndex = 7;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnStudentGenerate
            // 
            this.btnStudentGenerate.Location = new System.Drawing.Point(6, 355);
            this.btnStudentGenerate.Name = "btnStudentGenerate";
            this.btnStudentGenerate.Size = new System.Drawing.Size(156, 23);
            this.btnStudentGenerate.TabIndex = 6;
            this.btnStudentGenerate.Text = "Generate Report";
            this.btnStudentGenerate.UseVisualStyleBackColor = true;
            this.btnStudentGenerate.Click += new System.EventHandler(this.btnStudentGenerate_Click);
            // 
            // dataGridViewStudentReport
            // 
            this.dataGridViewStudentReport.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewStudentReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentReport.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewStudentReport.Name = "dataGridViewStudentReport";
            this.dataGridViewStudentReport.RowHeadersWidth = 51;
            this.dataGridViewStudentReport.RowTemplate.Height = 24;
            this.dataGridViewStudentReport.Size = new System.Drawing.Size(756, 330);
            this.dataGridViewStudentReport.TabIndex = 5;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(124)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminDashboard";
            this.Text = "AminDahboar";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointmentReport)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTutorReport)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewAppointmentReport;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnDeleteTutor;
        private System.Windows.Forms.Button btnTutorGenerate;
        private System.Windows.Forms.DataGridView dataGridViewTutorReport;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnStudentGenerate;
        private System.Windows.Forms.DataGridView dataGridViewStudentReport;
    }
}