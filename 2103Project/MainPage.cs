using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _2103Project.Entities;
using _2103Project.Action;

namespace _2103Project
{
    public partial class mainPage : Form
    {
        private User currentUser;
        private bool LogoutPressed = false;
        private int currentEventID;
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
            this.listView1.Hide();
            this.listView1.Columns.Insert(0, "No.",50 , HorizontalAlignment.Left);
            this.listView1.Columns.Insert(1, "Event", 250 , HorizontalAlignment.Left);
            this.listView1.Columns.Insert(2, "Date", 80, HorizontalAlignment.Center);
            this.listView1.Columns.Insert(3, "Time", 80, HorizontalAlignment.Center);
        }

        public void displayEventList()
        {
            this.listView1.Show();
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
            int i;

            ActiveUser userRole = new ActiveUser(currentUser);

            //List<EventEntity> outputEventListing = userRole.viewEventListingByEventName(searchEventTextBox.Text);

            initEventList();
            
            //Testing 
            Database db = Database.CreateDatabase("cd#ew1Tf");
            List<EventEntity> testing = db.getListOfEvents();

            for (i = 0; i < testing.Count; i++)
            {
                EventEntity outputEvent = testing[i];

                ListViewItem newEvent = new ListViewItem(i.ToString());
                newEvent.SubItems.Add(outputEvent.getEventName());
                newEvent.SubItems.Add(outputEvent.getEventDate().ToString("dd/mm/yy"));
                newEvent.SubItems.Add(outputEvent.getEventDate().ToString("t"));

                listView1.Items.Add(newEvent);
            }


            displayEventList();
        }

        private void organiserEditButton_Click(object sender, EventArgs e)
        {

        }

       

        private void getEventInfoButton_Click(object sender, EventArgs e)
        {
            eventInfoForm eventInfoPage = new eventInfoForm(currentUser, currentEventID);
            eventInfoPage.Show();
        }
    }
}