namespace SecurityProtectionBasis.Forms
{
    partial class UserPage
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
            this.labelHelloUser = new System.Windows.Forms.Label();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRepeatOldPassword = new System.Windows.Forms.TextBox();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHelloUser
            // 
            this.labelHelloUser.AutoSize = true;
            this.labelHelloUser.Location = new System.Drawing.Point(12, 9);
            this.labelHelloUser.Name = "labelHelloUser";
            this.labelHelloUser.Size = new System.Drawing.Size(0, 20);
            this.labelHelloUser.TabIndex = 0;
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Location = new System.Drawing.Point(28, 186);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.Size = new System.Drawing.Size(212, 27);
            this.textBoxOldPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Old password";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(28, 261);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(212, 27);
            this.textBoxNewPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "New password";
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Location = new System.Drawing.Point(59, 391);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(141, 29);
            this.buttonChangePassword.TabIndex = 6;
            this.buttonChangePassword.Text = "Change Password";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Repeat new password";
            // 
            // textBoxRepeatOldPassword
            // 
            this.textBoxRepeatOldPassword.Location = new System.Drawing.Point(28, 339);
            this.textBoxRepeatOldPassword.Name = "textBoxRepeatOldPassword";
            this.textBoxRepeatOldPassword.Size = new System.Drawing.Size(212, 27);
            this.textBoxRepeatOldPassword.TabIndex = 8;
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.Location = new System.Drawing.Point(12, 54);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(94, 29);
            this.buttonSignOut.TabIndex = 9;
            this.buttonSignOut.Text = "Sign Out";
            this.buttonSignOut.UseVisualStyleBackColor = true;
            this.buttonSignOut.Click += new System.EventHandler(this.buttonSignOut_Click);
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSignOut);
            this.Controls.Add(this.textBoxRepeatOldPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOldPassword);
            this.Controls.Add(this.labelHelloUser);
            this.Name = "UserPage";
            this.Text = "UserPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHelloUser;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRepeatOldPassword;
        private System.Windows.Forms.Button buttonSignOut;
    }
}