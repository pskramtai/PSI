using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Comparison_Engine.User_Classes;

namespace Comparison_Engine.Child_Forms
{
    public partial class ProfileForm : Form
    {
        private UserLoginLogic userLoginLogic = UserLoginLogic.Instance;

        public ProfileForm()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userLoggedIn(Boolean loggedIn)
        {
            labelLogIn.Visible = !loggedIn;
            buttonLogIn.Visible = !loggedIn;
            buttonSignUp.Visible = !loggedIn;
            textBoxUsername.Visible = !loggedIn;
            textBoxPassword.Visible = !loggedIn;
            buttonLogOut.Visible = loggedIn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userLoginLogic.ValidateUserLogin(textBoxUsername.Text, textBoxPassword.Text))
            {
                userLoggedIn(true);
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            userLoggedIn(false);
        }
    }
}
