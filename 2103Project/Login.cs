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
    public partial class loginForm : Form
    {
        //Current User of this Form
        private User currentUser;

        //Variables
        bool validUser = false;

        public void ThreadProc()
        {
            Application.Run(new mainPage(currentUser));
        }

        public loginForm(User incomingUser)
        {
            InitializeComponent();

            currentUser = incomingUser;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            // Open Registration Page
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            validUser = currentUser.login(userNameTextBox.Text, passwordTextbox.Text,ref currentUser);

            if (validUser)
            {
                this.Close();

                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                t.Start();
            }
            else
            {
                MessageBox.Show("The Username and Password is Incorrect");
            }
                
        }

        private void SplashScreen_Click(object sender, EventArgs e)
        {

        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextbox.TextLength < 6)
            {
                errorProviderPassword.SetError(this, "Please Enter a Password of length more than 6 characters");
            }
            else
            {
                errorProviderPassword.Clear();
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
