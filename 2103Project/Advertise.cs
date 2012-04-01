using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using _2103Project.Action;
using _2103Project.Entities;

namespace _2103Project
{
    public partial class Advertise : Form
    {
        string eventName;

        public Advertise(string advertisingEventName)
        {
            eventName = advertisingEventName;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionFactory confac = new CloudConnectionFactory();

            Connection conn = confac.createConnection("AmazonWebServices", Connection.TypeOfMsg.Announcement);

            if (descriptionBox.TextLength.Equals(0))
                MessageBox.Show("Please enter the description for your event");
            else if (imgFileLocation.TextLength > 2)
                MessageBox.Show("Please enter just two characters (eg. 6v)");
            else
            {

                Advertisement newAd = new Advertisement(Organiser.getNewEventId(), imgFileLocation.Text, descriptionBox.Text);

                statusLbl1.Text = "Sending Advertisement...";

                statusLbl1.Show();

                Thread.Sleep(2000);

                statusLbl1.Hide();

                statusLbl1.Text = "Advertisement Sent";

                statusLbl1.Show();

                conn.sendMessage(newAd);

            }
        }

        private void Advertise_Activated(object sender, EventArgs e)
        {
            eventLabel1.Text = eventName;
        }

       
        
        
    }
}
