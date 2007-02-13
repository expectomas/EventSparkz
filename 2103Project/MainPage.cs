﻿﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _2103Project.Entities;
using _2103Project.Action;
using System.Timers;

/*
 * Authors for this section
 * 
 *   Tio Wee Leong A0073702M
 *   Tan Siong Wee, Edmund  A0076627W
 *   Lim Zhi Hao A0067252H
 *   
 */

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

            displayAlert();

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

                ListViewItem newEvent = new ListViewItem((i + 1).ToString());
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
            User newUser = new User();
            Application.Run(new loginForm(newUser));
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

        private bool Facilitator_Leave_SideBar_Dialog()
        {
            return MessageBox.Show("Are you sure you would like to opt out of the event?", "Cancel Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void AdviseUserToMakeASelection()
        {
            MessageBox.Show("Please select an event.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (!LogoutPressed)
                Exit_Dialog();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Exit_Dialog();
        }

        private void searchEventTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchEvent();
            }
        }

        public void initEventList()
        {
            this.listMainEventView.Hide();

            //Clear ListBox Column and Items
            this.listMainEventView.Columns.Clear();
            this.listMainEventView.Items.Clear();


            this.listMainEventView.Columns.Insert(0, "Id", 50, HorizontalAlignment.Left);
            this.listMainEventView.Columns.Insert(1, "Event", 250, HorizontalAlignment.Left);
            this.listMainEventView.Columns.Insert(2, "Date", 80, HorizontalAlignment.Center);
            this.listMainEventView.Columns.Insert(3, "Time", 80, HorizontalAlignment.Center);
        }

        public void displayEventList()
        {
            this.listMainEventView.Show();
        }

        private void searchEventButton_Clicked(object sender, MouseEventArgs e)
        {
            searchEvent();
        }

        private void organiserEditButton_Click(object sender, EventArgs e)
        {
            TimeSpan difference = new TimeSpan(3, 0, 0, 0);
            EventEntity eve = new EventEntity();
            ListViewItem listItem = this.listSideEventView.SelectedItems[0];
            currentEventID = int.Parse(listItem.SubItems[0].Text);

            if ((eve.getStartTimeFromEventID(currentEventID).Subtract(System.DateTime.Now)) <= difference)
            {
                MessageBox.Show("You cannot edit an event that starts 3 days from now.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    updateForm updateNew = new updateForm(currentUser, currentEventID);
                    updateNew.Show();
                }
                catch
                {
                    AdviseUserToMakeASelection();
                }
            }
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
            int organiserCancellingEventId = -1;

            try
            {

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
            catch (ArgumentOutOfRangeException arg_ex)
            {
                AdviseUserToMakeASelection();
            }

            //Refresh the Side Bar
            initSideEventBar();
        }

        private void cancelEditButton_MouseDown(object sender, MouseEventArgs e)
        {
            //Participant cancel event 
            int participantCancellingEventId = -1;

            try
            {

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
            catch (ArgumentOutOfRangeException null_ex)
            {
                AdviseUserToMakeASelection();
            }

            //Refresh the Side Bar
            initSideEventBar();
        }

        private void searchEventTextBox_Clicked(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && searchEventTextBox.Text == "Search Your Event Here")
            {
                searchEventTextBox.Clear();
                searchEventTextBox.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void searchEventDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.listMainEventView.Items.Clear();

            ActiveUser au = new ActiveUser(currentUser);

            List<EventEntity> mainEventListing = au.viewEventListingByDate(searchEventDateTimePicker.Value);

            for (int i = 0; i < mainEventListing.Count; i++)
            {
                EventEntity outputEvent = mainEventListing[i];

                ListViewItem newEvent = new ListViewItem((i + 1).ToString());
                newEvent.SubItems.Add(outputEvent.getEventId().ToString());
                newEvent.SubItems.Add(outputEvent.getEventName());
                newEvent.SubItems.Add(outputEvent.getEventDate().ToString("dd/MM/yy"));
                newEvent.SubItems.Add(outputEvent.getEventDate().ToString("t"));

                listMainEventView.Items.Add(newEvent);
            }
            displayEventList();
        }

        private void leaveBtn_MouseClick(object sender, MouseEventArgs e)
        {
            //Facilitator leave event 
            int facilitatorCancellingEventId = -1;

            try
            {


                ListViewItem sideListItem = this.listSideEventView.SelectedItems[0];
                facilitatorCancellingEventId = int.Parse(sideListItem.SubItems[0].Text);

                Facilitator facilitator = new Facilitator(currentUser);

                if (facilitatorCancellingEventId > 0)
                {
                    if (Facilitator_Leave_SideBar_Dialog())
                    {
                        facilitator.cancelJoinEvent(facilitatorCancellingEventId);
                    }
                }
            }
            catch (ArgumentOutOfRangeException arg_ex)
            {
                AdviseUserToMakeASelection();
            }
            //Refresh the Side Bar
            initSideEventBar();
        }

        private void searchEvent()
        {
            searchEventTextBox.Text = searchEventTextBox.Text.Trim();

            ActiveUser userRole = new ActiveUser(currentUser);

            this.listMainEventView.Items.Clear();
            int i;

            if (searchEventTextBox.Text == "" || searchEventTextBox.Text == "Search Your Event Here")
            {
                List<EventEntity> outputEventListing = userRole.viewEventListing();

                for (i = 0; i < outputEventListing.Count; i++)
                {
                    EventEntity outputEvent = outputEventListing[i];

                    ListViewItem newEvent = new ListViewItem((i + 1).ToString());
                    newEvent.SubItems.Add(outputEvent.getEventId().ToString());
                    newEvent.SubItems.Add(outputEvent.getEventName());
                    newEvent.SubItems.Add(outputEvent.getEventDate().ToString("dd/MM/yy"));
                    newEvent.SubItems.Add(outputEvent.getEventDate().ToString("t"));

                    listMainEventView.Items.Add(newEvent);
                }

                displayMainEventList();
            }

            else
            {
                List<EventEntity> outputEventListing = userRole.viewEventListingByEventName(searchEventTextBox.Text);

                for (i = 0; i < outputEventListing.Count; i++)
                {
                    EventEntity outputEvent = outputEventListing[i];

                    ListViewItem newEvent = new ListViewItem((i + 1).ToString());
                    newEvent.SubItems.Add(outputEvent.getEventId().ToString());
                    newEvent.SubItems.Add(outputEvent.getEventName());
                    newEvent.SubItems.Add(outputEvent.getEventDate().ToString("dd/MM/yy"));
                    newEvent.SubItems.Add(outputEvent.getEventDate().ToString("t"));

                    listMainEventView.Items.Add(newEvent);
                }

                displayMainEventList();
            }
        }

        private void listMainEventView_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem listItem = this.listMainEventView.SelectedItems[0];
            currentEventID = int.Parse(listItem.SubItems[1].Text);
            eventInfoForm eventInfoPage = new eventInfoForm(currentUser, currentEventID);
            eventInfoPage.Show();
        }

        private void viewAlertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlertForm alertNew = new AlertForm(currentUser);
            alertNew.Show();
        }

        public void displayAlert()
        {
            ActiveUser au = new ActiveUser(currentUser);
            int num = au.scoutAlert();

            if (num > 0)   // If there is at least ONE alert
            {
                notifyIcon.Icon = SystemIcons.Application;
                notifyIcon.BalloonTipText = "You have " + num.ToString() + " new alerts!";
                notifyIcon.ShowBalloonTip(1500);
            }
        }
    }
}