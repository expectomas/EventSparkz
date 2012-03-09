using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _2103Project.Entities;

namespace _2103Project
{
    public partial class loginSelectForm : Form
    {
        public loginSelectForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm(new User());
            login.Show();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            signupForm signup = new signupForm();
            signup.Show();
        }
    }
}
