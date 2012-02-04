namespace _2103Project
{
    partial class adminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
            this.eventListBox = new System.Windows.Forms.ListBox();
            this.eventInfoButton = new System.Windows.Forms.Button();
            this.approveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.venueInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eventListBox
            // 
            this.eventListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventListBox.FormattingEnabled = true;
            this.eventListBox.ItemHeight = 17;
            this.eventListBox.Location = new System.Drawing.Point(12, 99);
            this.eventListBox.Name = "eventListBox";
            this.eventListBox.Size = new System.Drawing.Size(326, 123);
            this.eventListBox.TabIndex = 0;
            // 
            // eventInfoButton
            // 
            this.eventInfoButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventInfoButton.Location = new System.Drawing.Point(13, 227);
            this.eventInfoButton.Name = "eventInfoButton";
            this.eventInfoButton.Size = new System.Drawing.Size(107, 55);
            this.eventInfoButton.TabIndex = 1;
            this.eventInfoButton.Text = "Get Selected Event Info";
            this.eventInfoButton.UseVisualStyleBackColor = true;
            // 
            // approveButton
            // 
            this.approveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approveButton.Location = new System.Drawing.Point(236, 228);
            this.approveButton.Name = "approveButton";
            this.approveButton.Size = new System.Drawing.Size(103, 54);
            this.approveButton.TabIndex = 2;
            this.approveButton.Text = "Approve Selected event";
            this.approveButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome, Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "List of event here";
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(264, 4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 31);
            this.logoutButton.TabIndex = 10;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // venueInfoButton
            // 
            this.venueInfoButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venueInfoButton.Location = new System.Drawing.Point(126, 228);
            this.venueInfoButton.Name = "venueInfoButton";
            this.venueInfoButton.Size = new System.Drawing.Size(104, 54);
            this.venueInfoButton.TabIndex = 11;
            this.venueInfoButton.Text = "Get Venue Info";
            this.venueInfoButton.UseVisualStyleBackColor = true;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(351, 289);
            this.Controls.Add(this.venueInfoButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.approveButton);
            this.Controls.Add(this.eventInfoButton);
            this.Controls.Add(this.eventListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminForm";
            this.Text = "Welcome (Admin)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox eventListBox;
        private System.Windows.Forms.Button eventInfoButton;
        private System.Windows.Forms.Button approveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button venueInfoButton;
    }
}