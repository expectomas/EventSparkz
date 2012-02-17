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
    public partial class createEventForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public createEventForm()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string path = "event.txt";
            string tempPath = "temp.txt";
            string eventId = "-1";
            int fivecounts = 5;
            string pathExt = Path.GetExtension(fileDirectoryLabel.Text);
            if (eventNameTextBox.Text == "" || venueComboBox.SelectedItem == null || budgetLimitTextBox.Text == "")
            {
                MessageBox.Show("Please enter all your details. Thank you.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (fileDirectoryLabel.Text.Equals("Import your file here."))
            {
                MessageBox.Show("Please include your description of your event. Thank you.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!pathExt.Equals(".txt"))
            {
                MessageBox.Show("Please include your description of your event in .txt format. Thank you.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var lineCount = File.ReadAllLines(fileDirectoryLabel.Text);
                if (lineCount.Length != 1)
                {
                    MessageBox.Show("Please provide your description of your event in a single line. Thank you.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!File.Exists(path))
                    {
                        FileStream fs = File.Create(path);
                        fs.Close();
                    }
                    if (!File.Exists(tempPath))
                    {
                        FileStream fs = File.Create(tempPath);
                        fs.Close();
                    }

                    StreamReader sr = new StreamReader(fileDirectoryLabel.Text);
                    StreamReader sr3 = new StreamReader(path);
                    using (StreamWriter swtemp = new StreamWriter(tempPath))
                    {
                        while (sr3.Peek() >= 0)
                        {
                            string r = sr3.ReadLine();
                            swtemp.WriteLine(r);
                        }
                        sr3.Close();
                        swtemp.Close();
                    }
                    StreamReader sr2 = new StreamReader(tempPath);
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        while (sr2.Peek() >= 0)
                        {
                            if (fivecounts == 5)
                            {
                                eventId = sr2.ReadLine();
                                sw.WriteLine(eventId);
                                fivecounts = 0;
                            }
                            else
                            {
                                string r = sr2.ReadLine();
                                sw.WriteLine(r);
                                fivecounts++;
                            }
                        }
                        sr2.Close();
                        int eventNumID = int.Parse(eventId);
                        eventNumID++;
                        sw.WriteLine(eventNumID.ToString());
                        sw.WriteLine(eventNameTextBox.Text);
                        sw.WriteLine(dateTimePicker.Text);
                        sw.WriteLine(venueComboBox.SelectedItem.ToString());
                        sw.WriteLine(budgetLimitTextBox.Text);
                        while (sr.Peek() >= 0)
                        {
                            string r = sr.ReadLine();
                            sw.WriteLine(r);
                        }
                        sr.Close();
                        sw.Close();
                    }
                    MessageBox.Show("Your event has been created. Thank you.", "Event Create", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    eventNameTextBox.Clear();
                    budgetLimitTextBox.Clear();
                    fileDirectoryLabel.Text = "Import your file here.";
                }
            }
        }

        private void importFileButton_Click(object sender, EventArgs e)
        {
            opentxtFileDialog.ShowDialog();
        }

        private void opentxtFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            fileDirectoryLabel.Text = opentxtFileDialog.FileName;
        }

        private void createEventForm_Load(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Now;
            dateTimePicker.MinDate = DateTime.Today;
        }
    }
}
