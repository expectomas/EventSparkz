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
            this.listView2 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.registerEvent = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.getEventInfoButton = new System.Windows.Forms.Button();
            this.eventCatComboBox = new System.Windows.Forms.ComboBox();
            this.cancelEditButton = new System.Windows.Forms.Button();
            this.searchEventDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchEventTextBox = new System.Windows.Forms.TextBox();
            this.searchEventButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe WP", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(14, 44);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(66, 17);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Event For:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe WP Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome to ~EventSparkZ~";
            // 
            // listView2
            // 
            this.listView2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.Location = new System.Drawing.Point(285, 127);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(187, 177);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe WP", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "My Event:";
            // 
            // registerEvent
            // 
            this.registerEvent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerEvent.Location = new System.Drawing.Point(17, 310);
            this.registerEvent.Name = "registerEvent";
            this.registerEvent.Size = new System.Drawing.Size(123, 30);
            this.registerEvent.TabIndex = 7;
            this.registerEvent.Text = "Create Event";
            this.registerEvent.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(397, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 30);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(17, 127);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(262, 177);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // getEventInfoButton
            // 
            this.getEventInfoButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getEventInfoButton.Location = new System.Drawing.Point(146, 310);
            this.getEventInfoButton.Name = "getEventInfoButton";
            this.getEventInfoButton.Size = new System.Drawing.Size(133, 30);
            this.getEventInfoButton.TabIndex = 6;
            this.getEventInfoButton.Text = "Get Event Info";
            this.getEventInfoButton.UseVisualStyleBackColor = true;
            // 
            // eventCatComboBox
            // 
            this.eventCatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventCatComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventCatComboBox.FormattingEnabled = true;
            this.eventCatComboBox.Items.AddRange(new object[] {
            "Registered Event",
            "Created Event",
            "Facilitator List"});
            this.eventCatComboBox.Location = new System.Drawing.Point(286, 92);
            this.eventCatComboBox.Name = "eventCatComboBox";
            this.eventCatComboBox.Size = new System.Drawing.Size(186, 29);
            this.eventCatComboBox.TabIndex = 10;
            // 
            // cancelEditButton
            // 
            this.cancelEditButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelEditButton.Location = new System.Drawing.Point(310, 310);
            this.cancelEditButton.Name = "cancelEditButton";
            this.cancelEditButton.Size = new System.Drawing.Size(133, 30);
            this.cancelEditButton.TabIndex = 11;
            this.cancelEditButton.Text = "Cancel";
            this.cancelEditButton.UseVisualStyleBackColor = true;
            // 
            // searchEventDateTimePicker
            // 
            this.searchEventDateTimePicker.Location = new System.Drawing.Point(17, 63);
            this.searchEventDateTimePicker.Name = "searchEventDateTimePicker";
            this.searchEventDateTimePicker.Size = new System.Drawing.Size(208, 22);
            this.searchEventDateTimePicker.TabIndex = 12;
            // 
            // searchEventTextBox
            // 
            this.searchEventTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEventTextBox.Location = new System.Drawing.Point(17, 92);
            this.searchEventTextBox.Name = "searchEventTextBox";
            this.searchEventTextBox.Size = new System.Drawing.Size(208, 29);
            this.searchEventTextBox.TabIndex = 13;
            this.searchEventTextBox.Text = "Search Your Event Here";
            // 
            // searchEventButton
            // 
            this.searchEventButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEventButton.Location = new System.Drawing.Point(231, 92);
            this.searchEventButton.Name = "searchEventButton";
            this.searchEventButton.Size = new System.Drawing.Size(48, 30);
            this.searchEventButton.TabIndex = 14;
            this.searchEventButton.Text = "Find";
            this.searchEventButton.UseVisualStyleBackColor = true;
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(484, 342);
            this.Controls.Add(this.searchEventButton);
            this.Controls.Add(this.searchEventTextBox);
            this.Controls.Add(this.searchEventDateTimePicker);
            this.Controls.Add(this.cancelEditButton);
            this.Controls.Add(this.eventCatComboBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.registerEvent);
            this.Controls.Add(this.getEventInfoButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainPage";
            this.Text = "Main Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registerEvent;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button getEventInfoButton;
        private System.Windows.Forms.ComboBox eventCatComboBox;
        private System.Windows.Forms.Button cancelEditButton;
        private System.Windows.Forms.DateTimePicker searchEventDateTimePicker;
        private System.Windows.Forms.TextBox searchEventTextBox;
        private System.Windows.Forms.Button searchEventButton;

    }
}