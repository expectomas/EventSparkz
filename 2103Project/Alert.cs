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
    public partial class AlertForm : Form
    {
        private User currentUser;

        public AlertForm(User currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
        }

        private void AlertForm_Load(object sender, EventArgs e)
        {
            initAlertList();
            displayAlertList();        
        }

        private void initAlertList()
        {
            this.alertListView.Hide();

            //Clear List
            this.alertListView.Columns.Clear();
            this.alertListView.Items.Clear();

            this.alertListView.Columns.Insert(0, "No.", 30);
            this.alertListView.Columns.Insert(1, "Event Name", 130);
            this.alertListView.Columns.Insert(2, "Details", 185);

            this.alertListView.Show();
        }

        private void displayAlertList()
        {
            //Clear List
            alertListView.Items.Clear();

            List<Alert> alerts = new List<Alert>();
            EventEntity eve = new EventEntity();
            ActiveUser au = new ActiveUser(currentUser);
            alerts = au.getListOfAlerts();
            int currentEventID;

            if (alerts.Count != 0)
            {
                for (int i = 0; i < alerts.Count; i++)
                {
                    ListViewItem newAlert = new ListViewItem((i + 1).ToString());
                    newAlert.SubItems.Add(alerts[i].getAlertedEventName()); // Name of Event
                    newAlert.SubItems.Add(alerts[i].getAlert()); // Alert String
                    alertListView.Items.Add(newAlert);

                    // Clear Alert Flag after Displaying
                    currentEventID = eve.getEventIDFromEventName(alerts[i].getAlertedEventName()); 
                    eve.clearEventUpdatedFlag(currentEventID);
                    eve.clearEventFullFlag(currentEventID);
                    eve.clearEventStartFlag(currentEventID);
                }
            }

            alertListView.Show();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.alertListView.Items.Clear();
            this.Close();
        }
    }
}
