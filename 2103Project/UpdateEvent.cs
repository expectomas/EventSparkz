using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _2103Project.Entities;

namespace EventSparkzv1._1
{
    public partial class eventUpdateForm : Form
    {
        int currentEventID = 1;
        private User currentUser;
        public eventUpdateForm(User incomingUser, int incomingEventID)
        {
            InitializeComponent();
            currentUser = incomingUser;
            currentEventID = incomingEventID;
        }

        private void eventUpdateForm_Load(object sender, EventArgs e)
        {
            EventEntity newEve = Facilitator.getEventEntity(currentEventID);
            titleLabel.Text = newEve.getEventName();
            int organiserID = newEve.getOrganiserID();
            organiserTextBox.Text = User.getNamefromID(organiserID);
            participantTextbox.Text = EventEntity.getParticipantNumber(currentEventID).ToString();
            DateTime dateValue = EventEntity.getStartTime(currentEventID);
            dateTextBox.Text = String.Format("{0:f}", dateValue);
            venueComboBox.Text = EventEntity.getStartVenueFromEventID(currentEventID);
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
        }
    }
}
