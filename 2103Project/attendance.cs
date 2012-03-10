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
    public partial class attendanceForm : Form
    {
        private int currentEventID;
        private User currentUser;
        public attendanceForm(User currentUser, int incomingEventID)
        {
            this.currentUser = currentUser;
            currentEventID = incomingEventID;
            InitializeComponent();
        }

        private void attendanceForm_Load(object sender, EventArgs e)
        {
            List<Participant> listofPaticipant = new List<Participant>();
            EventEntity newEve = Facilitator.getEventEntity(currentEventID);
            Facilitator fac = new Facilitator(currentUser);
            listofPaticipant = fac.viewParticipantList(newEve);
            foreach (Participant partUser in listofPaticipant)
            {
                participantListBox.Items.Add(partUser.getName());
            }
        }
    }
}
