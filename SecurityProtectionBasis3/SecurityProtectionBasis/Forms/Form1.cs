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
using Message = SecurityProtectionBasis.Forms.Message;

namespace SecurityProtectionBasis
{
    public partial class Form1 : Form
    {

        private readonly IUser userService;
        private readonly IAdmin adminService;
        private readonly ICryptService cryptService;

        private int wrongPasswordCounter;
        public Form1(bool flag)
        {
            InitializeComponent();
            userService = (IUser)Program.ServiceProvider.GetService(typeof(IUser));
            adminService = (IAdmin)Program.ServiceProvider.GetService(typeof(IAdmin));
            cryptService = (ICryptService)Program.ServiceProvider.GetService(typeof(ICryptService));
            if (flag == false)
                userService.SetInitialState();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            string username = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if(adminService.UsernameExists(username))
            {
                if (userService.Login(username, password))
                {
                    wrongPasswordCounter = 0;
                    User user = userService.GetUserByUsername(username);
                    if(user.Blocked)
                    {
                        Message message = new Message("Your account is blocked");
                        message.Show();
                    }
                    else
                    {
                        if (user.UserName == "ADMIN")
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
                else
                {
                    wrongPasswordCounter++;
                    if(wrongPasswordCounter>=3)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        WrongPasswordWindow wrongPasswordWindow = new WrongPasswordWindow();
                        wrongPasswordWindow.Show();
                    }
                }
            }
            else
            {
                UserDoesNotExistWindow userDoesNotExistWindow = new UserDoesNotExistWindow();
                userDoesNotExistWindow.Show();
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cryptService.Encrypt();
            userService.DeleteTemporaryDB();
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AboutProgram aboutProgram = new AboutProgram();
            aboutProgram.Show();
        }
    }
}
