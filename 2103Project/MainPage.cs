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

        private bool LogoutPressed = false;

        private void Exit_Dialog()
        {
            if (MessageBox.Show("Do you want to logout?", "Exit Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                currentUser.logout();
                LogoutPressed=true;
                Application.Exit();
            }
        }

        public mainPage( User incomingUser)
        {
            InitializeComponent();
        }

        //Event Handler

        private void registerEvent_Click(object sender, EventArgs e)
        {
            createEventForm createEvent = new createEventForm(currentUser);
            createEvent.Show();
        }

        private void mainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!LogoutPressed)
            {
                Exit_Dialog();
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Exit_Dialog();
        }

        private void searchEventTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            ActiveUser userRole = (Participant)(Object) currentUser;

            List<EventEntity> outputEventListing = userRole.viewEventListingByEventName(searchEventTextBox.Text);


        }
    }
}