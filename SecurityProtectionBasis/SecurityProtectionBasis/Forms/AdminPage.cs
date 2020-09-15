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
    public partial class AdminPage : Form
    {
        private User admin;
        private readonly IUser userService;
        private readonly IAdmin adminService;
        public AdminPage(User user)
        {
            InitializeComponent();
            this.admin = user;
            userService = (IUser)Program.ServiceProvider.GetService(typeof(IUser));
            adminService = (IAdmin)Program.ServiceProvider.GetService(typeof(IAdmin));
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            if (admin.Password == textBoxAdminOldPassword.Text && textBoxAdminNewPassword.Text == textBoxAdminRepeatPassword.Text)
            {
                admin.Password = textBoxAdminNewPassword.Text;
                userService.UpdateUser(admin);
                textBoxAdminNewPassword.Clear();
                textBoxAdminOldPassword.Clear();
                textBoxAdminRepeatPassword.Clear();
            }
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void buttonManageUsers_Click(object sender, EventArgs e)
        {
            UserManage userManage = new UserManage();
            userManage.Show();
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            User newUser = new User(textBoxCreateUser.Text, string.Empty, false, false);
            if(!adminService.UsernameExists(newUser.UserName))
            {
                adminService.RegisterUser(newUser);
                textBoxCreateUser.Clear();
            }
        }
    }
}
