namespace TutoringApp
{
    partial class Dashboard
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
            this.Dash = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFilterByModule = new System.Windows.Forms.ComboBox();
            this.lblFilterByModule = new System.Windows.Forms.Label();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageBookAppointment = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewAvailableTutors = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxProfile = new System.Windows.Forms.ListBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdatePhone = new System.Windows.Forms.Button();
            this.txtUpdatePhone = new System.Windows.Forms.TextBox();
            this.btnUpdateModule1 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbUpdateModule1 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Dash.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.tabPageBookAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableTutors)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dash
            // 
            this.Dash.Controls.Add(this.tabPage1);
            this.Dash.Controls.Add(this.tabPageBookAppointment);
            this.Dash.Controls.Add(this.tabPage3);
            this.Dash.Location = new System.Drawing.Point(12, 0);
            this.Dash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dash.Name = "Dash";
            this.Dash.SelectedIndex = 0;
            this.Dash.Size = new System.Drawing.Size(776, 505);
            this.Dash.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(179)))));
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbFilterByModule);
            this.tabPage1.Controls.Add(this.lblFilterByModule);
            this.tabPage1.Controls.Add(this.dataGridViewAppointments);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(768, 476);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Appointments";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(219, 308);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cancel selected appointment:";
            // 
            // cmbFilterByModule
            // 
            this.cmbFilterByModule.FormattingEnabled = true;
            this.cmbFilterByModule.Location = new System.Drawing.Point(219, 266);
            this.cmbFilterByModule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFilterByModule.Name = "cmbFilterByModule";
            this.cmbFilterByModule.Size = new System.Drawing.Size(151, 24);
            this.cmbFilterByModule.TabIndex = 3;
            this.cmbFilterByModule.SelectedIndexChanged += new System.EventHandler(this.cmbFilterByModule_SelectedIndexChanged);
            // 
            // lblFilterByModule
            // 
            this.lblFilterByModule.AutoSize = true;
            this.lblFilterByModule.Location = new System.Drawing.Point(9, 270);
            this.lblFilterByModule.Name = "lblFilterByModule";
            this.lblFilterByModule.Size = new System.Drawing.Size(105, 16);
            this.lblFilterByModule.TabIndex = 2;
            this.lblFilterByModule.Text = "Filter by module:";
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(9, 34);
            this.dataGridViewAppointments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.RowHeadersWidth = 51;
            this.dataGridViewAppointments.RowTemplate.Height = 24;
            this.dataGridViewAppointments.Size = new System.Drawing.Size(753, 228);
            this.dataGridViewAppointments.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current appointments";
            // 
            // tabPageBookAppointment
            // 
            this.tabPageBookAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(179)))));
            this.tabPageBookAppointment.Controls.Add(this.dateTimePicker1);
            this.tabPageBookAppointment.Controls.Add(this.txtSearch);
            this.tabPageBookAppointment.Controls.Add(this.btnBook);
            this.tabPageBookAppointment.Controls.Add(this.label6);
            this.tabPageBookAppointment.Controls.Add(this.dataGridViewAvailableTutors);
            this.tabPageBookAppointment.Controls.Add(this.label5);
            this.tabPageBookAppointment.Location = new System.Drawing.Point(4, 25);
            this.tabPageBookAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageBookAppointment.Name = "tabPageBookAppointment";
            this.tabPageBookAppointment.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageBookAppointment.Size = new System.Drawing.Size(768, 476);
            this.tabPageBookAppointment.TabIndex = 1;
            this.tabPageBookAppointment.Text = "Book Appointment";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 319);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(143, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(132, 22);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(241, 400);
            this.btnBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(216, 32);
            this.btnBook.TabIndex = 5;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Available Tutors";
            // 
            // dataGridViewAvailableTutors
            // 
            this.dataGridViewAvailableTutors.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewAvailableTutors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableTutors.Location = new System.Drawing.Point(5, 73);
            this.dataGridViewAvailableTutors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAvailableTutors.Name = "dataGridViewAvailableTutors";
            this.dataGridViewAvailableTutors.RowHeadersWidth = 51;
            this.dataGridViewAvailableTutors.RowTemplate.Height = 24;
            this.dataGridViewAvailableTutors.Size = new System.Drawing.Size(755, 223);
            this.dataGridViewAvailableTutors.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Filter by module:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(179)))));
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.btnLogout);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(768, 476);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Profile";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxProfile);
            this.panel1.Location = new System.Drawing.Point(8, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 176);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // listBoxProfile
            // 
            this.listBoxProfile.FormattingEnabled = true;
            this.listBoxProfile.ItemHeight = 16;
            this.listBoxProfile.Location = new System.Drawing.Point(5, 0);
            this.listBoxProfile.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxProfile.Name = "listBoxProfile";
            this.listBoxProfile.Size = new System.Drawing.Size(740, 180);
            this.listBoxProfile.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(571, 434);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(125, 23);
            this.btnLogout.TabIndex = 28;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUpdatePassword);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.txtConfirmNewPassword);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.txtNewPassword);
            this.groupBox3.Controls.Add(this.txtCurrentPassword);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Location = new System.Drawing.Point(11, 330);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(752, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Change Password";
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Location = new System.Drawing.Point(335, 46);
            this.btnUpdatePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(125, 23);
            this.btnUpdatePassword.TabIndex = 30;
            this.btnUpdatePassword.Text = "Update";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(5, 75);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(141, 16);
            this.label23.TabIndex = 26;
            this.label23.Text = "Confirm new password";
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(160, 71);
            this.txtConfirmNewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(152, 22);
            this.txtConfirmNewPassword.TabIndex = 26;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(5, 47);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(96, 16);
            this.label22.TabIndex = 25;
            this.label22.Text = "New password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(160, 44);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(152, 22);
            this.txtNewPassword.TabIndex = 24;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(160, 16);
            this.txtCurrentPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(152, 22);
            this.txtCurrentPassword.TabIndex = 23;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(5, 18);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(111, 16);
            this.label21.TabIndex = 0;
            this.label21.Text = "Current password";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdatePhone);
            this.groupBox2.Controls.Add(this.txtUpdatePhone);
            this.groupBox2.Controls.Add(this.btnUpdateModule1);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.cmbUpdateModule1);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Location = new System.Drawing.Point(11, 214);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(744, 111);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Details";
            // 
            // btnUpdatePhone
            // 
            this.btnUpdatePhone.Location = new System.Drawing.Point(335, 60);
            this.btnUpdatePhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdatePhone.Name = "btnUpdatePhone";
            this.btnUpdatePhone.Size = new System.Drawing.Size(125, 23);
            this.btnUpdatePhone.TabIndex = 33;
            this.btnUpdatePhone.Text = "Update";
            this.btnUpdatePhone.UseVisualStyleBackColor = true;
            this.btnUpdatePhone.Click += new System.EventHandler(this.btnUpdateEmail_Click);
            // 
            // txtUpdatePhone
            // 
            this.txtUpdatePhone.Location = new System.Drawing.Point(160, 59);
            this.txtUpdatePhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUpdatePhone.Name = "txtUpdatePhone";
            this.txtUpdatePhone.Size = new System.Drawing.Size(152, 22);
            this.txtUpdatePhone.TabIndex = 22;
            // 
            // btnUpdateModule1
            // 
            this.btnUpdateModule1.Location = new System.Drawing.Point(335, 15);
            this.btnUpdateModule1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateModule1.Name = "btnUpdateModule1";
            this.btnUpdateModule1.Size = new System.Drawing.Size(125, 23);
            this.btnUpdateModule1.TabIndex = 32;
            this.btnUpdateModule1.Text = "Update";
            this.btnUpdateModule1.UseVisualStyleBackColor = true;
            this.btnUpdateModule1.Click += new System.EventHandler(this.btnUpdateModule1_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(97, 16);
            this.label20.TabIndex = 21;
            this.label20.Text = "Update Phone:";
            // 
            // cmbUpdateModule1
            // 
            this.cmbUpdateModule1.FormattingEnabled = true;
            this.cmbUpdateModule1.Location = new System.Drawing.Point(160, 18);
            this.cmbUpdateModule1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUpdateModule1.Name = "cmbUpdateModule1";
            this.cmbUpdateModule1.Size = new System.Drawing.Size(152, 24);
            this.cmbUpdateModule1.TabIndex = 16;
            this.cmbUpdateModule1.SelectedIndexChanged += new System.EventHandler(this.cmbUpdateModule1_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 16);
            this.label17.TabIndex = 15;
            this.label17.Text = "Change Module 1:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Profile";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(124)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.Dash);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Dash.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.tabPageBookAppointment.ResumeLayout(false);
            this.tabPageBookAppointment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableTutors)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Dash;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageBookAppointment;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFilterByModule;
        private System.Windows.Forms.Label lblFilterByModule;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewAvailableTutors;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUpdatePhone;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbUpdateModule1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnUpdatePhone;
        private System.Windows.Forms.Button btnUpdateModule1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxProfile;
    }
}