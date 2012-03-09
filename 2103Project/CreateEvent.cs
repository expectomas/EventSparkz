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
    }
}
