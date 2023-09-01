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
            this.txtSearchByTutor = new System.Windows.Forms.TextBox();
            this.lblSearchByTutor = new System.Windows.Forms.Label();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdateModule3 = new System.Windows.Forms.Button();
            this.btnUpdateEmail = new System.Windows.Forms.Button();
            this.txtUpdateEmail = new System.Windows.Forms.TextBox();
            this.btnUpdateModule1 = new System.Windows.Forms.Button();
            this.btnUpdateModule2 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbUpdateModule3 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbUpdateModule2 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbUpdateModule1 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblModule3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblModule2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblModule1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Dash.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.tabPageBookAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableTutors)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dash
            // 
            this.Dash.Controls.Add(this.tabPage1);
            this.Dash.Controls.Add(this.tabPageBookAppointment);
            this.Dash.Controls.Add(this.tabPage3);
            this.Dash.Location = new System.Drawing.Point(12, 2);
            this.Dash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dash.Name = "Dash";
            this.Dash.SelectedIndex = 0;
            this.Dash.Size = new System.Drawing.Size(776, 505);
            this.Dash.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(149)))), ((int)(((byte)(179)))));
            this.tabPage1.Controls.Add(this.txtSearchByTutor);
            this.tabPage1.Controls.Add(this.lblSearchByTutor);
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
            // txtSearchByTutor
            // 
            this.txtSearchByTutor.Location = new System.Drawing.Point(219, 295);
            this.txtSearchByTutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchByTutor.Name = "txtSearchByTutor";
            this.txtSearchByTutor.Size = new System.Drawing.Size(151, 22);
            this.txtSearchByTutor.TabIndex = 7;
            // 
            // lblSearchByTutor
            // 
            this.lblSearchByTutor.AutoSize = true;
            this.lblSearchByTutor.Location = new System.Drawing.Point(5, 299);
            this.lblSearchByTutor.Name = "lblSearchByTutor";
            this.lblSearchByTutor.Size = new System.Drawing.Size(136, 16);
            this.lblSearchByTutor.TabIndex = 6;
            this.lblSearchByTutor.Text = "Search by tutor name:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(219, 324);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 327);
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
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(143, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(768, 476);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Profile";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUpdatePassword);
            this.groupBox3.Controls.Add(this.btnLogout);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.txtConfirmPassword);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.txtNewPassword);
            this.groupBox3.Controls.Add(this.txtCurrentPassword);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Location = new System.Drawing.Point(11, 368);
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
            this.btnUpdatePassword.Location = new System.Drawing.Point(335, 69);
            this.btnUpdatePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(125, 23);
            this.btnUpdatePassword.TabIndex = 30;
            this.btnUpdatePassword.Text = "Update";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(563, 47);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(125, 23);
            this.btnLogout.TabIndex = 28;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
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
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(160, 71);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(152, 22);
            this.txtConfirmPassword.TabIndex = 26;
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
            this.groupBox2.Controls.Add(this.btnUpdateModule3);
            this.groupBox2.Controls.Add(this.btnUpdateEmail);
            this.groupBox2.Controls.Add(this.txtUpdateEmail);
            this.groupBox2.Controls.Add(this.btnUpdateModule1);
            this.groupBox2.Controls.Add(this.btnUpdateModule2);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.cmbUpdateModule3);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.cmbUpdateModule2);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.cmbUpdateModule1);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Location = new System.Drawing.Point(11, 222);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(752, 140);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Details";
            // 
            // btnUpdateModule3
            // 
            this.btnUpdateModule3.Location = new System.Drawing.Point(335, 76);
            this.btnUpdateModule3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateModule3.Name = "btnUpdateModule3";
            this.btnUpdateModule3.Size = new System.Drawing.Size(125, 23);
            this.btnUpdateModule3.TabIndex = 34;
            this.btnUpdateModule3.Text = "Update";
            this.btnUpdateModule3.UseVisualStyleBackColor = true;
            this.btnUpdateModule3.Click += new System.EventHandler(this.btnUpdateModule3_Click);
            // 
            // btnUpdateEmail
            // 
            this.btnUpdateEmail.Location = new System.Drawing.Point(335, 106);
            this.btnUpdateEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateEmail.Name = "btnUpdateEmail";
            this.btnUpdateEmail.Size = new System.Drawing.Size(125, 23);
            this.btnUpdateEmail.TabIndex = 33;
            this.btnUpdateEmail.Text = "Update";
            this.btnUpdateEmail.UseVisualStyleBackColor = true;
            this.btnUpdateEmail.Click += new System.EventHandler(this.btnUpdateEmail_Click);
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.Location = new System.Drawing.Point(160, 110);
            this.txtUpdateEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.Size = new System.Drawing.Size(152, 22);
            this.txtUpdateEmail.TabIndex = 22;
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
            // btnUpdateModule2
            // 
            this.btnUpdateModule2.Location = new System.Drawing.Point(335, 48);
            this.btnUpdateModule2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateModule2.Name = "btnUpdateModule2";
            this.btnUpdateModule2.Size = new System.Drawing.Size(125, 23);
            this.btnUpdateModule2.TabIndex = 31;
            this.btnUpdateModule2.Text = "Update";
            this.btnUpdateModule2.UseVisualStyleBackColor = true;
            this.btnUpdateModule2.Click += new System.EventHandler(this.btnUpdateModule2_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 110);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 16);
            this.label20.TabIndex = 21;
            this.label20.Text = "Update email:";
            // 
            // cmbUpdateModule3
            // 
            this.cmbUpdateModule3.FormattingEnabled = true;
            this.cmbUpdateModule3.Location = new System.Drawing.Point(160, 79);
            this.cmbUpdateModule3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUpdateModule3.Name = "cmbUpdateModule3";
            this.cmbUpdateModule3.Size = new System.Drawing.Size(152, 24);
            this.cmbUpdateModule3.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 79);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(115, 16);
            this.label19.TabIndex = 19;
            this.label19.Text = "Change Module 3:";
            // 
            // cmbUpdateModule2
            // 
            this.cmbUpdateModule2.FormattingEnabled = true;
            this.cmbUpdateModule2.Location = new System.Drawing.Point(160, 48);
            this.cmbUpdateModule2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUpdateModule2.Name = "cmbUpdateModule2";
            this.cmbUpdateModule2.Size = new System.Drawing.Size(152, 24);
            this.cmbUpdateModule2.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(115, 16);
            this.label18.TabIndex = 17;
            this.label18.Text = "Change Module 2:";
            // 
            // cmbUpdateModule1
            // 
            this.cmbUpdateModule1.FormattingEnabled = true;
            this.cmbUpdateModule1.Location = new System.Drawing.Point(160, 18);
            this.cmbUpdateModule1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUpdateModule1.Name = "cmbUpdateModule1";
            this.cmbUpdateModule1.Size = new System.Drawing.Size(152, 24);
            this.cmbUpdateModule1.TabIndex = 16;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblModule3);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblModule2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblModule1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblUserType);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblStudentNo);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblSurname);
            this.groupBox1.Location = new System.Drawing.Point(11, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(752, 188);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal details";
            // 
            // lblModule3
            // 
            this.lblModule3.AutoSize = true;
            this.lblModule3.Location = new System.Drawing.Point(347, 153);
            this.lblModule3.Name = "lblModule3";
            this.lblModule3.Size = new System.Drawing.Size(59, 16);
            this.lblModule3.TabIndex = 14;
            this.lblModule3.Text = "Module3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Modules:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "UserType";
            // 
            // lblModule2
            // 
            this.lblModule2.AutoSize = true;
            this.lblModule2.Location = new System.Drawing.Point(253, 153);
            this.lblModule2.Name = "lblModule2";
            this.lblModule2.Size = new System.Drawing.Size(59, 16);
            this.lblModule2.TabIndex = 13;
            this.lblModule2.Text = "Module2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Student number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Email:";
            // 
            // lblModule1
            // 
            this.lblModule1.AutoSize = true;
            this.lblModule1.Location = new System.Drawing.Point(160, 153);
            this.lblModule1.Name = "lblModule1";
            this.lblModule1.Size = new System.Drawing.Size(59, 16);
            this.lblModule1.TabIndex = 12;
            this.lblModule1.Text = "Module1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Surname:";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(160, 126);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(68, 16);
            this.lblUserType.TabIndex = 11;
            this.lblUserType.Text = "UserType";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Name:";
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Location = new System.Drawing.Point(160, 98);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(103, 16);
            this.lblStudentNo.TabIndex = 10;
            this.lblStudentNo.Text = "Student number:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(160, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(160, 70);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(160, 43);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(64, 16);
            this.lblSurname.TabIndex = 8;
            this.lblSurname.Text = "Surname:";
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtSearchByTutor;
        private System.Windows.Forms.Label lblSearchByTutor;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewAvailableTutors;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUpdateEmail;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbUpdateModule3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbUpdateModule2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbUpdateModule1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblModule3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblModule2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblModule1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnUpdateModule3;
        private System.Windows.Forms.Button btnUpdateEmail;
        private System.Windows.Forms.Button btnUpdateModule1;
        private System.Windows.Forms.Button btnUpdateModule2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}