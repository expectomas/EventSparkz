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

/*
 * Authors for this section
 * 
 *   Tan Siong Wee, Edmund  A0076627W
 *   Tio Wee Leong          A0073702M
 * 
 */


namespace _2103Project
{
    public partial class createEventForm : Form
    {

        private User currentUser;

        public createEventForm(User incomingUser)
        {
            currentUser = incomingUser;
            InitializeComponent();
            initMainEventList();
            initBudgetList();
        }

        public void initMainEventList()
        {
            //Clear ListBox Column and Items
            scheduleEventView.Columns.Insert(0, "Time", 80, HorizontalAlignment.Left);
            scheduleEventView.Columns.Insert(1, "Description", 220, HorizontalAlignment.Left);
            scheduleEventView.Columns.Insert(2, "Venue", 80, HorizontalAlignment.Left);
        }

        public void initBudgetList()
        {
            budgetListListView.Columns.Insert(0, "Item", 180, HorizontalAlignment.Left);
            budgetListListView.Columns.Insert(1, "Cost ($)", 80, HorizontalAlignment.Left);
            budgetListListView.Columns.Insert(2, "ItemID", 0, HorizontalAlignment.Right);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (eventNameTextBox.Text == "" && sizeTextBox.Text == "")
            {
                MessageBox.Show("Please fill in the event details. Thank you.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (eventNameTextBox.Text == "")
            {
                MessageBox.Show("Please enter an event name. Thank you.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (sizeTextBox.Text == "")
            {
                MessageBox.Show("Please enter the particpatiant size. Thank you.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (startTimePicker.Value > endTimePicker.Value)
            {
                MessageBox.Show("The event's start date cannot be after its end date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (startTimePicker.Value == endTimePicker.Value)
            {
                MessageBox.Show("The event cannot have the same start and end time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.Parse(sizeTextBox.Text) < 1)
            {
                MessageBox.Show("You cannot create an event with 0 participant size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Organiser org = new Organiser(currentUser);
                Activity newAct; Venue ven;
                DateTime time;
                List<Activity> listOfActivity = new List<Activity>();
                for (int i = 0; i < scheduleEventView.Items.Count; i++)
                {
                    time = returnTime(scheduleEventView.Items[i].SubItems[0].ToString(), startTimePicker.Value);
                    int newVenueID = org.getCheckVenueId(scheduleEventView.Items[i].SubItems[2].ToString());
                    ven = new Venue(newVenueID,scheduleEventView.Items[i].SubItems[2].ToString());
                    int newActivityID = org.getNewActivityId();
                    newAct = new Activity(newActivityID, time, scheduleEventView.Items[i].SubItems[1].ToString(), ven);
                    listOfActivity.Add(newAct);
                    org.addNewActivity(newAct);
                }
                List<string> listOfItems = new List<string>();
                Schedule newSchedule = new Schedule(newscheduleId, listOfItems, listOfActivity);
                org.addSchedule(newSchedule);
                org.createEvent(events);
                MessageBox.Show("Your event has been created. Thank you.", "Event Create", MessageBoxButtons.OK, MessageBoxIcon.Information);
                eventNameTextBox.Clear();
                sizeTextBox.Clear();
                this.Close();
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
                case "8:00 AM": hour = 8; min = 0; break;
                case "8:30 AM": hour = 8; min = 30; break;
                case "9:00 AM": hour = 9; min = 0; break;
                case "9:30 AM": hour = 9; min = 30;break;
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
        private void createEvent_FormClosed(object sender, FormClosedEventArgs e)
        {

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
                case "9:30 AM": hour1 = 9; min1 = 30;break;
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
                case "9:30 AM": hour2 = 9; min2 = 30;break;
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

        private void addScheduleButton_Click(object sender, EventArgs e)
        {
            if (!(timeComboBox.SelectedItem == null || descriptionTextBox.Text == "" || venueComboBox.SelectedItem == null))
            {
                if (scheduleEventView.Items.Count != 0)
                {
                    string time = scheduleEventView.Items[scheduleEventView.Items.Count - 1].SubItems[0].Text;
                    if (compareTime(timeComboBox.SelectedItem.ToString(), time))
                    {
                        ListViewItem newevent = new ListViewItem(timeComboBox.SelectedItem.ToString());
                        newevent.SubItems.Add(descriptionTextBox.Text);
                        newevent.SubItems.Add(venueComboBox.SelectedItem.ToString());
                        scheduleEventView.Items.Add(newevent);
                    }
                    else
                        MessageBox.Show("You are not allowed to add a schedule which is earlier than the previous activity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ListViewItem newevent = new ListViewItem(timeComboBox.SelectedItem.ToString());
                    newevent.SubItems.Add(descriptionTextBox.Text);
                    newevent.SubItems.Add(venueComboBox.SelectedItem.ToString());
                    scheduleEventView.Items.Add(newevent);
                }
            }
            else
            {
                MessageBox.Show("Please select your time, description and venue. Thank you.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteScheduleButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < scheduleEventView.Items.Count; i++)
            {
                if (scheduleEventView.Items[i].Selected)
                    scheduleEventView.Items[i].Remove();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < budgetListListView.Items.Count; i++)
            {
                if (budgetListListView.Items[i].Selected)
                    budgetListListView.Items[i].Remove();
            }
            float totalPrice = 0;
            for (int i = 0; i < budgetListListView.Items.Count; i++)
            {
                totalPrice += float.Parse(budgetListListView.Items[i].SubItems[1].Text);
            }
            totalPriceTextBox.Text = totalPrice.ToString("N2");
        }

        private void addBudgetItem_Click(object sender, EventArgs e)
        {
            if (costTextBox.Text.Equals(String.Empty) || budgetItemTextBox.Text.Equals(String.Empty) || dpTextBox.Text.Equals(String.Empty))
            {
                MessageBox.Show("The item or price is empty. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float totalPrice = float.Parse(totalPriceTextBox.Text);
                ListViewItem newItem = new ListViewItem(budgetItemTextBox.Text);
                float price = float.Parse(costTextBox.Text) + float.Parse(dpTextBox.Text) / 100.0f;
                newItem.SubItems.Add(price.ToString("N2"));
                newItem.SubItems.Add((budgetListListView.Items.Count + 1).ToString());
                budgetListListView.Items.Add(newItem);
                totalPriceTextBox.Text = (totalPrice + price).ToString("N2");
            }
        }

        private void costTextBox_KeyDown(object sender, KeyEventArgs e)
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

        private void costTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {         // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

        private void dpTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {         // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

        private void dpTextBox_KeyDown(object sender, KeyEventArgs e)
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
    }
}
