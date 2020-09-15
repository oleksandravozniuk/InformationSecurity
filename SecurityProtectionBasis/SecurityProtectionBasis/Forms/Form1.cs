using SecurityProtectionBasis.Forms;
using SecurityProtectionBasis.Interfaces;
using SecurityProtectionBasis.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityProtectionBasis
{
    public partial class Form1 : Form
    {

        private readonly IUser userService;
        public Form1()
        {
            InitializeComponent();
            userService = (IUser)Program.ServiceProvider.GetService(typeof(IUser));
            userService.SetInitialState();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            string username = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if(userService.Login(username,password))
            {
                User user = userService.GetUserByUsername(username);
                if(user.UserName=="ADMIN")
                {
                    AdminPage adminPage = new AdminPage(user);
                    adminPage.Show();
                }
                else
                {
                    UserPage userPage = new UserPage(user);
                    userPage.Show();
                }
   
                this.Hide();
            }
        }

    }
}
