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
    public partial class mainPage : Form
    {
        private User currentUser;
        public mainPage()
        {
            InitializeComponent();
        }

        private void registerEvent_Click(object sender, EventArgs e)
        {
            createEventForm createEvent = new createEventForm(currentUser);
            createEvent.Show();
        }
    }
}
