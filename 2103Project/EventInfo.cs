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
    
    public partial class eventInfoForm : Form
    {
        private void Exit_Dialog()
        {
            if (MessageBox.Show("Are you sure?", "Exit Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                currentUser.logout();
                this.Close();
            }
        }

        private User currentUser;

        public eventInfoForm()
        {
            InitializeComponent();
        }

        private void eventInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Exit_Dialog();

            this.Close();
        }
    }
}
