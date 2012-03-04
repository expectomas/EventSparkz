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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createEventForm));
            this.label1 = new System.Windows.Forms.Label();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.importFileButton = new System.Windows.Forms.Button();
            this.opentxtFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.createButton = new System.Windows.Forms.Button();
            this.venueComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fileDirectoryLabel = new System.Windows.Forms.Label();
            this.budgetLimitTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name:";
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameTextBox.Location = new System.Drawing.Point(17, 37);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(279, 29);
            this.eventNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Venue:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description: (Import from txt file)";
            // 
            // importFileButton
            // 
            this.importFileButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importFileButton.Location = new System.Drawing.Point(17, 269);
            this.importFileButton.Name = "importFileButton";
            this.importFileButton.Size = new System.Drawing.Size(114, 37);
            this.importFileButton.TabIndex = 7;
            this.importFileButton.Text = "Import .txt file";
            this.importFileButton.UseVisualStyleBackColor = true;
            this.importFileButton.Click += new System.EventHandler(this.importFileButton_Click);
            // 
            // opentxtFileDialog
            // 
            this.opentxtFileDialog.FileName = "openFileDialog1";
            this.opentxtFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.opentxtFileDialog_FileOk);
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(18, 312);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(279, 37);
            this.createButton.TabIndex = 8;
            this.createButton.Text = "Create an Event";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // venueComboBox
            // 
            this.venueComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.venueComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venueComboBox.FormattingEnabled = true;
            this.venueComboBox.Items.AddRange(new object[] {
            "Yusof Ishak House",
            "Multi-Purpose Sports Hall",
            "Town Plaza Auditorium",
            "Engineering Auditorium"});
            this.venueComboBox.Location = new System.Drawing.Point(16, 149);
            this.venueComboBox.Name = "venueComboBox";
            this.venueComboBox.Size = new System.Drawing.Size(280, 29);
            this.venueComboBox.TabIndex = 9;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd/MMM/yyyy hh:mm:00 tt";
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(17, 93);
            this.dateTimePicker.MinDate = new System.DateTime(2012, 2, 12, 21, 26, 45, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(279, 29);
            this.dateTimePicker.TabIndex = 10;
            this.dateTimePicker.Value = new System.DateTime(2012, 2, 12, 21, 26, 45, 0);
            // 
            // fileDirectoryLabel
            // 
            this.fileDirectoryLabel.AutoSize = true;
            this.fileDirectoryLabel.Location = new System.Drawing.Point(138, 280);
            this.fileDirectoryLabel.Name = "fileDirectoryLabel";
            this.fileDirectoryLabel.Size = new System.Drawing.Size(102, 13);
            this.fileDirectoryLabel.TabIndex = 11;
            this.fileDirectoryLabel.Text = "Import your file here.";
            // 
            // budgetLimitTextBox
            // 
            this.budgetLimitTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetLimitTextBox.Location = new System.Drawing.Point(18, 205);
            this.budgetLimitTextBox.Name = "budgetLimitTextBox";
            this.budgetLimitTextBox.Size = new System.Drawing.Size(279, 29);
            this.budgetLimitTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Budget Limit:";
            // 
            // kryptonManager1
            // 
            // 
            // createEventForm
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(308, 359);
            this.Controls.Add(this.budgetLimitTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fileDirectoryLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.venueComboBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.importFileButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventNameTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "createEventForm";
            this.Text = "Create Event";
            this.Load += new System.EventHandler(this.createEventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button importFileButton;
        private System.Windows.Forms.OpenFileDialog opentxtFileDialog;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.ComboBox venueComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label fileDirectoryLabel;
        private System.Windows.Forms.TextBox budgetLimitTextBox;
        private System.Windows.Forms.Label label5;
       
    }
}