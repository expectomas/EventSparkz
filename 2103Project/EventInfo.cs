using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _2103Project.Entities;

/*
 * Authors for this section
 * 
 *   Lim Zhi Hao A0067252H
 *   Tio Wee Leong A0073702M
 * 
 */

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
            /*All Participants and Organisers can view the facilitator info */

            switch (fixedState)
            {
                case EventEntity.EventInfoStates.unregisteredActiveUser:
                    registerEventBtn.Show();
                    facilitateEventBtn.Show();
                    viewParticipantListBtn.Hide();
                    viewFacilitatorListBtn.Show();
                    break;
                case EventEntity.EventInfoStates.registeredParticipant:
                    registerEventBtn.Hide();
                    facilitateEventBtn.Hide();
                    viewParticipantListBtn.Hide();
                    viewFacilitatorListBtn.Show();
                    viewFacilitatorListBtn.Location = new Point(160, 50);
                    displayStatusLabel("You have already registered for this event");
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

        private void displayStatusLabel(string displayString)
        {
            statusLabel.Hide();

            statusLabel.Text = displayString;

            statusLabel.Show();
        }

        //Dialogs

        private bool Participant_Register_Dialog(string eventName)
        {
            return MessageBox.Show("Confirm registration for " + eventName + " ?", "Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private bool Facilitator_Signup_Dialog(string eventName)
        {
            return MessageBox.Show("Confirm as facilitator for " + eventName + " ?", "Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        //Event Handler

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerEventBtn_Click(object sender, EventArgs e)
        {
            Participant registeringParticipant = new Participant(currentUser);

            EventEntity registeringEvent = EventEntity.getEventFromEventId(currentEventID);

            if(Participant_Register_Dialog(registeringEvent.getEventName()))
            {
                registeringParticipant.registerEvent(registeringEvent);
                MessageBox.Show("You have successfully registered this event. Thank you.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Highlight change in state
            state = determineState(currentEventID);
            displayAppropriateBtn(state);
            this.Close();
        }

        private void facilitateEventBtn_Click(object sender, EventArgs e)
        {
            Facilitator potentialFacilitator = new Facilitator(currentUser);

            EventEntity facilitatingEvent = EventEntity.getEventFromEventId(currentEventID);

            if (Facilitator_Signup_Dialog(facilitatingEvent.getEventName()))
            {
                potentialFacilitator.joinEvent(currentEventID);
            }

            //Highlight change in state
            state = determineState(currentEventID);
            displayAppropriateBtn(state);
        }

        private void viewFacilitatorListBtn_Click(object sender, EventArgs e)
        {
            attendanceForm att = new attendanceForm(currentUser, currentEventID, attendanceForm.attendanceListState.facilitatorList);
            att.Show();
        }

        private void viewParticipantButton_Click(object sender, EventArgs e)
        {
            attendanceForm att = new attendanceForm(currentUser, currentEventID, attendanceForm.attendanceListState.participantList);
            att.Show();
        }
    }
}
