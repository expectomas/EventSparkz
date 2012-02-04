namespace _2103Project
{
    partial class venuePageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(venuePageForm));
            this.venueInfoListView = new System.Windows.Forms.ListView();
            this.venueComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bookVenueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // venueInfoListView
            // 
            this.venueInfoListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venueInfoListView.Location = new System.Drawing.Point(12, 68);
            this.venueInfoListView.Name = "venueInfoListView";
            this.venueInfoListView.Size = new System.Drawing.Size(257, 189);
            this.venueInfoListView.TabIndex = 0;
            this.venueInfoListView.UseCompatibleStateImageBehavior = false;
            // 
            // venueComboBox
            // 
            this.venueComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venueComboBox.FormattingEnabled = true;
            this.venueComboBox.Location = new System.Drawing.Point(12, 33);
            this.venueComboBox.Name = "venueComboBox";
            this.venueComboBox.Size = new System.Drawing.Size(257, 29);
            this.venueComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select venue:";
            // 
            // bookVenueButton
            // 
            this.bookVenueButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookVenueButton.Location = new System.Drawing.Point(12, 263);
            this.bookVenueButton.Name = "bookVenueButton";
            this.bookVenueButton.Size = new System.Drawing.Size(151, 34);
            this.bookVenueButton.TabIndex = 3;
            this.bookVenueButton.Text = "Book this Venue";
            this.bookVenueButton.UseVisualStyleBackColor = true;
            // 
            // venuePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(282, 302);
            this.Controls.Add(this.bookVenueButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.venueComboBox);
            this.Controls.Add(this.venueInfoListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "venuePageForm";
            this.Text = "Venue Page";
            this.Load += new System.EventHandler(this.venuePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView venueInfoListView;
        private System.Windows.Forms.ComboBox venueComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bookVenueButton;
    }
}