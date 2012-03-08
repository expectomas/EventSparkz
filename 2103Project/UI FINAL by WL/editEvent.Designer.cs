namespace _2103Project
{
    partial class editEventForm
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
            this.scheduleListView = new System.Windows.Forms.ListView();
            this.editScheduleButton = new System.Windows.Forms.Button();
            this.editBudgetButton = new System.Windows.Forms.Button();
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scheduleListView
            // 
            this.scheduleListView.Location = new System.Drawing.Point(12, 65);
            this.scheduleListView.Name = "scheduleListView";
            this.scheduleListView.Size = new System.Drawing.Size(358, 216);
            this.scheduleListView.TabIndex = 0;
            this.scheduleListView.UseCompatibleStateImageBehavior = false;
            // 
            // editScheduleButton
            // 
            this.editScheduleButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editScheduleButton.Location = new System.Drawing.Point(42, 287);
            this.editScheduleButton.Name = "editScheduleButton";
            this.editScheduleButton.Size = new System.Drawing.Size(133, 30);
            this.editScheduleButton.TabIndex = 7;
            this.editScheduleButton.Text = "Edit Schedule";
            this.editScheduleButton.UseVisualStyleBackColor = true;
            // 
            // editBudgetButton
            // 
            this.editBudgetButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBudgetButton.Location = new System.Drawing.Point(206, 287);
            this.editBudgetButton.Name = "editBudgetButton";
            this.editBudgetButton.Size = new System.Drawing.Size(133, 30);
            this.editBudgetButton.TabIndex = 8;
            this.editBudgetButton.Text = "Edit Budget";
            this.editBudgetButton.UseVisualStyleBackColor = true;
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameLabel.Location = new System.Drawing.Point(97, 18);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(175, 30);
            this.eventNameLabel.TabIndex = 9;
            this.eventNameLabel.Text = "Your Event Name";
            // 
            // editEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(382, 322);
            this.Controls.Add(this.eventNameLabel);
            this.Controls.Add(this.editBudgetButton);
            this.Controls.Add(this.editScheduleButton);
            this.Controls.Add(this.scheduleListView);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "editEventForm";
            this.Text = "Edit Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView scheduleListView;
        private System.Windows.Forms.Button editScheduleButton;
        private System.Windows.Forms.Button editBudgetButton;
        private System.Windows.Forms.Label eventNameLabel;

    }
}