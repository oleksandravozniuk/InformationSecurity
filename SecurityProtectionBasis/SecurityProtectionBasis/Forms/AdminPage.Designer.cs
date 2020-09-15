namespace SecurityProtectionBasis.Forms
{
    partial class AdminPage
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
            this.textBoxAdminOldPassword = new System.Windows.Forms.TextBox();
            this.textBoxAdminRepeatPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAdminNewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.labelHelloAdmin = new System.Windows.Forms.Label();
            this.buttonManageUsers = new System.Windows.Forms.Button();
            this.textBoxCreateUser = new System.Windows.Forms.TextBox();
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAdminOldPassword
            // 
            this.textBoxAdminOldPassword.Location = new System.Drawing.Point(28, 190);
            this.textBoxAdminOldPassword.Name = "textBoxAdminOldPassword";
            this.textBoxAdminOldPassword.Size = new System.Drawing.Size(212, 27);
            this.textBoxAdminOldPassword.TabIndex = 2;
            // 
            // textBoxAdminRepeatPassword
            // 
            this.textBoxAdminRepeatPassword.Location = new System.Drawing.Point(28, 343);
            this.textBoxAdminRepeatPassword.Name = "textBoxAdminRepeatPassword";
            this.textBoxAdminRepeatPassword.Size = new System.Drawing.Size(212, 27);
            this.textBoxAdminRepeatPassword.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Repeat new password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "New password";
            // 
            // textBoxAdminNewPassword
            // 
            this.textBoxAdminNewPassword.Location = new System.Drawing.Point(28, 265);
            this.textBoxAdminNewPassword.Name = "textBoxAdminNewPassword";
            this.textBoxAdminNewPassword.Size = new System.Drawing.Size(212, 27);
            this.textBoxAdminNewPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Old password";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Sign Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonSignOut_Click);
            // 
            // labelHelloAdmin
            // 
            this.labelHelloAdmin.AutoSize = true;
            this.labelHelloAdmin.Location = new System.Drawing.Point(12, 13);
            this.labelHelloAdmin.Name = "labelHelloAdmin";
            this.labelHelloAdmin.Size = new System.Drawing.Size(105, 20);
            this.labelHelloAdmin.TabIndex = 0;
            this.labelHelloAdmin.Text = "Hello, ADMIN!";
            // 
            // buttonManageUsers
            // 
            this.buttonManageUsers.Location = new System.Drawing.Point(12, 104);
            this.buttonManageUsers.Name = "buttonManageUsers";
            this.buttonManageUsers.Size = new System.Drawing.Size(133, 29);
            this.buttonManageUsers.TabIndex = 10;
            this.buttonManageUsers.Text = "Menage Users";
            this.buttonManageUsers.UseVisualStyleBackColor = true;
            this.buttonManageUsers.Click += new System.EventHandler(this.buttonManageUsers_Click);
            // 
            // textBoxCreateUser
            // 
            this.textBoxCreateUser.Location = new System.Drawing.Point(368, 190);
            this.textBoxCreateUser.Name = "textBoxCreateUser";
            this.textBoxCreateUser.Size = new System.Drawing.Size(211, 27);
            this.textBoxCreateUser.TabIndex = 11;
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.Location = new System.Drawing.Point(423, 233);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(94, 29);
            this.buttonCreateUser.TabIndex = 12;
            this.buttonCreateUser.Text = "Create User";
            this.buttonCreateUser.UseVisualStyleBackColor = true;
            this.buttonCreateUser.Click += new System.EventHandler(this.buttonCreateUser_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "New username";
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCreateUser);
            this.Controls.Add(this.textBoxCreateUser);
            this.Controls.Add(this.buttonManageUsers);
            this.Controls.Add(this.labelHelloAdmin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAdminNewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAdminRepeatPassword);
            this.Controls.Add(this.textBoxAdminOldPassword);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAdminOldPassword;
        private System.Windows.Forms.TextBox textBoxAdminRepeatPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAdminNewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelHelloAdmin;
        private System.Windows.Forms.Button buttonManageUsers;
        private System.Windows.Forms.TextBox textBoxCreateUser;
        private System.Windows.Forms.Button buttonCreateUser;
        private System.Windows.Forms.Label label4;
    }
}