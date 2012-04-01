namespace _2103Project
{
    partial class updateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateForm));
            this.venueTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.editItemButton = new System.Windows.Forms.Button();
            this.venComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.participantTextbox = new System.Windows.Forms.TextBox();
            this.organiserTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.scheduleLabel = new System.Windows.Forms.Label();
            this.labelb = new System.Windows.Forms.Label();
            this.labela = new System.Windows.Forms.Label();
            this.labelc = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.deleteItem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.venueListBox = new System.Windows.Forms.ListBox();
            this.descriptionListBox = new System.Windows.Forms.ListBox();
            this.timeListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.editBudgetButton = new System.Windows.Forms.Button();
            this.dateCombobox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // venueTextBox
            // 
            this.venueTextBox.Enabled = false;
            this.venueTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venueTextBox.Location = new System.Drawing.Point(163, 66);
            this.venueTextBox.Name = "venueTextBox";
            this.venueTextBox.Size = new System.Drawing.Size(279, 25);
            this.venueTextBox.TabIndex = 81;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(362, 374);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(108, 37);
            this.saveButton.TabIndex = 80;
            this.saveButton.Text = "Save Change";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // editItemButton
            // 
            this.editItemButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editItemButton.Location = new System.Drawing.Point(128, 374);
            this.editItemButton.Name = "editItemButton";
            this.editItemButton.Size = new System.Drawing.Size(90, 37);
            this.editItemButton.TabIndex = 79;
            this.editItemButton.Text = "Edit Schedule";
            this.editItemButton.UseVisualStyleBackColor = true;
            this.editItemButton.Click += new System.EventHandler(this.editItemButton_Click);
            // 
            // venComboBox
            // 
            this.venComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.venComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venComboBox.FormattingEnabled = true;
            this.venComboBox.Items.AddRange(new object[] {
            "MPSH1",
            "MPSH2",
            "MPSH3",
            "MPSH4",
            "MPSH5",
            "MPSH6"});
            this.venComboBox.Location = new System.Drawing.Point(345, 173);
            this.venComboBox.Name = "venComboBox";
            this.venComboBox.Size = new System.Drawing.Size(120, 29);
            this.venComboBox.TabIndex = 78;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(137, 173);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(202, 29);
            this.descriptionTextBox.TabIndex = 77;
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
            "12:00 PM.",
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
            this.timeComboBox.Location = new System.Drawing.Point(11, 173);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(120, 29);
            this.timeComboBox.TabIndex = 76;
            // 
            // participantTextbox
            // 
            this.participantTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participantTextbox.Location = new System.Drawing.Point(163, 119);
            this.participantTextbox.Name = "participantTextbox";
            this.participantTextbox.Size = new System.Drawing.Size(279, 25);
            this.participantTextbox.TabIndex = 75;
            this.participantTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.participantTextbox_KeyDown);
            this.participantTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.participantTextbox_KeyPress);
            // 
            // organiserTextBox
            // 
            this.organiserTextBox.Enabled = false;
            this.organiserTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organiserTextBox.Location = new System.Drawing.Point(163, 93);
            this.organiserTextBox.Name = "organiserTextBox";
            this.organiserTextBox.Size = new System.Drawing.Size(279, 25);
            this.organiserTextBox.TabIndex = 74;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Enabled = false;
            this.dateTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTextBox.Location = new System.Drawing.Point(163, 39);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(279, 25);
            this.dateTextBox.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "No. of Participant:";
            // 
            // scheduleLabel
            // 
            this.scheduleLabel.AutoSize = true;
            this.scheduleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleLabel.Location = new System.Drawing.Point(192, -26);
            this.scheduleLabel.Name = "scheduleLabel";
            this.scheduleLabel.Size = new System.Drawing.Size(73, 21);
            this.scheduleLabel.TabIndex = 65;
            this.scheduleLabel.Text = "Schedule";
            // 
            // labelb
            // 
            this.labelb.AutoSize = true;
            this.labelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelb.Location = new System.Drawing.Point(30, 66);
            this.labelb.Name = "labelb";
            this.labelb.Size = new System.Drawing.Size(60, 20);
            this.labelb.TabIndex = 64;
            this.labelb.Text = "Venue:";
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labela.Location = new System.Drawing.Point(30, 39);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(48, 20);
            this.labela.TabIndex = 63;
            this.labela.Text = "Date:";
            // 
            // labelc
            // 
            this.labelc.AutoSize = true;
            this.labelc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelc.Location = new System.Drawing.Point(30, 93);
            this.labelc.Name = "labelc";
            this.labelc.Size = new System.Drawing.Size(108, 20);
            this.labelc.TabIndex = 62;
            this.labelc.Text = "Organized By:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(109, 24);
            this.titleLabel.TabIndex = 61;
            this.titleLabel.Text = "Event Title";
            // 
            // addItemButton
            // 
            this.addItemButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.Location = new System.Drawing.Point(16, 374);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(90, 37);
            this.addItemButton.TabIndex = 82;
            this.addItemButton.Text = "Add Schedule";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // deleteItem
            // 
            this.deleteItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItem.Location = new System.Drawing.Point(244, 374);
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(100, 37);
            this.deleteItem.TabIndex = 83;
            this.deleteItem.Text = "Delete Schedule";
            this.deleteItem.UseVisualStyleBackColor = true;
            this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateCombobox);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.venueListBox);
            this.groupBox1.Controls.Add(this.descriptionListBox);
            this.groupBox1.Controls.Add(this.timeListBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.scheduleLabel);
            this.groupBox1.Controls.Add(this.venComboBox);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(this.timeComboBox);
            this.groupBox1.Location = new System.Drawing.Point(5, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 218);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            // 
            // venueListBox
            // 
            this.venueListBox.FormattingEnabled = true;
            this.venueListBox.Location = new System.Drawing.Point(345, 47);
            this.venueListBox.Name = "venueListBox";
            this.venueListBox.Size = new System.Drawing.Size(120, 121);
            this.venueListBox.TabIndex = 81;
            // 
            // descriptionListBox
            // 
            this.descriptionListBox.FormattingEnabled = true;
            this.descriptionListBox.Location = new System.Drawing.Point(137, 47);
            this.descriptionListBox.Name = "descriptionListBox";
            this.descriptionListBox.Size = new System.Drawing.Size(202, 121);
            this.descriptionListBox.TabIndex = 80;
            // 
            // timeListBox
            // 
            this.timeListBox.FormattingEnabled = true;
            this.timeListBox.Location = new System.Drawing.Point(11, 46);
            this.timeListBox.Name = "timeListBox";
            this.timeListBox.Size = new System.Drawing.Size(120, 121);
            this.timeListBox.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 73;
            this.label3.Text = "Schedule";
            // 
            // editBudgetButton
            // 
            this.editBudgetButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBudgetButton.Location = new System.Drawing.Point(369, 10);
            this.editBudgetButton.Name = "editBudgetButton";
            this.editBudgetButton.Size = new System.Drawing.Size(108, 24);
            this.editBudgetButton.TabIndex = 85;
            this.editBudgetButton.Text = "Edit Budget";
            this.editBudgetButton.UseVisualStyleBackColor = true;
            this.editBudgetButton.Click += new System.EventHandler(this.editBudgetButton_Click);
            // 
            // dateCombobox
            // 
            this.dateCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateCombobox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCombobox.FormattingEnabled = true;
            this.dateCombobox.Location = new System.Drawing.Point(123, 16);
            this.dateCombobox.Name = "dateCombobox";
            this.dateCombobox.Size = new System.Drawing.Size(238, 25);
            this.dateCombobox.TabIndex = 84;
            this.dateCombobox.SelectedIndexChanged += new System.EventHandler(this.dateCombobox_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(72, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 21);
            this.label15.TabIndex = 83;
            this.label15.Text = "Date:";
            // 
            // updateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(489, 435);
            this.Controls.Add(this.editBudgetButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteItem);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.venueTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.editItemButton);
            this.Controls.Add(this.participantTextbox);
            this.Controls.Add(this.organiserTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelb);
            this.Controls.Add(this.labela);
            this.Controls.Add(this.labelc);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "updateForm";
            this.Text = "Update Event";
            this.Load += new System.EventHandler(this.updateForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox venueTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button editItemButton;
        private System.Windows.Forms.ComboBox venComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox timeComboBox;
        private System.Windows.Forms.TextBox participantTextbox;
        private System.Windows.Forms.TextBox organiserTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label scheduleLabel;
        private System.Windows.Forms.Label labelb;
        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.Label labelc;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button deleteItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox venueListBox;
        private System.Windows.Forms.ListBox descriptionListBox;
        private System.Windows.Forms.ListBox timeListBox;
        private System.Windows.Forms.Button editBudgetButton;
        private System.Windows.Forms.ComboBox dateCombobox;
        private System.Windows.Forms.Label label15;
    }
}