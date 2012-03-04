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
    public partial class cancelEventForm : Form
    {
        public cancelEventForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (eventComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please choose an event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            else
            {
                Organiser org = new Organiser();                
                DialogResult result;
                result = MessageBox.Show("Delete this event?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    org.cancelEvent(eventComboBox.SelectedItem.ToString());
                    eventComboBox.Items.Remove(eventComboBox.SelectedItem);
                    MessageBox.Show("You have deleted this event", "Delete Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }   
        }

        private void cancelEventForm_Load(object sender, EventArgs e)
        {
            Queue<string> listOfEvents = new Queue<string>();
            listOfEvents = Organiser.loadListOfEvent();
            while (listOfEvents.Count > 0)
            {
                eventComboBox.Items.Add(listOfEvents.Dequeue());
            }
        }
    }
}
