using OpenTK.Input;
using SecurityProtectionBasis.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace SecurityProtectionBasis.Forms
{
    public partial class UserManage : Form
    {
        private readonly IUser userService;
        public UserManage()
        {
            userService = (IUser)Program.ServiceProvider.GetService(typeof(IUser));
            InitializeComponent();
            InitializePanel();
        }

        private void InitializePanel()
        {
            listBox1.MouseDoubleClick += new MouseEventHandler(listBox1_DoubleClick);

            listBox1.Items.AddRange(userService.GetAllUsernames().ToArray());
        }
        private void listBox1_DoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                User user = userService.GetUserByUsername(listBox1.SelectedItem.ToString());
                UserProperties userProperties = new UserProperties(user);
                userProperties.Show();
                this.Hide();
            }
        }

    }
}
