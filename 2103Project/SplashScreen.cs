using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using _2103Project.Entities;

/*
 * Authors for this section
 * 
 *   Lim Zhi Hao A0067252H
 *   Tan Siong Wee, Edmund  A0076627W
*/

namespace _2103Project
{
    public partial class welcomeForm : Form
    {
        private User currentUser;

        public void MainPageThreadProc()
        {
            Application.Run(new mainPage(currentUser));
        }

        public welcomeForm(User incomingUser)
        {
            InitializeComponent();

            currentUser = incomingUser;
        }

        private void welcomeForm_Shown(object sender, EventArgs e)
        {
            this.Close();

            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(MainPageThreadProc));
            t.Start();
        }
    }
}
