namespace _2103Project
{
    partial class mainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage));
            this.titleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listSideEventView = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.registerEvent = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.listMainEventView = new System.Windows.Forms.ListView();
            this.getEventInfoButton = new System.Windows.Forms.Button();
            this.eventCatComboBox = new System.Windows.Forms.ComboBox();
            this.cancelEditButton = new System.Windows.Forms.Button();
            this.searchEventDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchEventTextBox = new System.Windows.Forms.TextBox();
            this.searchEventButton = new System.Windows.Forms.Button();
            this.organiserEditButton = new System.Windows.Forms.Button();
            this.organiserCancel = new System.Windows.Forms.Button();
            this.leaveBtn = new System.Windows.Forms.Button();
            this.announcementList1 = new System.Windows.Forms.ListView();
            this.statuslabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(11, 149);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(68, 16);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Event For:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "EventSparkZ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listSideEventView
            // 
            this.listSideEventView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSideEventView.FullRowSelect = true;
            this.listSideEventView.GridLines = true;
            this.listSideEventView.Location = new System.Drawing.Point(533, 234);
            this.listSideEventView.Name = "listSideEventView";
            this.listSideEventView.Size = new System.Drawing.Size(221, 318);
            this.listSideEventView.TabIndex = 3;
            this.listSideEventView.UseCompatibleStateImageBehavior = false;
            this.listSideEventView.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(528, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "My Event:";
            // 
            // registerEvent
            // 
            this.registerEvent.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.registerEvent.Location = new System.Drawing.Point(79, 557);
            this.registerEvent.Name = "registerEvent";
            this.registerEvent.Size = new System.Drawing.Size(120, 30);
            this.registerEvent.TabIndex = 7;
            this.registerEvent.Text = "Create Event";
            this.registerEvent.UseVisualStyleBackColor = true;
            this.registerEvent.Click += new System.EventHandler(this.registerEvent_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.logoutButton.Location = new System.Drawing.Point(682, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 28);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // listMainEventView
            // 
            this.listMainEventView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMainEventView.FullRowSelect = true;
            this.listMainEventView.GridLines = true;
            this.listMainEventView.Location = new System.Drawing.Point(14, 234);
            this.listMainEventView.Name = "listMainEventView";
            this.listMainEventView.Size = new System.Drawing.Size(484, 318);
            this.listMainEventView.TabIndex = 9;
            this.listMainEventView.UseCompatibleStateImageBehavior = false;
            this.listMainEventView.View = System.Windows.Forms.View.Details;
            this.listMainEventView.DoubleClick += new System.EventHandler(this.listMainEventView_DoubleClick);
            // 
            // getEventInfoButton
            // 
            this.getEventInfoButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getEventInfoButton.Location = new System.Drawing.Point(307, 557);
            this.getEventInfoButton.Name = "getEventInfoButton";
            this.getEventInfoButton.Size = new System.Drawing.Size(120, 30);
            this.getEventInfoButton.TabIndex = 6;
            this.getEventInfoButton.Text = "Get Event Info";
            this.getEventInfoButton.UseVisualStyleBackColor = true;
            this.getEventInfoButton.Click += new System.EventHandler(this.getEventInfoButton_Click);
            // 
            // eventCatComboBox
            // 
            this.eventCatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventCatComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventCatComboBox.FormattingEnabled = true;
            this.eventCatComboBox.Location = new System.Drawing.Point(533, 199);
            this.eventCatComboBox.Name = "eventCatComboBox";
            this.eventCatComboBox.Size = new System.Drawing.Size(221, 29);
            this.eventCatComboBox.TabIndex = 10;
            this.eventCatComboBox.SelectedIndexChanged += new System.EventHandler(this.eventCatComboBox_SelectedIndexChanged);
            // 
            // cancelEditButton
            // 
            this.cancelEditButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cancelEditButton.Location = new System.Drawing.Point(559, 558);
            this.cancelEditButton.Name = "cancelEditButton";
            this.cancelEditButton.Size = new System.Drawing.Size(168, 30);
            this.cancelEditButton.TabIndex = 11;
            this.cancelEditButton.Text = "Cancel";
            this.cancelEditButton.UseVisualStyleBackColor = true;
            this.cancelEditButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelEditButton_MouseDown);
            // 
            // searchEventDateTimePicker
            // 
            this.searchEventDateTimePicker.Location = new System.Drawing.Point(14, 170);
            this.searchEventDateTimePicker.Name = "searchEventDateTimePicker";
            this.searchEventDateTimePicker.Size = new System.Drawing.Size(208, 22);
            this.searchEventDateTimePicker.TabIndex = 12;
            this.searchEventDateTimePicker.ValueChanged += new System.EventHandler(this.searchEventDateTimePicker_ValueChanged);
            // 
            // searchEventTextBox
            // 
            this.searchEventTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEventTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.searchEventTextBox.Location = new System.Drawing.Point(14, 199);
            this.searchEventTextBox.Name = "searchEventTextBox";
            this.searchEventTextBox.Size = new System.Drawing.Size(361, 29);
            this.searchEventTextBox.TabIndex = 13;
            this.searchEventTextBox.Text = "Search Your Event Here";
            this.searchEventTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchEventTextBox_KeyDown);
            this.searchEventTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.searchEventTextBox_Clicked);
            // 
            // searchEventButton
            // 
            this.searchEventButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEventButton.Location = new System.Drawing.Point(401, 197);
            this.searchEventButton.Name = "searchEventButton";
            this.searchEventButton.Size = new System.Drawing.Size(97, 30);
            this.searchEventButton.TabIndex = 14;
            this.searchEventButton.Text = "Find";
            this.searchEventButton.UseVisualStyleBackColor = true;
            this.searchEventButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchEventButton_Clicked);
            // 
            // organiserEditButton
            // 
            this.organiserEditButton.Location = new System.Drawing.Point(532, 557);
            this.organiserEditButton.Name = "organiserEditButton";
            this.organiserEditButton.Size = new System.Drawing.Size(90, 30);
            this.organiserEditButton.TabIndex = 15;
            this.organiserEditButton.Text = "Edit";
            this.organiserEditButton.UseVisualStyleBackColor = true;
            this.organiserEditButton.Visible = false;
            this.organiserEditButton.Click += new System.EventHandler(this.organiserEditButton_Click);
            // 
            // organiserCancel
            // 
            this.organiserCancel.Location = new System.Drawing.Point(665, 557);
            this.organiserCancel.Name = "organiserCancel";
            this.organiserCancel.Size = new System.Drawing.Size(90, 30);
            this.organiserCancel.TabIndex = 16;
            this.organiserCancel.Text = "Cancel";
            this.organiserCancel.UseVisualStyleBackColor = true;
            this.organiserCancel.Visible = false;
            this.organiserCancel.Click += new System.EventHandler(this.organiserCancel_Click);
            // 
            // leaveBtn
            // 
            this.leaveBtn.Location = new System.Drawing.Point(590, 557);
            this.leaveBtn.Name = "leaveBtn";
            this.leaveBtn.Size = new System.Drawing.Size(90, 30);
            this.leaveBtn.TabIndex = 17;
            this.leaveBtn.Text = "Leave";
            this.leaveBtn.UseVisualStyleBackColor = true;
            this.leaveBtn.Visible = false;
            this.leaveBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.leaveBtn_MouseClick);
            // 
            // announcementList1
            // 
            this.announcementList1.GridLines = true;
            this.announcementList1.Location = new System.Drawing.Point(13, 50);
            this.announcementList1.Name = "announcementList1";
            this.announcementList1.Size = new System.Drawing.Size(742, 97);
            this.announcementList1.TabIndex = 18;
            this.announcementList1.UseCompatibleStateImageBehavior = false;
            this.announcementList1.View = System.Windows.Forms.View.Details;
            // 
            // statuslabel1
            // 
            this.statuslabel1.AutoSize = true;
            this.statuslabel1.Location = new System.Drawing.Point(267, 12);
            this.statuslabel1.Name = "statuslabel1";
            this.statuslabel1.Size = new System.Drawing.Size(38, 13);
            this.statuslabel1.TabIndex = 19;
            this.statuslabel1.Text = "label1";
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(769, 598);
            this.Controls.Add(this.statuslabel1);
            this.Controls.Add(this.announcementList1);
            this.Controls.Add(this.leaveBtn);
            this.Controls.Add(this.organiserCancel);
            this.Controls.Add(this.organiserEditButton);
            this.Controls.Add(this.searchEventButton);
            this.Controls.Add(this.searchEventTextBox);
            this.Controls.Add(this.searchEventDateTimePicker);
            this.Controls.Add(this.cancelEditButton);
            this.Controls.Add(this.eventCatComboBox);
            this.Controls.Add(this.listMainEventView);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.registerEvent);
            this.Controls.Add(this.getEventInfoButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listSideEventView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainPage_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listSideEventView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registerEvent;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ListView listMainEventView;
        private System.Windows.Forms.Button getEventInfoButton;
        private System.Windows.Forms.ComboBox eventCatComboBox;
        private System.Windows.Forms.Button cancelEditButton;
        private System.Windows.Forms.DateTimePicker searchEventDateTimePicker;
        private System.Windows.Forms.TextBox searchEventTextBox;
        private System.Windows.Forms.Button searchEventButton;
        private System.Windows.Forms.Button organiserEditButton;
        private System.Windows.Forms.Button organiserCancel;
        private System.Windows.Forms.Button leaveBtn;
        private System.Windows.Forms.ListView announcementList1;
        private System.Windows.Forms.Label statuslabel1;

    }
}