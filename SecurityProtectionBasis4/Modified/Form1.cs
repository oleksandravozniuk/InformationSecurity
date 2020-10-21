using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityProtectionBasis4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            CheckLogin(login, password);
        }

        public void CheckLogin(string login, string password)
        {
            if(DbManager.FindUser(login,password))
            {
                HomePage homePage = new HomePage(login);
                homePage.Show();
            }
            else
            {
                Help.ShowPopup(this, "Wrong login or password", this.Location);
            }
        }
    }
}
