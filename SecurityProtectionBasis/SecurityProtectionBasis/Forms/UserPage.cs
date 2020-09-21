using SecurityProtectionBasis.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SecurityProtectionBasis.Forms
{
    public partial class UserPage : Form
    {
        private User user;
        private readonly IUser userService;
        public UserPage(User user)
        {
            InitializeComponent();
            this.user = user;
            userService = (IUser)Program.ServiceProvider.GetService(typeof(IUser));
            labelHelloUser.Text = "Hello, " + this.user.UserName + "!";
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            if(user.Password==textBoxOldPassword.Text)
            {
                if(textBoxNewPassword.Text == textBoxRepeatOldPassword.Text)
                {
                    if ((user.PasswordLimitationIsSet && userService.PasswordLimitation(textBoxNewPassword.Text)) || !user.PasswordLimitationIsSet)
                    {
                        user.Password = textBoxNewPassword.Text;
                        userService.UpdateUser(user);
                        textBoxNewPassword.Clear();
                        textBoxOldPassword.Clear();
                        textBoxRepeatOldPassword.Clear();
                    }
                    else
                    {
                        Message message = new Message("Password must contain at least one cyrillic and latin symbol");
                        message.Show();
                    }
                }
                else
                {
                    Message message = new Message("Password and Repeat Password are not the same!");
                }
               
            }
            else
            {
                Message message = new Message("Wrong old password!");
                message.Show();
            }
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

     
    }
}
