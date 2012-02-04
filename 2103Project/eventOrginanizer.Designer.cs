namespace _2103Project
{
    partial class eventOrginanizerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eventOrginanizerForm));
            this.logoutButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.createEventButton = new System.Windows.Forms.Button();
            this.cancelEventButton = new System.Windows.Forms.Button();
            this.budgetButton = new System.Windows.Forms.Button();
            this.eventInfoButton = new System.Windows.Forms.Button();
            this.viewBookVenueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(171, 139);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(154, 40);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(140, 30);
            this.welcomeLabel.TabIndex = 10;
            this.welcomeLabel.Text = "Welcome,.....";
            // 
            // createEventButton
            // 
            this.createEventButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createEventButton.Location = new System.Drawing.Point(12, 47);
            this.createEventButton.Name = "createEventButton";
            this.createEventButton.Size = new System.Drawing.Size(154, 40);
            this.createEventButton.TabIndex = 11;
            this.createEventButton.Text = "Create Event";
            this.createEventButton.UseVisualStyleBackColor = true;
            // 
            // cancelEventButton
            // 
            this.cancelEventButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelEventButton.Location = new System.Drawing.Point(11, 93);
            this.cancelEventButton.Name = "cancelEventButton";
            this.cancelEventButton.Size = new System.Drawing.Size(154, 40);
            this.cancelEventButton.TabIndex = 12;
            this.cancelEventButton.Text = "Cancel Event";
            this.cancelEventButton.UseVisualStyleBackColor = true;
            // 
            // budgetButton
            // 
            this.budgetButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetButton.Location = new System.Drawing.Point(171, 93);
            this.budgetButton.Name = "budgetButton";
            this.budgetButton.Size = new System.Drawing.Size(154, 40);
            this.budgetButton.TabIndex = 13;
            this.budgetButton.Text = "View Budget";
            this.budgetButton.UseVisualStyleBackColor = true;
            // 
            // eventInfoButton
            // 
            this.eventInfoButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventInfoButton.Location = new System.Drawing.Point(11, 139);
            this.eventInfoButton.Name = "eventInfoButton";
            this.eventInfoButton.Size = new System.Drawing.Size(154, 40);
            this.eventInfoButton.TabIndex = 14;
            this.eventInfoButton.Text = "View Event Info";
            this.eventInfoButton.UseVisualStyleBackColor = true;
            // 
            // viewBookVenueButton
            // 
            this.viewBookVenueButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBookVenueButton.Location = new System.Drawing.Point(171, 47);
            this.viewBookVenueButton.Name = "viewBookVenueButton";
            this.viewBookVenueButton.Size = new System.Drawing.Size(154, 40);
            this.viewBookVenueButton.TabIndex = 15;
            this.viewBookVenueButton.Text = "Edit Budget";
            this.viewBookVenueButton.UseVisualStyleBackColor = true;
            // 
            // eventOrginanizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(342, 229);
            this.Controls.Add(this.viewBookVenueButton);
            this.Controls.Add(this.eventInfoButton);
            this.Controls.Add(this.budgetButton);
            this.Controls.Add(this.cancelEventButton);
            this.Controls.Add(this.createEventButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.logoutButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "eventOrginanizerForm";
            this.Text = "Welcome (Organizer Page)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button createEventButton;
        private System.Windows.Forms.Button cancelEventButton;
        private System.Windows.Forms.Button budgetButton;
        private System.Windows.Forms.Button eventInfoButton;
        private System.Windows.Forms.Button viewBookVenueButton;
    }
}