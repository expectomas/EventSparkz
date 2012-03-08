namespace _2103Project.UI
{
    partial class MainPage
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblEventsFor = new System.Windows.Forms.Label();
            this.lblMyEvents = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnViewEvent = new System.Windows.Forms.Button();
            this.lbViewEventListing = new System.Windows.Forms.ListBox();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbMyEvents = new System.Windows.Forms.ListBox();
            this.ddlRole = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Futura Md", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(288, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(166, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "EventSparkZ";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(122, 15);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 4;
            // 
            // lblEventsFor
            // 
            this.lblEventsFor.AutoSize = true;
            this.lblEventsFor.Font = new System.Drawing.Font("Futura Md", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventsFor.Location = new System.Drawing.Point(6, 10);
            this.lblEventsFor.Name = "lblEventsFor";
            this.lblEventsFor.Size = new System.Drawing.Size(105, 25);
            this.lblEventsFor.TabIndex = 4;
            this.lblEventsFor.Text = "Events For";
            // 
            // lblMyEvents
            // 
            this.lblMyEvents.AutoSize = true;
            this.lblMyEvents.BackColor = System.Drawing.Color.Transparent;
            this.lblMyEvents.Font = new System.Drawing.Font("Futura Md", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyEvents.Location = new System.Drawing.Point(6, 10);
            this.lblMyEvents.Name = "lblMyEvents";
            this.lblMyEvents.Size = new System.Drawing.Size(103, 25);
            this.lblMyEvents.TabIndex = 4;
            this.lblMyEvents.Text = "My Events";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(647, 9);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.lblEventsFor);
            this.groupBox1.Location = new System.Drawing.Point(154, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 40);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMyEvents);
            this.groupBox2.Location = new System.Drawing.Point(488, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 38);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnViewEvent);
            this.groupBox3.Controls.Add(this.lbViewEventListing);
            this.groupBox3.Controls.Add(this.btnCreateEvent);
            this.groupBox3.Controls.Add(this.tbSearch);
            this.groupBox3.Location = new System.Drawing.Point(3, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(479, 353);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // btnViewEvent
            // 
            this.btnViewEvent.Location = new System.Drawing.Point(321, 312);
            this.btnViewEvent.Name = "btnViewEvent";
            this.btnViewEvent.Size = new System.Drawing.Size(85, 35);
            this.btnViewEvent.TabIndex = 12;
            this.btnViewEvent.Text = "View Event";
            this.btnViewEvent.UseVisualStyleBackColor = true;
            // 
            // lbViewEventListing
            // 
            this.lbViewEventListing.BackColor = System.Drawing.Color.White;
            this.lbViewEventListing.FormattingEnabled = true;
            this.lbViewEventListing.Location = new System.Drawing.Point(8, 37);
            this.lbViewEventListing.Name = "lbViewEventListing";
            this.lbViewEventListing.Size = new System.Drawing.Size(465, 264);
            this.lbViewEventListing.TabIndex = 9;
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(81, 312);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(85, 35);
            this.btnCreateEvent.TabIndex = 11;
            this.btnCreateEvent.Text = "Create Event";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.White;
            this.tbSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbSearch.Location = new System.Drawing.Point(9, 14);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(464, 20);
            this.tbSearch.TabIndex = 10;
            this.tbSearch.Text = "Enter an Event\'s Name...";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.lbMyEvents);
            this.groupBox4.Controls.Add(this.ddlRole);
            this.groupBox4.Location = new System.Drawing.Point(483, 79);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(239, 354);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(79, 313);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 35);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lbMyEvents
            // 
            this.lbMyEvents.BackColor = System.Drawing.Color.White;
            this.lbMyEvents.FormattingEnabled = true;
            this.lbMyEvents.Location = new System.Drawing.Point(6, 38);
            this.lbMyEvents.Name = "lbMyEvents";
            this.lbMyEvents.Size = new System.Drawing.Size(228, 264);
            this.lbMyEvents.TabIndex = 11;
            // 
            // ddlRole
            // 
            this.ddlRole.FormattingEnabled = true;
            this.ddlRole.Location = new System.Drawing.Point(6, 15);
            this.ddlRole.Name = "ddlRole";
            this.ddlRole.Size = new System.Drawing.Size(228, 21);
            this.ddlRole.TabIndex = 10;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 439);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblEventsFor;
        private System.Windows.Forms.Label lblMyEvents;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnViewEvent;
        private System.Windows.Forms.ListBox lbViewEventListing;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbMyEvents;
        private System.Windows.Forms.ComboBox ddlRole;


    }
}