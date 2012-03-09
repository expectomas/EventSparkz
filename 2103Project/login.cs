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
    public partial class Login : Form
    {
        /*Variables */
        private bool userNameValid = false;

        /*User Class*/
        private User currentUser;
       
        public static void ThreadProc()
        {
            Application.Run(new MainPage());
        }

        public Login(User enteringUser)
        {
            InitializeComponent();

            currentUser = enteringUser;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //Test

            currentUser.logout();


            this.Close();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            // Open Registration Page
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            User newUser = new User();

            if (userNameTextBox.Text == "" && passwordTextbox.Text == "")
            {
                MessageBox.Show("Please Enter A Username and Password");
            }

            else
            {

                userNameValid = newUser.login(userNameTextBox.Text, passwordTextbox.Text);

                if (userNameValid)
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
                
        }

        private void SplashScreen_Click(object sender, EventArgs e)
        {

        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (userNameTextBox.TextLength > 7)
            {
                if (!(userNameTextBox.Text.ToString().Contains("nusstu\\") || userNameTextBox.Text.ToString().Contains("NUSSTU\\")
                    || userNameTextBox.Text.ToString().Contains("nusstf\\") || userNameTextBox.Text.ToString().Contains("NUSSTF\\")))
                {
                    errorProviderUserName.SetError(userNameLabel, "Indicate domain, eg. NUSSTU\\A1234567W");
                    userNameValid = false;
                }
                else
                    errorProviderUserName.Clear();
            }
            else
            {
                userNameValid = false;
                errorProviderUserName.Clear();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextbox.TextLength < 8)
            {
                errorProviderPassword.SetError(this, "Please Enter a Password of length more than 8 characters");
            }
            else
            {
                errorProviderPassword.Clear();
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            ActiveUser test = new ActiveUser();
            List<EventEntity> es = new List<EventEntity>();
            es = test.viewEventListing();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
