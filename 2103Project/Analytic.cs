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
    public partial class Analytic : Form
    {
        private EventEntity eventToAnalyse;
        private Organiser currentUser;

        public Analytic(User incomingUser)
        {
            currentUser = new Organiser(incomingUser);

            InitializeComponent();
        }


        public void hideOutput()
        {
            eventNameOutput.Hide();
            eventDateOutput.Hide();
            participantSizeOutput.Hide();
        }

        //Obtained the most registerd event

        public void displayMostRegisterEvent()
        {
            EventEntity showCaseEvent = currentUser.getMostRegisteredEvent();

            if (showCaseEvent == null)
            {
                eventNameOutput.Text = "You did not create any events";
                eventDateOutput.Text = "NA.";
                participantSizeOutput.Text = "NA.";
            }
            else
            {
                eventNameOutput.Text = showCaseEvent.getEventName();
                eventDateOutput.Text = showCaseEvent.getEventDate().ToString("dd/MM/yy");
                participantSizeOutput.Text = EventEntity.getParticipantNumber(showCaseEvent.getEventId()).ToString();
            }

            eventNameOutput.Show();
            eventDateOutput.Show();
            participantSizeOutput.Show();
        }

        private void Analytic_Load(object sender, EventArgs e)
        {

            hideOutput();

            displayMostRegisterEvent();
        }
    }
}
