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
    public partial class attendanceForm : Form
    {
        public enum attendanceListState { facilitatorList, participantList };

        private int currentEventID;
        private User currentUser;
        private attendanceListState currentState;

        public attendanceForm(User currentUser, int incomingEventID, attendanceListState incomingState)
        {
            this.currentUser = currentUser;
            currentEventID = incomingEventID;
            currentState = incomingState;
            InitializeComponent();
        }

        private void initAttendanceList()
        {
            this.attendanceListView.Hide();

            //Clear List
            this.attendanceListView.Columns.Clear();
            this.attendanceListView.Items.Clear();

            this.attendanceListView.Columns.Insert(0,"No.",30);
            this.attendanceListView.Columns.Insert(1,"Name",150);
            this.attendanceListView.Columns.Insert(2, "Email", 130);
            this.attendanceListView.Columns.Insert(3, "HP", 100);

            this.attendanceListView.Show();
        }

        private void attendanceForm_Load(object sender, EventArgs e)
        {
            initAttendanceList();

            if (currentState == attendanceListState.participantList)
                displayParticipantList();
            else
                displayFacilitatorList();
        }

        private void displayParticipantList()
        {
            //Clear List
            attendanceListView.Items.Clear();

            //Change Label
            label1.Text = "Participant List";

            List<Participant> listofParticipant = new List<Participant>();
            EventEntity newEve = EventEntity.getEventFromEventId(currentEventID);
            Facilitator fac = new Facilitator(currentUser);
            listofParticipant = fac.viewParticipantList(newEve);

            if (listofParticipant.Count != 0)
            {
                for (int i = 0; i < listofParticipant.Count; i++)
                {
                    ListViewItem newParticipant = new ListViewItem((i + 1).ToString());

                    newParticipant.SubItems.Add(listofParticipant[i].getName().ToString());

                    newParticipant.SubItems.Add(listofParticipant[i].getEmail().ToString());

                    newParticipant.SubItems.Add(listofParticipant[i].getContactHP().ToString());

                    attendanceListView.Items.Add(newParticipant);
                }
            }
            else
            {
                ListViewItem newParticipant = new ListViewItem("No Participants");
            }

            attendanceListView.Show();
        }

        private void displayFacilitatorList()
        {
            //Clear List 
            attendanceListView.Items.Clear();

            //change Label
            label1.Text = "Facilitator List";

            List<Facilitator> listOfFacilitator = new List<Facilitator>();
            EventEntity currentEvent = EventEntity.getEventFromEventId(currentEventID);
            Organiser org = new Organiser(currentUser);
            listOfFacilitator = org.viewListOfFacilitator(currentEvent);

            if (listOfFacilitator.Count != 0)
            {
                for (int i = 0; i < listOfFacilitator.Count; i++)
                {
                    ListViewItem newFacilitator = new ListViewItem((i + 1).ToString());
                    newFacilitator.SubItems.Add(listOfFacilitator[i].getName());
                    newFacilitator.SubItems.Add(listOfFacilitator[i].getEmail());
                    newFacilitator.SubItems.Add(listOfFacilitator[i].getContactHP().ToString());

                    attendanceListView.Items.Add(newFacilitator);
                }
            }
            else
            {
                ListViewItem newFacilitator = new ListViewItem("No Facilitator");
            }

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
