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
 *   Tan Siong Wee, Edmund  A0076627W
 *   Tio Wee Leong A0073702M
 * 
 */

namespace _2103Project
{
    public partial class updateForm : Form
    {
        int currentEventID = 1;
        private User currentUser;

        public updateForm(User incomingUser, int incomingEventID)
        {
            currentUser = incomingUser;
            currentEventID = incomingEventID;
            InitializeComponent();
        }

        private void updateForm_Load(object sender, EventArgs e)
        {
            EventEntity newEve = Facilitator.getEventEntity(currentEventID);
            titleLabel.Text = newEve.getEventName();
            int organiserID = newEve.getOrganiserID();
            organiserTextBox.Text = User.getNamefromID(organiserID);
            participantTextbox.Text = EventEntity.getParticipantNumber(currentEventID).ToString();
            DateTime dateValue = EventEntity.getStartTime(currentEventID);
            dateTextBox.Text = String.Format("{0:f}", dateValue);
            venueTextBox.Text = EventEntity.getStartVenueFromEventID(currentEventID);
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

        private void editItemButton_Click(object sender, EventArgs e)
        {
            if (timeListBox.SelectedItem == null || timeComboBox.SelectedItem == null || descriptionListBox.SelectedItem == null || venueListBox.SelectedItem == null || venComboBox.SelectedItem == null || descriptionTextBox.Text == "" )
            {
                MessageBox.Show("Please select one of the items from the schedule to change schedule.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (timeListBox.SelectedItem != null)
                        timeListBox.Items[timeListBox.SelectedIndex] = timeComboBox.SelectedItem.ToString();
                    timeListBox.ClearSelected();
                    if (descriptionListBox.SelectedItem != null)
                        descriptionListBox.Items[descriptionListBox.SelectedIndex] = descriptionTextBox.Text;
                    descriptionListBox.ClearSelected();
                    if (venueListBox.SelectedItem != null)
                    {
                        venueListBox.Items[venueListBox.SelectedIndex] = venComboBox.SelectedItem.ToString();
                        if (venueListBox.SelectedIndex == 0)
                        {
                            venueTextBox.Text = venComboBox.SelectedItem.ToString();
                        }
                    }
                    venueListBox.ClearSelected();
                }
                catch
                {
                    MessageBox.Show("Please edit your schedule properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int numParticipant = int.Parse(participantTextbox.Text);
            
            if (numParticipant < EventEntity.getParticipantNumber(currentEventID))  // Prohibit decrease in participant size
            {
                MessageBox.Show("You are not allowed to decrease the participant size", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (timeListBox.Items.Count != descriptionListBox.Items.Count || timeListBox.Items.Count != venueListBox.Items.Count)
            {
                MessageBox.Show("At least one activity is missing in the schedule!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EventEntity.setParticipantNumFromEventID(currentEventID, numParticipant);
                //set schedule
                List<DateTime> listOfDateTime = new List<DateTime>();
                List<string> listOfdescription = new List<string>();
                List<Venue> listOfVenue = new List<Venue>();
                Venue newVen;
                for (int i = 0; i < timeListBox.Items.Count; i++)
                {
                    DateTime dtValue = Convert.ToDateTime(dateTextBox.Text);
                    string timeTest = timeListBox.Items[i].ToString();
                    listOfDateTime.Add(returnTime(timeListBox.Items[i].ToString(), dtValue));
                    listOfdescription.Add(descriptionListBox.Items[i].ToString());
                    int venueID = Venue.getVenueIdfromLocation(venueListBox.Items[i].ToString());
                    newVen = new Venue(venueID, venueListBox.Items[i].ToString(), Venue.getCapacityFromVenueID(venueID));
                    listOfVenue.Add(newVen);
                }
                EventEntity.setSchedule(currentEventID, listOfDateTime, listOfdescription, listOfVenue);

                MessageBox.Show("Save successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private DateTime returnTime(string time, DateTime startTime)
        {
            DateTime timeValue = startTime;
            int hour = 0; int min = 0;
            switch (time)
            {
                case "8:00 AM": hour = 8; min = 0; break;
                case "8:30 AM": hour = 8; min = 30; break;
                case "9:00 AM": hour = 9; min = 0; break;
                case "9:30 AM": hour = 9; min = 30; break;
                case "10:00 AM": hour = 10; min = 0; break;
                case "10:30 AM": hour = 10; min = 30; break;
                case "11:00 AM": hour = 11; min = 0; break;
                case "11:30 AM": hour = 11; min = 30; break;
                case "12:00 PM": hour = 12; min = 0; break;
                case "12:30 PM": hour = 12; min = 30; break;
                case "1:00 PM": hour = 13; min = 0; break;
                case "1:30 PM": hour = 13; min = 30; break;
                case "2:00 PM": hour = 14; min = 0; break;
                case "2:30 PM": hour = 14; min = 30; break;
                case "3:00 PM": hour = 15; min = 0; break;
                case "3:30 PM": hour = 15; min = 30; break;
                case "4:00 PM": hour = 16; min = 0; break;
                case "4:30 PM": hour = 16; min = 30; break;
                case "5:00 PM": hour = 17; min = 0; break;
                case "5:30 PM": hour = 17; min = 30; break;
                case "6:00 PM": hour = 18; min = 0; break;
                case "6:30 PM": hour = 18; min = 30; break;
                case "7:00 PM": hour = 19; min = 0; break;
                case "7:30 PM": hour = 19; min = 30; break;
                case "8:00 PM": hour = 20; min = 0; break;
                case "8:30 PM": hour = 20; min = 30; break;
                case "9:00 PM": hour = 21; min = 0; break;
                case "9:30 PM": hour = 21; min = 30; break;
                case "10:00 PM": hour = 22; min = 0; break;
                case "10:30 PM": hour = 22; min = 30; break;
                case "11:00 PM": hour = 23; min = 0; break;
                case "11:30 PM": hour = 23; min = 30; break;
            }
            timeValue = new DateTime(startTime.Year, startTime.Month, startTime.Day, hour, min, 0);
            return timeValue;
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            
                if(timeComboBox.SelectedItem == null || descriptionTextBox.Text == "" || venComboBox.SelectedItem == null)
                    MessageBox.Show("Please add your schedule properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    timeListBox.Items.Add(timeComboBox.SelectedItem.ToString());
                    descriptionListBox.Items.Add(descriptionTextBox.Text);
                    venueListBox.Items.Add(venComboBox.SelectedItem.ToString());
                }

        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            if(timeListBox.SelectedItem != null)
                timeListBox.Items.Remove(timeListBox.SelectedItem);
            timeListBox.ClearSelected();
            if (descriptionListBox.SelectedItem != null)
                descriptionListBox.Items.Remove(descriptionListBox.SelectedItem);
            descriptionListBox.ClearSelected();
            if (venueListBox.SelectedItem != null)
                venueListBox.Items.Remove(venueListBox.SelectedItem);
            venueListBox.ClearSelected();
        }
        bool nonNumberEntered;
        private void participantTextbox_KeyDown(object sender, KeyEventArgs e)
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

        private void participantTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {         // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }
    }
}
