namespace TutoringApp
{
    partial class Login
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
            this.User_ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser_ID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.checkBoxIsTutor = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // User_ID
            // 
            this.User_ID.AutoSize = true;
            this.User_ID.Location = new System.Drawing.Point(272, 135);
            this.User_ID.Name = "User_ID";
            this.User_ID.Size = new System.Drawing.Size(73, 16);
            this.User_ID.TabIndex = 0;
            this.User_ID.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(328, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login";
            // 
            // txtUser_ID
            // 
            this.txtUser_ID.Location = new System.Drawing.Point(368, 129);
            this.txtUser_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser_ID.Name = "txtUser_ID";
            this.txtUser_ID.Size = new System.Drawing.Size(100, 22);
            this.txtUser_ID.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(368, 167);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(380, 265);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // checkBoxIsTutor
            // 
            this.checkBoxIsTutor.AutoSize = true;
            this.checkBoxIsTutor.Location = new System.Drawing.Point(351, 228);
            this.checkBoxIsTutor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxIsTutor.Name = "checkBoxIsTutor";
            this.checkBoxIsTutor.Size = new System.Drawing.Size(120, 20);
            this.checkBoxIsTutor.TabIndex = 6;
            this.checkBoxIsTutor.Text = "are you a tutor?";
            this.checkBoxIsTutor.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(124)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxIsTutor);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.User_ID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label User_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser_ID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox checkBoxIsTutor;
    }
}