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
            this.listMainEventView.Columns.Insert(1, "Id", 0, HorizontalAlignment.Left);
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

            //Insert Date and EventId Column
            this.listSideEventView.Columns.Insert(0, "Id", 0, HorizontalAlignment.Left);
            this.listSideEventView.Columns.Insert(1, "Date", 80, HorizontalAlignment.Center);
            this.listSideEventView.Columns.Insert(2, "Event", 200, HorizontalAlignment.Left);

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
                EventEntity outputEvent = sideBarEventListing[i];

                ListViewItem newEvent = new ListViewItem(outputEvent.getEventId().ToString());
                newEvent.SubItems.Add(outputEvent.getEventDate().ToString("dd/MM/yy"));
                newEvent.SubItems.Add(outputEvent.getEventName());

                listSideEventView.Items.Add(newEvent);
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

        //Main Page Dialog Boxes

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

        private bool Participant_Cancel_SideBar_Dialog()
        {
            return MessageBox.Show("Are you sure you would like to opt out of the event?", "Opt Out Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private bool Organiser_Cancel_SideBar_Dialog()
        {
            return MessageBox.Show("Are you sure you would like to cancel the event?", "Cancel Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        //Actions

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
            try
            {
                ListViewItem listItem = this.listMainEventView.SelectedItems[0];
                currentEventID = int.Parse(listItem.SubItems[1].Text);
                eventInfoForm eventInfoPage = new eventInfoForm(currentUser, currentEventID);
                eventInfoPage.Show();
            }
            catch
            {
                MessageBox.Show("Please select your event. Thank you.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eventCatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            initSideEventBar();

            switch (eventCatComboBox.SelectedIndex)
            {
                case 0:
                    //Participant buttons
                    cancelEditButton.Show();
                    organiserEditButton.Hide();
                    organiserCancel.Hide();
                    leaveBtn.Hide();
                    break;
                case 1:
                    //Organiser buttons
                    cancelEditButton.Hide();
                    organiserCancel.Show();
                    organiserEditButton.Show();
                    leaveBtn.Hide();
                    break;
                case 2:
                    //Facilitator buttons 
                    cancelEditButton.Hide();
                    organiserCancel.Hide();
                    organiserEditButton.Hide();
                    leaveBtn.Show();
                    break;
                default:
                    break;
            }
        }

        private void organiserCancel_Click(object sender, EventArgs e)
        {
            int organiserCancellingEventId=-1;

            ListViewItem sideListItem = this.listSideEventView.SelectedItems[0];
            organiserCancellingEventId = int.Parse(sideListItem.SubItems[0].Text);

            Organiser organiser = new Organiser(currentUser);

            if (organiserCancellingEventId != -1)
            {
                if (Organiser_Cancel_SideBar_Dialog())
                {
                    organiser.cancelEvent(organiserCancellingEventId);
                }
            }
        }

        private void cancelEditButton_MouseDown(object sender, MouseEventArgs e)
        {
            //Participant cancel event 
            int participantCancellingEventId = -1;

            ListViewItem sideListItem = this.listSideEventView.SelectedItems[0];
            participantCancellingEventId = int.Parse(sideListItem.SubItems[0].Text);

            Participant participant = new Participant(currentUser);

            if (participantCancellingEventId != -1)
            {
                if (Participant_Cancel_SideBar_Dialog())
                {
                    participant.cancelEventRegistration(participantCancellingEventId);
                }
            }   
        }

        private void searchEventTextBox_Clicked(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && searchEventTextBox.Text == "Search Your Event Here") ;
            {
                searchEventTextBox.Clear();
                searchEventTextBox.Focus();
            }
        }


    }
}

