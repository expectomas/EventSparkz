using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
                int index = eventComboBox.SelectedIndex;
                string path = "event.txt";
                string tempPath = "temp.txt";
                DialogResult result;
                result = MessageBox.Show("Delete this event?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string strIndex = index.ToString();
                    StreamReader sr = new StreamReader(path);
                    using (StreamWriter swtemp = new StreamWriter(tempPath))
                    {
                        while (sr.Peek() >= 0)
                        {
                            string readLineValue = sr.ReadLine();
                            if (readLineValue.Equals(strIndex))
                            {
                                for (int i = 0; i < 5; i++)
                                {
                                    sr.ReadLine();
                                }
                            }
                            else
                            {
                                swtemp.WriteLine(readLineValue);
                            }
                        }
                        swtemp.Close();
                        sr.Close();
                    }
                    StreamReader sr2 = new StreamReader(tempPath);
                    using (StreamWriter sw2 = new StreamWriter(path))
                    {
                        while (sr2.Peek() >= 0)
                        {
                            string readLineValue = sr2.ReadLine();
                            sw2.WriteLine(readLineValue);
                        }
                        sr2.Close();
                        sw2.Close();
                    }
                    eventComboBox.Items.Remove(eventComboBox.SelectedItem);
                    MessageBox.Show("You have deleted this event", "Delete Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }   
        }

        private void cancelEventForm_Load(object sender, EventArgs e)
        {
            string path = "event.txt";
            int count = 5;
            StreamReader sr = new StreamReader(path);
            while (sr.Peek() >= 0)
            {
                string r = sr.ReadLine();
                if (count == 6)
                {
                    eventComboBox.Items.Add(r);
                    count = 0;
                }
                count++;
            }
            sr.Close();
        }
    }
}
