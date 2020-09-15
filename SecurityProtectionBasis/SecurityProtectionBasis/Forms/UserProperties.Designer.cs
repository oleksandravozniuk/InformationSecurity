namespace SecurityProtectionBasis.Forms
{
    partial class UserProperties
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.checkBoxBlocked = new System.Windows.Forms.CheckBox();
            this.checkBoxLimitation = new System.Windows.Forms.CheckBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(17, 18);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(38, 15);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "label1";
            // 
            // checkBoxBlocked
            // 
            this.checkBoxBlocked.AutoSize = true;
            this.checkBoxBlocked.Location = new System.Drawing.Point(17, 81);
            this.checkBoxBlocked.Name = "checkBoxBlocked";
            this.checkBoxBlocked.Size = new System.Drawing.Size(68, 19);
            this.checkBoxBlocked.TabIndex = 1;
            this.checkBoxBlocked.Text = "Blocked";
            this.checkBoxBlocked.UseVisualStyleBackColor = true;
            // 
            // checkBoxLimitation
            // 
            this.checkBoxLimitation.AutoSize = true;
            this.checkBoxLimitation.Location = new System.Drawing.Point(17, 116);
            this.checkBoxLimitation.Name = "checkBoxLimitation";
            this.checkBoxLimitation.Size = new System.Drawing.Size(151, 19);
            this.checkBoxLimitation.TabIndex = 2;
            this.checkBoxLimitation.Text = "Linitations on password";
            this.checkBoxLimitation.UseVisualStyleBackColor = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(17, 47);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(38, 15);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "label1";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(66, 158);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // UserProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 193);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.checkBoxLimitation);
            this.Controls.Add(this.checkBoxBlocked);
            this.Controls.Add(this.labelUsername);
            this.Name = "UserProperties";
            this.Text = "UserProperties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.CheckBox checkBoxBlocked;
        private System.Windows.Forms.CheckBox checkBoxLimitation;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonSubmit;
    }
}