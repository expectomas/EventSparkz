﻿using System;
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
    
    public partial class eventInfoForm : Form
    {
        private User currentUser;
        private int currentEventID;
        EventEntity.EventInfoStates state;


        private EventEntity.EventInfoStates determineState(int eventId)
        {
            EventEntity thisEvent = EventEntity.getEventFromEventId(eventId);

            return thisEvent.determineUserState(currentUser.getUserId());
        }

        private void displayAppropriateBtn(EventEntity.EventInfoStates fixedState)
        {
            switch (fixedState)
            {
                case EventEntity.EventInfoStates.unregisteredActiveUser:
                    registerEventBtn.Show();
                    facilitateEventBtn.Show();
                    viewParticipantListBtn.Hide();
                    viewFacilitatorListBtn.Hide();
                    break;
                case EventEntity.EventInfoStates.registeredParticipant:
                    registerEventBtn.Hide();
                    facilitateEventBtn.Hide();
                    viewParticipantListBtn.Hide();
                    viewFacilitatorListBtn.Hide();
                    break;
                case EventEntity.EventInfoStates.facilitator:
                    registerEventBtn.Hide();
                    facilitateEventBtn.Hide();
                    viewParticipantListBtn.Show();
                    viewFacilitatorListBtn.Hide();
                    break;
                case EventEntity.EventInfoStates.organiser:
                    registerEventBtn.Hide();
                    facilitateEventBtn.Hide();
                    viewParticipantListBtn.Show();
                    viewFacilitatorListBtn.Show();
                    break;
            }

            returnBtn.Show();
        }

        public eventInfoForm(User incomingUser, int incomingEventID)
        {
            currentUser = incomingUser;
            currentEventID = incomingEventID;
            InitializeComponent();
        }

        private void viewParticipantButton_Click(object sender, EventArgs e)
        {
            attendanceForm att = new attendanceForm(currentUser, currentEventID);
            att.Show();
        }

        private void eventInfoForm_Load(object sender, EventArgs e)
        {
            EventEntity newEve = Facilitator.getEventEntity(currentEventID);
            titleLabel.Text = newEve.getEventName();
            int organiserID = newEve.getOrganiserID();
            organiserLabel.Text = User.getNamefromID(organiserID);
            noOfParticipantLabel.Text = EventEntity.getParticipantNumber(currentEventID).ToString();
            DateTime dateValue = EventEntity.getStartTime(currentEventID);
            dateLabel.Text = String.Format("{0:f}", dateValue);
            venueLabel.Text = EventEntity.getStartVenueFromEventID(currentEventID);
            Queue<DateTime> listOfDateTime = EventEntity.getListOfTimeFromEventID(currentEventID);
            Queue<string> listofDescription = EventEntity.getListOfDescriptionFromEventID(currentEventID);
            Queue<string> listOfVenue = EventEntity.getListOfVenueFromEventID(currentEventID);
            DateTime dateTimeValue = DateTime.Now;
            while (!(listOfDateTime.Count == 0))
            {
                timeListBox.Items.Add(String.Format("{0:t}", listOfDateTime.Dequeue()));
                descriptionListBox.Items.Add(listofDescription.Dequeue());
                venueListBox.Items.Add(listOfVenue.Dequeue());
            }


            //display the appropriate btn based on the states
            state = determineState(currentEventID);
            displayAppropriateBtn(state);
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
