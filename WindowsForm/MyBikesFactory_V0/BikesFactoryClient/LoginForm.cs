using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using BikesFactoryData;

namespace BikesFactoryClient
{
    public partial class LoginForm : Form
    {
        List<Accounts> myListOfUsers = new List<Accounts>();
        static string userFilePath = @"..\..\data\UsersDataBase.xml";

        public LoginForm()
        {
            InitializeComponent();
            if (!File.Exists(userFilePath))
            {
                FileHandler.writeUsersFile();
            }

            myListOfUsers = FileHandler.readUsersFile();
        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
            bool found = false;

            for (int i = 0; i < myListOfUsers.Count; i++)
            {
                if ((tbUser.Text == myListOfUsers[i].User) && (tbPassword.Text == myListOfUsers[i].Password))
                {
                    MainForm MainForm = new MainForm();

                    found = true;

                    this.Hide();
                    MainForm.ShowDialog();
                    this.Close();
                }
                else { found = false; }
            }
            if (!found)
            {
                MessageBox.Show("The user and/or password is incorrect");

                foreach (Control aControl in Controls)
                {
                    if (aControl is TextBox)
                    {
                        aControl.Text = "";
                        this.tbUser.Focus();
                    }
                }
            }

        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtAccount_Click(object sender, EventArgs e)
        {
            if ((this.tbUser.Text == "admin") && (this.tbPassword.Text == "123"))
            {
                UserForm UserForm = new UserForm();

                this.Hide();
                UserForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("You need admin privileges for that");

                foreach (Control aControl in Controls)
                {
                    if (aControl is TextBox)
                    {
                        aControl.Text = "";
                        this.tbUser.Focus();
                    }
                }
            }

        }
    }
}
