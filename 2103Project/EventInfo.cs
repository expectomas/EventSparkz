﻿using System;
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
    
    public partial class eventInfoForm : Form
    {
        private User currentUser;

        public eventInfoForm(User incomingUser)
        {
            currentUser = incomingUser;
            InitializeComponent();
        }

        private void viewParticipantButton_Click(object sender, EventArgs e)
        {
            attendanceForm attForm = new attendanceForm(currentUser);
            attForm.Show();
        }
    }
}
