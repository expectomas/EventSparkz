using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using _2103Project.Entities;

namespace _2103Project
{
    public partial class createEventForm : Form
    {

        private User currentUser;

        public createEventForm(User incomingUser)
        {
            currentUser = incomingUser;
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (eventNameTextBox.Text == "" || sizeTextBox.Text == "")
            {
                MessageBox.Show("Please enter all your details. Thank you.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(startTimePicker.Value >= endTimePicker.Value)
            {
                MessageBox.Show("Your date booking is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (timeListBox.Items.Count == 0 || descriptionListBox.Items.Count == 0 || venueListBox.Items.Count == 0)
            {
                MessageBox.Show("Please add your schedule.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string path = "events.xml";
                int neweventId = 1;
                int newscheduleId = 1;
                if (File.Exists(path))
                {
                    neweventId = Organiser.getNewEventId();
                    newscheduleId = Organiser.getNewScheduleId();
                }    
                List<Participant> participantList = new List<Participant>();
                List<int> facilitatorList = new List<int>();
                EventEntity events = new EventEntity(neweventId, eventNameTextBox.Text, startTimePicker.Value, endTimePicker.Value, newscheduleId, int.Parse(sizeTextBox.Text), participantList, facilitatorList, currentUser.getUserId());
                Organiser org = new Organiser();
                Activity newAct; Venue ven;
                DateTime time;
                List<Activity> listOfActivity = new List<Activity>();
                for (int i = 0; i < timeListBox.Items.Count; i++)
                {
                    time = returnTime(timeListBox.Items[i].ToString(), startTimePicker.Value);
                    int newVenueID = org.getCheckVenueId(venueListBox.Items[i].ToString());
                    ven = new Venue(newVenueID, venueListBox.Items[i].ToString());
                    int newActivityID = org.getNewActivityId();
                    newAct = new Activity(newActivityID, time, descriptionListBox.Items[i].ToString() ,ven);
                    listOfActivity.Add(newAct);
                    org.addNewActivity(newAct);
                }
                List<string> listOfItems = new List<string>();
                Schedule newSchedule = new Schedule(newscheduleId ,listOfItems, listOfActivity);
                org.addSchedule(newSchedule);
                org.createEvent(events);
                MessageBox.Show("Your event has been created. Thank you.", "Event Create", MessageBoxButtons.OK, MessageBoxIcon.Information);
                eventNameTextBox.Clear();
                sizeTextBox.Clear();
            }
        }

        private void createEventForm_Load(object sender, EventArgs e)
        {
            DateTime dateValue = DateTime.Now;
            dateValue = dateValue.AddDays(3);
            startTimePicker.Value = dateValue;
            startTimePicker.MinDate = dateValue;
            endTimePicker.Value = dateValue;
            endTimePicker.MinDate = dateValue;
        }

        private void sizeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {         // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }


        bool nonNumberEntered;

        private void sizeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }

            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private DateTime returnTime(string time, DateTime startTime)
        {
            DateTime timeValue = startTime;
            int hour = 0; int min = 0;
            switch (time)
            {
                case "8.00a.m.": hour = 8; min = 0; break;
                case "8.30a.m.": hour = 8; min = 30; break;
                case "9.00a.m.": hour = 9; min = 0; break;
                case "9.30a.m.": hour = 9; min = 30;break;
                case "10.00a.m.": hour = 10; min = 0; break;
                case "10.30a.m.": hour = 10; min = 30; break;
                case "11.00a.m.": hour = 11; min = 0; break;
                case "11.30a.m.": hour = 11; min = 30; break;
                case "12.00p.m.": hour = 12; min = 0; break;
                case "12.30p.m.": hour = 12; min = 30; break;
                case "1.00p.m.": hour = 13; min = 0; break;
                case "1.30p.m.": hour = 13; min = 30; break;
                case "2.00p.m.": hour = 14; min = 0; break;
                case "2.30p.m.": hour = 14; min = 30; break;
                case "3.00p.m.": hour = 15; min = 0; break;
                case "3.30p.m.": hour = 15; min = 30; break;
                case "4.00p.m.": hour = 16; min = 0; break;
                case "4.30p.m.": hour = 16; min = 30; break;
                case "5.00p.m.": hour = 17; min = 0; break;
                case "5.30p.m.": hour = 17; min = 30; break;
                case "6.00p.m.": hour = 18; min = 0; break;
                case "6.30p.m.": hour = 18; min = 30; break;
                case "7.00p.m.": hour = 19; min = 0; break;
                case "7.30p.m.": hour = 19; min = 30; break;
                case "8.00p.m.": hour = 20; min = 0; break;
                case "8.30p.m.": hour = 20; min = 30; break;
                case "9.00p.m.": hour = 21; min = 0; break;
                case "9.30p.m.": hour = 21; min = 30; break;
                case "10.00p.m.": hour = 22; min = 0; break;
                case "10.30p.m.": hour = 22; min = 30; break;
                case "11.00p.m.": hour = 23; min = 0; break;
                case "11.30p.m.": hour = 23; min = 30; break;

            }
            timeValue = new DateTime(startTime.Year, startTime.Month, startTime.Day, hour, min, 0);
            return timeValue;
        }
        private void createEvent_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void addScheduleButton_Click(object sender, EventArgs e)
        {
            if (!(timeComboBox.SelectedItem == null || descriptionTextBox.Text == "" || venueComboBox.SelectedItem == null))
            {
                timeListBox.Items.Add(timeComboBox.SelectedItem.ToString());
                descriptionListBox.Items.Add(descriptionTextBox.Text);
                venueListBox.Items.Add(venueComboBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select your time, description and venue. Thank you.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
