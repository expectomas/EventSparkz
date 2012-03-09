using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using _2103Project.Entities;

namespace _2103Project
{
    public partial class loginSelectForm : Form
    {
        //Threads
        public void LoginFormThreadProc()
        {
            Application.Run(new loginForm(new User()));
        }

        public void SignUpFormThreadProc()
        {
            Application.Run(new signupForm());
        }

        //Constructor
        public loginSelectForm()
        {
            InitializeComponent();
        }

        //Event Handlers
        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread t = new Thread(new ThreadStart(LoginFormThreadProc));

            t.Start();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            this.Close();

            Thread t = new Thread(new ThreadStart(SignUpFormThreadProc));

            t.Start();
        }
    }
}
