using BikesFactoryData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikesFactoryClient
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void BtNew_Click(object sender, EventArgs e)
        {
            Accounts aUser = new Accounts(this.tbUser.Text, this.tbPassword.Text);
            FileHandler.writeUsersFile(aUser);

            LoginForm LoginForm = new LoginForm();

            MessageBox.Show("User Created");

            foreach (Control aControl in Controls)
            {
                if (aControl is TextBox)
                {
                    aControl.Text = "";
                }
            }
            this.tbUser.Focus();
        }

        private void TbRefresh_Click(object sender, EventArgs e)
        {
            foreach(Control aControl in Controls)
            {
                if(aControl is TextBox)
                {
                    aControl.Text = "";
                }
            }
            this.tbUser.Focus();
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
