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
    public partial class UserProperties : Form
    {
        private readonly IUser userService;
        private User user;
        public UserProperties(User user)
        {
           
            this.user = user;
            userService = (IUser)Program.ServiceProvider.GetService(typeof(IUser));
            InitializeComponent();
            labelUsername.Text = user.UserName;
            labelPassword.Text = user.Password;
            checkBoxBlocked.Checked = user.Blocked;
            checkBoxBlocked.Checked = user.PasswordLimitationIsSet;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            user.Blocked = checkBoxBlocked.Checked;
            user.PasswordLimitationIsSet = checkBoxLimitation.Checked;

            userService.UpdateUser(user);
            UserManage userManage = new UserManage();
            userManage.Show();
            this.Hide();
        }
    }
}
