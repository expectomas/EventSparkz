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

/*
 * Update Event
 * Show list of Activity and ediatable
 */


namespace _2103Project
{
    public partial class updateForm : Form
    {
        int currentEventID = 1;
        int newActivityID = 0;
        private User currentUser;
        Queue<int> listOfActID;
        Queue<DateTime> listOfDateTime;
        Queue<string> listofDescription;
        Queue<string> listOfVenue;
        DateTime endTime;
        DateTime previousScheudleDate;
        List<Activity> listOfActivity = new List<Activity>();

        public updateForm(User incomingUser, int incomingEventID)
        {
            currentUser = incomingUser;
            currentEventID = incomingEventID;
            InitializeComponent();
            endTime = EventEntity.getEndTime(currentEventID);
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
            listOfDateTime = EventEntity.getListOfTimeFromEventID(currentEventID);
            listofDescription = EventEntity.getListOfDescriptionFromEventID(currentEventID);
            listOfVenue = EventEntity.getListOfVenueFromEventID(currentEventID);
            venueTextBox.Text = listOfVenue.Peek();
            Activity currentAct; Venue ven;
            Organiser pub = new Organiser(currentUser);
            int newActID = pub.getNewActivityId();
            newActID++;
            while (listOfDateTime.Count != 0)
            {

                string curlocation = listOfVenue.Dequeue();
                ven = new Venue(Venue.getVenueIdfromLocation(curlocation), curlocation, Venue.getVenueCapacityfromID(Venue.getVenueIdfromLocation(curlocation)));
                currentAct = new Activity(newActID, listOfDateTime.Dequeue(), listofDescription.Dequeue(), ven);
                listOfActivity.Add(currentAct);
                newActID++;
            }
            setScheduleDay(dateValue, endTime);
            dateCombobox.Text = dateValue.ToLongDateString();
        }

