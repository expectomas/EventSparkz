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

        public mainPage(User incomingUser)
        {
            InitializeComponent();

            currentUser = incomingUser;
        }
        
        public static void ThreadProc()
        {
            Application.Run(new loginForm(null));
        }

        private void Exit_Dialog()
        {
            if (MessageBox.Show("Do you want to logout?", "Exit Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                currentUser.logout();
                LogoutPressed = true;
                this.Close();
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                t.Start();
            }
        }

        public void initEventList()
        {
            this.listView1.Columns.Insert(0, "No.",10 , HorizontalAlignment.Left);
            this.listView1.Columns.Insert(1, "Event", 20 , HorizontalAlignment.Left);
            this.listView1.Columns.Insert(2, "Description", 40, HorizontalAlignment.Center);
        }

        //Event Handler

        private void registerEvent_Click(object sender, EventArgs e)
        {
            createEventForm createEvent = new createEventForm(currentUser);
            createEvent.Show();
        }

        private void mainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!LogoutPressed)
                Exit_Dialog();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Exit_Dialog();
        }

        private void searchEventTextBox_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void searchEventButton_Clicked(object sender, MouseEventArgs e)
        {
            ActiveUser userRole = new ActiveUser(currentUser);
            List<EventEntity> outputEventListing = userRole.viewEventListingByEventName(searchEventTextBox.Text);

            initEventList();
        }

        private void getEventInfoButton_Click(object sender, EventArgs e)
        {
            eventInfoForm eventInfoPage = new eventInfoForm(currentUser);
            eventInfoPage.Show();
        }
    }
}