using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            loginForm login = new loginForm();
            login.Show();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            signupForm signup = new signupForm();
            signup.Show();
        }
    }
}
