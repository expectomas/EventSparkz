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
    public partial class mainPage : Form
    {
        private User currentUser;

        private void Exit_Dialog()
        {
            if (MessageBox.Show("Are you sure?", "Exit Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                currentUser.logout();
                this.Close();
            }
        }

        public mainPage( User incomingUser)
        {
            InitializeComponent();

            currentUser = incomingUser;

            //Load the Exit Event
        }

        private void registerEvent_Click(object sender, EventArgs e)
        {
            createEventForm createEvent = new createEventForm(currentUser);
            createEvent.Show();
        }

        private void mainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Exit_Dialog();

            this.Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Exit_Dialog();

            this.Close();
        }
    }
}
