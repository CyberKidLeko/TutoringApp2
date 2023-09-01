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
            this.btnBook = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewAvailableTutors = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblModules = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.Dash.Location = new System.Drawing.Point(9, 2);
            this.Dash.Margin = new System.Windows.Forms.Padding(2);
            this.Dash.Name = "Dash";
            this.Dash.SelectedIndex = 0;
            this.Dash.Size = new System.Drawing.Size(582, 410);
            this.Dash.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSearchByTutor);
            this.tabPage1.Controls.Add(this.lblSearchByTutor);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbFilterByModule);
            this.tabPage1.Controls.Add(this.lblFilterByModule);
            this.tabPage1.Controls.Add(this.dataGridViewAppointments);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(574, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Appointments";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtSearchByTutor
            // 
            this.txtSearchByTutor.Location = new System.Drawing.Point(164, 240);
            this.txtSearchByTutor.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchByTutor.Name = "txtSearchByTutor";
            this.txtSearchByTutor.Size = new System.Drawing.Size(114, 20);
            this.txtSearchByTutor.TabIndex = 7;
            // 
            // lblSearchByTutor
            // 
            this.lblSearchByTutor.AutoSize = true;
            this.lblSearchByTutor.Location = new System.Drawing.Point(4, 243);
            this.lblSearchByTutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchByTutor.Name = "lblSearchByTutor";
            this.lblSearchByTutor.Size = new System.Drawing.Size(111, 13);
            this.lblSearchByTutor.TabIndex = 6;
            this.lblSearchByTutor.Text = "Search by tutor name:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(164, 263);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 19);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cancel selected appointment:";
            // 
            // cmbFilterByModule
            // 
            this.cmbFilterByModule.FormattingEnabled = true;
            this.cmbFilterByModule.Location = new System.Drawing.Point(164, 216);
            this.cmbFilterByModule.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFilterByModule.Name = "cmbFilterByModule";
            this.cmbFilterByModule.Size = new System.Drawing.Size(114, 21);
            this.cmbFilterByModule.TabIndex = 3;
            // 
            // lblFilterByModule
            // 
            this.lblFilterByModule.AutoSize = true;
            this.lblFilterByModule.Location = new System.Drawing.Point(7, 219);
            this.lblFilterByModule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilterByModule.Name = "lblFilterByModule";
            this.lblFilterByModule.Size = new System.Drawing.Size(83, 13);
            this.lblFilterByModule.TabIndex = 2;
            this.lblFilterByModule.Text = "Filter by module:";
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(7, 28);
            this.dataGridViewAppointments.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.RowHeadersWidth = 51;
            this.dataGridViewAppointments.RowTemplate.Height = 24;
            this.dataGridViewAppointments.Size = new System.Drawing.Size(565, 185);
            this.dataGridViewAppointments.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current appointments";
            // 
            // tabPageBookAppointment
            // 
            this.tabPageBookAppointment.Controls.Add(this.dateTimePicker1);
            this.tabPageBookAppointment.Controls.Add(this.txtSearch);
            this.tabPageBookAppointment.Controls.Add(this.btnBook);
            this.tabPageBookAppointment.Controls.Add(this.label6);
            this.tabPageBookAppointment.Controls.Add(this.dataGridViewAvailableTutors);
            this.tabPageBookAppointment.Controls.Add(this.label5);
            this.tabPageBookAppointment.Location = new System.Drawing.Point(4, 22);
            this.tabPageBookAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageBookAppointment.Name = "tabPageBookAppointment";
            this.tabPageBookAppointment.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageBookAppointment.Size = new System.Drawing.Size(574, 384);
            this.tabPageBookAppointment.TabIndex = 1;
            this.tabPageBookAppointment.Text = "Book Appointment";
            this.tabPageBookAppointment.UseVisualStyleBackColor = true;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(181, 325);
            this.btnBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(162, 26);
            this.btnBook.TabIndex = 5;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Available Tutors";
            // 
            // dataGridViewAvailableTutors
            // 
            this.dataGridViewAvailableTutors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableTutors.Location = new System.Drawing.Point(4, 59);
            this.dataGridViewAvailableTutors.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAvailableTutors.Name = "dataGridViewAvailableTutors";
            this.dataGridViewAvailableTutors.RowHeadersWidth = 51;
            this.dataGridViewAvailableTutors.RowTemplate.Height = 24;
            this.dataGridViewAvailableTutors.Size = new System.Drawing.Size(566, 181);
            this.dataGridViewAvailableTutors.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Filter by module:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(574, 384);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Profile";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Location = new System.Drawing.Point(8, 299);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(564, 81);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Change Password";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(251, 56);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 19);
            this.button5.TabIndex = 30;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(251, 13);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 19);
            this.button4.TabIndex = 29;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(422, 38);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 19);
            this.button3.TabIndex = 28;
            this.button3.Text = "LOGOUT";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 32);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 19);
            this.button2.TabIndex = 27;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(4, 61);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(113, 13);
            this.label23.TabIndex = 26;
            this.label23.Text = "Confirm new password";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(120, 58);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(115, 20);
            this.textBox5.TabIndex = 26;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(4, 38);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 13);
            this.label22.TabIndex = 25;
            this.label22.Text = "New password";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(120, 36);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(115, 20);
            this.textBox4.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, 13);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(115, 20);
            this.textBox3.TabIndex = 23;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 15);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Current password";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.comboBox5);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Location = new System.Drawing.Point(8, 180);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(564, 114);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Details";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(251, 62);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(94, 19);
            this.button9.TabIndex = 34;
            this.button9.Text = "Update";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(251, 86);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 19);
            this.button6.TabIndex = 33;
            this.button6.Text = "Update";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 89);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 20);
            this.textBox2.TabIndex = 22;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(251, 12);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 19);
            this.button7.TabIndex = 32;
            this.button7.Text = "Update";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(251, 39);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 19);
            this.button8.TabIndex = 31;
            this.button8.Text = "Update";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 89);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 13);
            this.label20.TabIndex = 21;
            this.label20.Text = "Update email:";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(120, 64);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(115, 21);
            this.comboBox5.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(4, 64);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "Change Module 3:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(120, 39);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(115, 21);
            this.comboBox4.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 39);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Change Module 2:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(120, 15);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(115, 21);
            this.comboBox3.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 15);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Change Module 1:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblModules);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblUserType);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblStudentNo);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblSurname);
            this.groupBox1.Location = new System.Drawing.Point(8, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(564, 153);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal details";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(260, 124);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Module3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 124);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Modules:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 102);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "UserType";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(190, 124);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Module2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 80);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Student number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 57);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Email:";
            // 
            // lblModules
            // 
            this.lblModules.AutoSize = true;
            this.lblModules.Location = new System.Drawing.Point(120, 124);
            this.lblModules.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModules.Name = "lblModules";
            this.lblModules.Size = new System.Drawing.Size(48, 13);
            this.lblModules.TabIndex = 12;
            this.lblModules.Text = "Module1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 35);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Surname:";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(120, 102);
            this.lblUserType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(53, 13);
            this.lblUserType.TabIndex = 11;
            this.lblUserType.Text = "UserType";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Name:";
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Location = new System.Drawing.Point(120, 80);
            this.lblStudentNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(85, 13);
            this.lblStudentNo.TabIndex = 10;
            this.lblStudentNo.Text = "Student number:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(120, 15);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(120, 57);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(120, 35);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 8;
            this.lblSurname.Text = "Surname:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Profile";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(107, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 259);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 419);
            this.Controls.Add(this.Dash);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblModules;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}