        private void setScheduleDay(DateTime startDate, DateTime endDate)
        {
            dateCombobox.Items.Clear();
            TimeSpan diffDate = endDate.Subtract(startDate);
            DateTime currentDate = startDate;
            for (int i = 0; i <= diffDate.Days; i++)
            {
                dateCombobox.Items.Add(currentDate.ToLongDateString());
                currentDate = currentDate.AddDays(1);
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

                // delete schedule
                Activity currentActivity;
                for (int i = 0; i < listOfActivity.Count; i++)
                {
                    currentActivity = listOfActivity[i];
                    if (currentActivity.getDate().Year == Convert.ToDateTime(dateCombobox.Text).Year && currentActivity.getDate().Month == Convert.ToDateTime(dateCombobox.Text).Month && currentActivity.getDate().Day == Convert.ToDateTime(dateCombobox.Text).Day)
                    {
                        listOfActivity.Remove(currentActivity);
                        i--;
                    }
                }

                //set schedule
                Organiser org = new Organiser(currentUser);
                Activity currAct; Venue ven; DateTime time;
                for (int i = 0; i < timeListBox.Items.Count; i++)
                {
                    time = returnTime(timeListBox.Items[i].ToString(), Convert.ToDateTime(dateCombobox.Text));
                    int newVenueID = org.getCheckVenueId(venueListBox.Items[i].ToString());
                    ven = new Venue(newVenueID, venueListBox.Items[i].ToString(), Venue.getVenueCapacityfromID(newVenueID));
                    
                    newActivityID = getNewActIDFromActList(listOfActivity);
                    currAct = new Activity(newActivityID, time, descriptionListBox.Items[i].ToString(), ven);
                    listOfActivity.Add(currAct);
                }
                listOfActivity = sortActivityListByID(listOfActivity);
               
                foreach(Activity act in listOfActivity)
                    org.addNewActivity(act);
                listOfActivity = sortActivityListByTime(listOfActivity);

            //    EventEntity.setSchedule(currentEventID, listOfDateTime, listOfdescription, listOfVenue);
                EventEntity.replaceSchedule(currentEventID, listOfActivity);
                //Set Alert Flag
                EventEntity eve = new EventEntity();
                eve.setEventUpdatedFlag(currentEventID);
                //

                MessageBox.Show("Save successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        List<Activity> sortActivityListByID(List<Activity> listOfActivity)
        {
            int earliestID;
            int earliestIndex = 0;
            Activity earliestAct = listOfActivity[0];
            int currentIndex = 0;
            List<Activity> sortedList = new List<Activity>();
            int value = listOfActivity.Count;
            while (listOfActivity.Count != 0)
            {
                earliestID = listOfActivity[0].getActivityId();
                earliestAct = listOfActivity[0];
                foreach (Activity currAct in listOfActivity)
                {
                    if (currAct.getActivityId() < earliestID)
                    {
                        earliestIndex = currentIndex;
                        earliestAct = currAct;
                    }
                    currentIndex++;
                }
                sortedList.Add(earliestAct);
                listOfActivity.RemoveAt(earliestIndex);
                currentIndex = 0;
                earliestIndex = 0;
            }
            return sortedList;
        }

        List<Activity> sortActivityListByTime(List<Activity> listOfActivity)
        {
            DateTime earliestTime;
            int earliestIndex = 0;
            Activity earliestAct = listOfActivity[0];
            int currentIndex = 0;
            List<Activity> sortedList = new List<Activity>();
            int value = listOfActivity.Count;
            while (listOfActivity.Count != 0)
            {
                earliestTime = listOfActivity[0].getDate();
                earliestAct = listOfActivity[0];
                foreach (Activity currAct in listOfActivity)
                {
                    if (currAct.getDate() < earliestTime)
                    {
                        earliestIndex = currentIndex;
                        earliestAct = currAct;
                        earliestTime = currAct.getDate();
                    }
                    currentIndex++;
                }
                sortedList.Add(earliestAct);
                listOfActivity.RemoveAt(earliestIndex);
                currentIndex = 0;
                earliestIndex = 0;
            }
            return sortedList;
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
            if (dateCombobox.Text == "")
            {
                MessageBox.Show("Please select a day.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (timeComboBox.SelectedItem == null || descriptionTextBox.Text == "" || venComboBox.SelectedItem == null)
                    MessageBox.Show("Please add your schedule properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    DateTime selectedScheduleTime = Convert.ToDateTime(dateCombobox.Text);
                    if (timeListBox.Items.Count != 0)
                    {
                        string time = timeListBox.Items[timeListBox.Items.Count - 1].ToString();
                        if (compareTime(timeComboBox.SelectedItem.ToString(), time))
                        {
                            DateTime addSchTime = new DateTime(selectedScheduleTime.Year, selectedScheduleTime.Month, selectedScheduleTime.Day, returnTime(timeComboBox.SelectedItem.ToString(), selectedScheduleTime).Hour, returnTime(timeComboBox.SelectedItem.ToString(), selectedScheduleTime).Minute, 0);
                            if (addSchTime < endTime)
                            {
                                time = timeComboBox.SelectedItem.ToString();
                                timeListBox.Items.Add(time);
                                descriptionListBox.Items.Add(descriptionTextBox.Text);
                                venueListBox.Items.Add(venComboBox.Text);
                            }
                            else
                            {
                                MessageBox.Show("You are not allowed to book a time that exceed your end of booking time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                            MessageBox.Show("You are not allowed to add a schedule which is earlier than the previous activity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DateTime addSchTime = new DateTime(selectedScheduleTime.Year, selectedScheduleTime.Month, selectedScheduleTime.Day, returnTime(timeComboBox.SelectedItem.ToString(), selectedScheduleTime).Hour, returnTime(timeComboBox.SelectedItem.ToString(), selectedScheduleTime).Minute, 0);
                        if (addSchTime < endTime)
                        {
                            string time = timeComboBox.SelectedItem.ToString();
                            timeListBox.Items.Add(time);
                            descriptionListBox.Items.Add(descriptionTextBox.Text);
                            venueListBox.Items.Add(venComboBox.Text);
                        }
                        else
                        {
                            MessageBox.Show("You are not allowed to book a time that exceed your end of booking time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private bool compareTime(string time1, string time2)
        {
            DateTime value1 = DateTime.Today;
            DateTime value2 = DateTime.Today;
            int hour1 = 0; int min1 = 0; int hour2 = 0; int min2 = 0;
            switch (time1)
            {
                case "8:00 AM": hour1 = 8; min1 = 0; break;
                case "8:30 AM": hour1 = 8; min1 = 30; break;
                case "9:00 AM": hour1 = 9; min1 = 0; break;
                case "9:30 AM": hour1 = 9; min1 = 30; break;
                case "10:00 AM": hour1 = 10; min1 = 0; break;
                case "10:30 AM": hour1 = 10; min1 = 30; break;
                case "11:00 AM": hour1 = 11; min1 = 0; break;
                case "11:30 AM": hour1 = 11; min1 = 30; break;
                case "12:00 PM": hour1 = 12; min1 = 0; break;
                case "12:30 PM": hour1 = 12; min1 = 30; break;
                case "1:00 PM": hour1 = 13; min1 = 0; break;
                case "1:30 PM": hour1 = 13; min1 = 30; break;
                case "2:00 PM": hour1 = 14; min1 = 0; break;
                case "2:30 PM": hour1 = 14; min1 = 30; break;
                case "3:00 PM": hour1 = 15; min1 = 0; break;
                case "3:30 PM": hour1 = 15; min1 = 30; break;
                case "4:00 PM": hour1 = 16; min1 = 0; break;
                case "4:30 PM": hour1 = 16; min1 = 30; break;
                case "5:00 PM": hour1 = 17; min1 = 0; break;
                case "5:30 PM": hour1 = 17; min1 = 30; break;
                case "6:00 PM": hour1 = 18; min1 = 0; break;
                case "6:30 PM": hour1 = 18; min1 = 30; break;
                case "7:00 PM": hour1 = 19; min1 = 0; break;
                case "7:30 PM": hour1 = 19; min1 = 30; break;
                case "8:00 PM": hour1 = 20; min1 = 0; break;
                case "8:30 PM": hour1 = 20; min1 = 30; break;
                case "9:00 PM": hour1 = 21; min1 = 0; break;
                case "9:30 PM": hour1 = 21; min1 = 30; break;
                case "10:00 PM": hour1 = 22; min1 = 0; break;
                case "10:30 PM": hour1 = 22; min1 = 30; break;
                case "11:00 PM": hour1 = 23; min1 = 0; break;
                case "11:30 PM": hour1 = 23; min1 = 30; break;
            }

            switch (time2)
            {
                case "8:00 AM": hour2 = 8; min2 = 0; break;
                case "8:30 AM": hour2 = 8; min2 = 30; break;
                case "9:00 AM": hour2 = 9; min2 = 0; break;
                case "9:30 AM": hour2 = 9; min2 = 30; break;
                case "10:00 AM": hour2 = 10; min2 = 0; break;
                case "10:30 AM": hour2 = 10; min2 = 30; break;
                case "11:00 AM": hour2 = 11; min2 = 0; break;
                case "11:30 AM": hour2 = 11; min2 = 30; break;
                case "12:00 PM": hour2 = 12; min2 = 0; break;
                case "12:30 PM": hour2 = 12; min2 = 30; break;
                case "1:00 PM": hour2 = 13; min2 = 0; break;
                case "1:30 PM": hour2 = 13; min2 = 30; break;
                case "2:00 PM": hour2 = 14; min2 = 0; break;
                case "2:30 PM": hour2 = 14; min2 = 30; break;
                case "3:00 PM": hour2 = 15; min2 = 0; break;
                case "3:30 PM": hour2 = 15; min2 = 30; break;
                case "4:00 PM": hour2 = 16; min2 = 0; break;
                case "4:30 PM": hour2 = 16; min2 = 30; break;
                case "5:00 PM": hour2 = 17; min2 = 0; break;
                case "5:30 PM": hour2 = 17; min2 = 30; break;
                case "6:00 PM": hour2 = 18; min2 = 0; break;
                case "6:30 PM": hour2 = 18; min2 = 30; break;
                case "7:00 PM": hour2 = 19; min2 = 0; break;
                case "7:30 PM": hour2 = 19; min2 = 30; break;
                case "8:00 PM": hour2 = 20; min2 = 0; break;
                case "8:30 PM": hour2 = 20; min2 = 30; break;
                case "9:00 PM": hour2 = 21; min2 = 0; break;
                case "9:30 PM": hour2 = 21; min2 = 30; break;
                case "10:00 PM": hour2 = 22; min2 = 0; break;
                case "10:30 PM": hour2 = 22; min2 = 30; break;
                case "11:00 PM": hour2 = 23; min2 = 0; break;
                case "11:30 PM": hour2 = 23; min2 = 30; break;
            }
            value1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour1, min1, 0);
            value2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour2, min2, 0);
            if (value1 <= value2)
                return false;
            return true;
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

        private void editBudgetButton_Click(object sender, EventArgs e)
        {
            editBudgetForm newEditBudgetOpen = new editBudgetForm(currentUser, currentEventID);
            newEditBudgetOpen.Show();
        }

        private void dateCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Activity currentActivity;
            for (int i = 0; i < listOfActivity.Count; i++)
            {
                currentActivity = listOfActivity[i];
                if (Convert.ToDateTime(dateCombobox.Text).Year == previousScheudleDate.Year && Convert.ToDateTime(dateCombobox.Text).Month == previousScheudleDate.Month && Convert.ToDateTime(dateCombobox.Text).Day == previousScheudleDate.Day)
                    previousScheudleDate = Convert.ToDateTime(dateCombobox.Text);
                if (currentActivity.getDate().Year == previousScheudleDate.Year && currentActivity.getDate().Month == previousScheudleDate.Month && currentActivity.getDate().Day == previousScheudleDate.Day)
                {
                    listOfActivity.Remove(currentActivity);
                    i--;
                }
            }

            
            DateTime time;
            Activity newAct;
            Organiser org = new Organiser(currentUser);
            Venue ven;

            for (int i = 0; i < timeListBox.Items.Count; i++)
            {
                time = returnTime(timeListBox.Items[i].ToString(), previousScheudleDate);
                int newVenueID = org.getCheckVenueId(venueListBox.Items[i].ToString());
                ven = new Venue(newVenueID, venueListBox.Items[i].ToString(), Venue.getVenueCapacityfromID(newVenueID));
                newActivityID = getNewActIDFromActList(listOfActivity);
                newAct = new Activity(newActivityID, time, descriptionListBox.Items[i].ToString(), ven);
                listOfActivity.Add(newAct);
            }

            timeListBox.Items.Clear(); descriptionListBox.Items.Clear(); venueListBox.Items.Clear();

            foreach (Activity currAct in listOfActivity)
            {
                DateTime currTime = currAct.getDate();
                if (currAct.getDate().Year == Convert.ToDateTime(dateCombobox.SelectedItem.ToString()).Year && currAct.getDate().Month == Convert.ToDateTime(dateCombobox.SelectedItem.ToString()).Month && currAct.getDate().Day == Convert.ToDateTime(dateCombobox.SelectedItem.ToString()).Day)
                {
                    if (listOfActivity.Count != 0)
                    {
                        timeListBox.Items.Add(String.Format("{0:t}", currAct.getDate()));
                        descriptionListBox.Items.Add(currAct.getDescription());
                        venueListBox.Items.Add(currAct.getVenue().getlocation());
                    }
                }
            }
        }

        private int getNewActIDFromActList(List<Activity> listOfActivity)
        {
            int lastID = 0;
            lastID = listOfActivity[0].getActivityId();
            foreach (Activity currAct in listOfActivity)
            {
                if(currAct.getActivityId() > lastID)
                    lastID = currAct.getActivityId();
            }
            lastID++;
            return lastID;
        }

        private void participantTextbox_Leave(object sender, EventArgs e)
        {
            if (participantTextbox.Text != "")
            {
                venComboBox.Items.Clear();
                List<string> listOfVenue = Venue.getListofVenueFromCapacity(int.Parse(participantTextbox.Text));
                foreach (string strLocation in listOfVenue)
                {
                    venComboBox.Items.Add(strLocation);
                }
            }
        }

        private void dateCombobox_MouseClick(object sender, MouseEventArgs e)
        {
            if (dateCombobox.Text != "")
                previousScheudleDate = Convert.ToDateTime(dateCombobox.Text);
        }
    }
}
