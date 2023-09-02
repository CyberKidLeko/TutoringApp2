namespace TutoringApp
{
    partial class Register
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.radioButtonTutor = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxModule = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxModuleDetails = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.pbButton = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBoxModuleDetails.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "UserID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "What Are you registering to be?";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(229, 31);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 22);
            this.txtName.TabIndex = 10;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(229, 59);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(159, 22);
            this.txtSurname.TabIndex = 11;
            this.txtSurname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(229, 114);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(159, 22);
            this.txtUserID.TabIndex = 13;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(229, 87);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(159, 22);
            this.txtPhone.TabIndex = 12;
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Location = new System.Drawing.Point(400, 244);
            this.radioButtonStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(73, 20);
            this.radioButtonStudent.TabIndex = 14;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.Text = "Student";
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            // 
            // radioButtonTutor
            // 
            this.radioButtonTutor.AutoSize = true;
            this.radioButtonTutor.Location = new System.Drawing.Point(263, 244);
            this.radioButtonTutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonTutor.Name = "radioButtonTutor";
            this.radioButtonTutor.Size = new System.Drawing.Size(59, 20);
            this.radioButtonTutor.TabIndex = 15;
            this.radioButtonTutor.TabStop = true;
            this.radioButtonTutor.Text = "Tutor";
            this.radioButtonTutor.UseVisualStyleBackColor = true;
            this.radioButtonTutor.CheckedChanged += new System.EventHandler(this.radioButtonTutor_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Module 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Confirm password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Password:";
            // 
            // comboBoxModule
            // 
            this.comboBoxModule.FormattingEnabled = true;
            this.comboBoxModule.Location = new System.Drawing.Point(229, 46);
            this.comboBoxModule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxModule.Name = "comboBoxModule";
            this.comboBoxModule.Size = new System.Drawing.Size(159, 24);
            this.comboBoxModule.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtUserID);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(776, 169);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // groupBoxModuleDetails
            // 
            this.groupBoxModuleDetails.Controls.Add(this.comboBoxModule);
            this.groupBoxModuleDetails.Controls.Add(this.label8);
            this.groupBoxModuleDetails.Location = new System.Drawing.Point(12, 279);
            this.groupBoxModuleDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxModuleDetails.Name = "groupBoxModuleDetails";
            this.groupBoxModuleDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxModuleDetails.Size = new System.Drawing.Size(776, 96);
            this.groupBoxModuleDetails.TabIndex = 25;
            this.groupBoxModuleDetails.TabStop = false;
            this.groupBoxModuleDetails.Text = "Module Details";
            this.groupBoxModuleDetails.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPassword);
            this.groupBox3.Controls.Add(this.txtConfirmPassword);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(9, 422);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(776, 106);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(229, 25);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(159, 22);
            this.txtPassword.TabIndex = 14;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(229, 52);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(159, 22);
            this.txtConfirmPassword.TabIndex = 15;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(227, 590);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(155, 46);
            this.buttonRegister.TabIndex = 18;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pbButton
            // 
            this.pbButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbButton.Image = ((System.Drawing.Image)(resources.GetObject("pbButton.Image")));
            this.pbButton.Location = new System.Drawing.Point(9, 0);
            this.pbButton.Name = "pbButton";
            this.pbButton.Size = new System.Drawing.Size(55, 39);
            this.pbButton.TabIndex = 27;
            this.pbButton.TabStop = false;
            this.pbButton.Click += new System.EventHandler(this.pbButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(124)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(800, 670);
            this.Controls.Add(this.pbButton);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxModuleDetails);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButtonTutor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radioButtonStudent);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxModuleDetails.ResumeLayout(false);
            this.groupBoxModuleDetails.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.RadioButton radioButtonStudent;
        private System.Windows.Forms.RadioButton radioButtonTutor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxModule;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxModuleDetails;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.PictureBox pbButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}