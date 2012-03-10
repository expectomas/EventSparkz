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
    
    public partial class eventInfoForm : Form
    {
        private User currentUser;
        private int currentEventID;
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
            string titleName = newEve.getEventName();
            titleLabel.Text = titleName;
            int organiserID = newEve.getOrganiserID();
            organiserLabel.Text = User.getNamefromID(organiserID);
        }
    }
}
