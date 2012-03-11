namespace _2103Project
{
    partial class createEventForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createEventForm));
            this.label1 = new System.Windows.Forms.Label();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.venueComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.addScheduleButton = new System.Windows.Forms.Button();
            this.timeListBox = new System.Windows.Forms.ListBox();
            this.descriptionListBox = new System.Windows.Forms.ListBox();
            this.venueListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name:";
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameTextBox.Location = new System.Drawing.Point(16, 33);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(279, 29);
            this.eventNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Time:";
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(17, 276);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(280, 37);
            this.createButton.TabIndex = 8;
            this.createButton.Text = "Done";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "dd/MMM/yyyy hh:mm:00 tt";
            this.startTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(19, 96);
            this.startTimePicker.MinDate = new System.DateTime(2012, 2, 12, 21, 26, 45, 0);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(279, 29);
            this.startTimePicker.TabIndex = 10;
            this.startTimePicker.Value = new System.DateTime(2012, 2, 12, 21, 26, 45, 0);
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "dd/MMM/yyyy hh:mm:00 tt";
            this.endTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(17, 164);
            this.endTimePicker.MinDate = new System.DateTime(2012, 2, 12, 21, 26, 45, 0);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(279, 29);
            this.endTimePicker.TabIndex = 15;
            this.endTimePicker.Value = new System.DateTime(2012, 2, 12, 21, 26, 45, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "End Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Participant Size:";
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeTextBox.Location = new System.Drawing.Point(18, 233);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(279, 29);
            this.sizeTextBox.TabIndex = 17;
            this.sizeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sizeTextBox_KeyDown);
            this.sizeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sizeTextBox_KeyPress);
            // 
            // timeComboBox
            // 
            this.timeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Items.AddRange(new object[] {
            "8:00 AM",
            "8:30 AM",
            "9:00 AM",
            "9:30 AM",
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM",
            "12:00 PM",
            "12:30 PM",
            "1:00 PM",
            "1:30 PM",
            "2:00 PM",
            "2:30 PM",
            "3:00 PM",
            "3:30 PM",
            "4:00 PM",
            "4:30 PM",
            "5:00 PM",
            "5:30 PM",
            "6:00 PM",
            "6:30 PM",
            "7:00 PM",
            "7:30 PM",
            "8:00 PM",
            "8:30 PM",
            "9:00 PM",
            "9:30 PM",
            "10:00 PM",
            "10:30 PM",
            "11:00 PM",
            "11:30 PM"});
            this.timeComboBox.Location = new System.Drawing.Point(311, 54);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(100, 29);
            this.timeComboBox.TabIndex = 21;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(417, 54);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(249, 29);
            this.descriptionTextBox.TabIndex = 22;
            // 
            // venueComboBox
            // 
            this.venueComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.venueComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venueComboBox.FormattingEnabled = true;
            this.venueComboBox.Items.AddRange(new object[] {
            "MPSH1",
            "MPSH2",
            "MPSH3",
            "MPSH4",
            "MPSH5",
            "MPSH6"});
            this.venueComboBox.Location = new System.Drawing.Point(672, 54);
            this.venueComboBox.Name = "venueComboBox";
            this.venueComboBox.Size = new System.Drawing.Size(121, 29);
            this.venueComboBox.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(307, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(668, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 26;
            this.label7.Text = "Venue:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(448, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 21);
            this.label9.TabIndex = 28;
            this.label9.Text = "Add Your Schedule Here:";
            // 
            // addScheduleButton
            // 
            this.addScheduleButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addScheduleButton.Location = new System.Drawing.Point(417, 276);
            this.addScheduleButton.Name = "addScheduleButton";
            this.addScheduleButton.Size = new System.Drawing.Size(250, 37);
            this.addScheduleButton.TabIndex = 29;
            this.addScheduleButton.Text = "Add Schedule";
            this.addScheduleButton.UseVisualStyleBackColor = true;
            this.addScheduleButton.Click += new System.EventHandler(this.addScheduleButton_Click);
            // 
            // timeListBox
            // 
            this.timeListBox.FormattingEnabled = true;
            this.timeListBox.Location = new System.Drawing.Point(311, 90);
            this.timeListBox.Name = "timeListBox";
            this.timeListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.timeListBox.Size = new System.Drawing.Size(100, 173);
            this.timeListBox.TabIndex = 30;
            // 
            // descriptionListBox
            // 
            this.descriptionListBox.FormattingEnabled = true;
            this.descriptionListBox.Location = new System.Drawing.Point(417, 90);
            this.descriptionListBox.Name = "descriptionListBox";
            this.descriptionListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.descriptionListBox.Size = new System.Drawing.Size(250, 173);
            this.descriptionListBox.TabIndex = 31;
            // 
            // venueListBox
            // 
            this.venueListBox.FormattingEnabled = true;
            this.venueListBox.Location = new System.Drawing.Point(673, 89);
            this.venueListBox.Name = "venueListBox";
            this.venueListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.venueListBox.Size = new System.Drawing.Size(120, 173);
            this.venueListBox.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(304, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 312);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // createEventForm
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(814, 326);
            this.Controls.Add(this.venueListBox);
            this.Controls.Add(this.descriptionListBox);
            this.Controls.Add(this.timeListBox);
            this.Controls.Add(this.addScheduleButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.venueComboBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.timeComboBox);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "createEventForm";
            this.Text = "Create Event";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.createEvent_FormClosed);
            this.Load += new System.EventHandler(this.createEventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.ComboBox timeComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox venueComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button addScheduleButton;
        private System.Windows.Forms.ListBox timeListBox;
        private System.Windows.Forms.ListBox descriptionListBox;
        private System.Windows.Forms.ListBox venueListBox;
        private System.Windows.Forms.GroupBox groupBox1;
       
    }
}