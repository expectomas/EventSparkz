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

        int closeState = 0;

        private void Exit_Dialog(int state)
        {
            if (MessageBox.Show("Do you want to logout?", "Exit Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                currentUser.logout();
                if (state == 1)
                {
                    this.Hide();
                    loginForm login = new loginForm(null);
                    closeState = 1;
                    this.Hide();
                    login.Show();
                }
                else
                {
                    closeState = 1;
                    this.Close();
                }
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
            if(closeState == 0)
                Exit_Dialog(0);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Exit_Dialog(1);
        }

        private void searchEventTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            ActiveUser userRole = (Participant)(Object) currentUser;

            List<EventEntity> outputEventListing = userRole.viewEventListingByEventName(searchEventTextBox.Text);


        }
    }
}