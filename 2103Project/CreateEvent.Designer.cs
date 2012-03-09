﻿namespace _2103Project
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
            this.timeListView = new System.Windows.Forms.ListView();
            this.descriptionListView = new System.Windows.Forms.ListView();
            this.venueListView = new System.Windows.Forms.ListView();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.venueComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.addScheduleButton = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(13, 79);
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
            this.createButton.Text = "Create an Event";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "dd/MMM/yyyy hh:mm:00 tt";
            this.startTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(18, 103);
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
            this.endTimePicker.Location = new System.Drawing.Point(16, 171);
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
            this.label6.Location = new System.Drawing.Point(14, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "End Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Participant Size:";
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeTextBox.Location = new System.Drawing.Point(18, 236);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(279, 29);
            this.sizeTextBox.TabIndex = 17;
            this.sizeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sizeTextBox_KeyDown);
            this.sizeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sizeTextBox_KeyPress);
            // 
            // timeListView
            // 
            this.timeListView.Location = new System.Drawing.Point(311, 89);
            this.timeListView.Name = "timeListView";
            this.timeListView.Size = new System.Drawing.Size(100, 176);
            this.timeListView.TabIndex = 18;
            this.timeListView.UseCompatibleStateImageBehavior = false;
            // 
            // descriptionListView
            // 
            this.descriptionListView.Location = new System.Drawing.Point(417, 89);
            this.descriptionListView.Name = "descriptionListView";
            this.descriptionListView.Size = new System.Drawing.Size(250, 176);
            this.descriptionListView.TabIndex = 19;
            this.descriptionListView.UseCompatibleStateImageBehavior = false;
            // 
            // venueListView
            // 
            this.venueListView.Location = new System.Drawing.Point(673, 89);
            this.venueListView.Name = "venueListView";
            this.venueListView.Size = new System.Drawing.Size(120, 176);
            this.venueListView.TabIndex = 20;
            this.venueListView.UseCompatibleStateImageBehavior = false;
            // 
            // timeComboBox
            // 
            this.timeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeComboBox.FormattingEnabled = true;
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
            // 
            // createEventForm
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(812, 325);
            this.Controls.Add(this.addScheduleButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.venueComboBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.timeComboBox);
            this.Controls.Add(this.venueListView);
            this.Controls.Add(this.descriptionListView);
            this.Controls.Add(this.timeListView);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventNameTextBox);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.ListView timeListView;
        private System.Windows.Forms.ListView descriptionListView;
        private System.Windows.Forms.ListView venueListView;
        private System.Windows.Forms.ComboBox timeComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox venueComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button addScheduleButton;
       
    }
}