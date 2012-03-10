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
        //Initiatisation

        public mainPage(User incomingUser)
        {
            InitializeComponent();

            currentUser = incomingUser;

            //Initialised Dynamic Controls
            initMainEventList();
            initSideDDL();
            initSideEventBar();
        }

        public void initMainEventList()
        {
            this.listMainEventView.Hide();

            //Clear ListBox Column and Items
            this.listMainEventView.Columns.Clear();
            this.listMainEventView.Items.Clear();

            this.listMainEventView.Columns.Insert(0, "No", 50, HorizontalAlignment.Left);
            this.listMainEventView.Columns.Insert(1, "Id", 50, HorizontalAlignment.Left);
            this.listMainEventView.Columns.Insert(2, "Event", 220, HorizontalAlignment.Left);
            this.listMainEventView.Columns.Insert(3, "Date", 80, HorizontalAlignment.Center);
            this.listMainEventView.Columns.Insert(4, "Time", 80, HorizontalAlignment.Center);

            //All users can view all current events

            ActiveUser obtainedAccessUser = new ActiveUser(currentUser);

            List<EventEntity> mainEventListing = obtainedAccessUser.viewEventListing();

            for (int i = 0; i < mainEventListing.Count; i++)
            {
                EventEntity outputEvent = mainEventListing[i];

                ListViewItem newEvent = new ListViewItem((i+1).ToString());
                newEvent.SubItems.Add(outputEvent.getEventId().ToString());
                newEvent.SubItems.Add(outputEvent.getEventName());
                newEvent.SubItems.Add(outputEvent.getEventDate().ToString("dd/MM/yy"));
                newEvent.SubItems.Add(outputEvent.getEventDate().ToString("t"));

                listMainEventView.Items.Add(newEvent);
            }

            listMainEventView.Show();
        }

        public void initSideDDL()
        {
            eventCatComboBox.Hide();
            eventCatComboBox.Items.Clear();

            eventCatComboBox.Items.Insert(0, "Registered Event");
            eventCatComboBox.Items.Insert(1, "Created Event");
            eventCatComboBox.Items.Insert(2, "Facilitator List");
            eventCatComboBox.SelectedIndex = 0;

            eventCatComboBox.Show();

        }

        public void initSideEventBar()
        {
            this.listSideEventView.Hide();

            this.listSideEventView.Alignment = ListViewAlignment.Top;


            //Clear Side ListBox Columns and Items
            this.listSideEventView.Columns.Clear();
            this.listSideEventView.Items.Clear();

            List<EventEntity> sideBarEventListing;

            //Get the value of the DDL selected value
            switch (eventCatComboBox.SelectedIndex)
            {
                case 0: 
                    //Participant Action
                    Participant currentParticipant = new Participant(currentUser);
                    sideBarEventListing = currentParticipant.getRegisteredEvents();
                    break;
                case 1:
                    Organiser currentOrganiser = new Organiser(currentUser);
                    sideBarEventListing = currentOrganiser.getOrganisedEvents();
                    break;
                case 2:
                    Facilitator currentFacilitator = new Facilitator(currentUser);
                    sideBarEventListing = currentFacilitator.getFacilitatedEvents();
                    break;
                default: 
                    sideBarEventListing = new List<EventEntity>(0);
                    break;
            }

            for (int i = 0; i < sideBarEventListing.Count; i++)
            {
                listSideEventView.Items.Add(sideBarEventListing[i].getEventName());
            }

            this.listSideEventView.Show();
        }

        public static void ThreadProc()
        {
            Application.Run(new loginForm(null));
        }

        public void populateRegisteredEvent()
        {
            if (currentUser != null)
            {
                

            }
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

        public void displayMainEventList()
        {
            this.listMainEventView.Show();
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

        public void initEventList()
        {
            this.listMainEventView.Hide();

            //Clear ListBox Column and Items
            this.listMainEventView.Columns.Clear();
            this.listMainEventView.Items.Clear();


            this.listMainEventView.Columns.Insert(0, "Id",50 , HorizontalAlignment.Left);
            this.listMainEventView.Columns.Insert(1, "Event", 250 , HorizontalAlignment.Left);
            this.listMainEventView.Columns.Insert(2, "Date", 80, HorizontalAlignment.Center);
            this.listMainEventView.Columns.Insert(3, "Time", 80, HorizontalAlignment.Center);
        }

        public void displayEventList()
        {
            this.listMainEventView.Show();
        }

        //Event Handler

        private void searchEventButton_Clicked(object sender, MouseEventArgs e)
        {
            this.listMainEventView.Items.Clear();
            int i;

            ActiveUser userRole = new ActiveUser(currentUser);

            //List<EventEntity> outputEventListing = userRole.viewEventListingByEventName(searchEventTextBox.Text);
            
            //Testing 
            Database db = Database.CreateDatabase("cd#ew1Tf");
            List<EventEntity> testing = db.getListOfEvents();

            for (i = 0; i < testing.Count; i++)
            {
                EventEntity outputEvent = testing[i];

                ListViewItem newEvent = new ListViewItem((i + 1).ToString());
                newEvent.SubItems.Add(outputEvent.getEventId().ToString());
                newEvent.SubItems.Add(outputEvent.getEventName());
                newEvent.SubItems.Add(outputEvent.getEventDate().ToString("dd/MM/yy"));
                newEvent.SubItems.Add(outputEvent.getEventDate().ToString("t"));

                listMainEventView.Items.Add(newEvent);
            }

            displayMainEventList();
        }

        private void organiserEditButton_Click(object sender, EventArgs e)
        {

        }

        private void getEventInfoButton_Click(object sender, EventArgs e)
        {
            ListViewItem listItem = this.listMainEventView.SelectedItems[0];
            currentEventID = int.Parse(listItem.SubItems[1].Text);
            eventInfoForm eventInfoPage = new eventInfoForm(currentUser, currentEventID);
            eventInfoPage.Show();
        }

        private void eventCatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            initSideEventBar();

            //If Created Events is selected
            if (eventCatComboBox.SelectedIndex == 1)
            {
                //Hide the cancel button
                //Display 

            }
        }

    }
}

