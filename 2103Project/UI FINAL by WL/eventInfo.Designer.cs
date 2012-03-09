﻿namespace _2103Project
{
    partial class eventInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eventInfoForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.labelc = new System.Windows.Forms.Label();
            this.labela = new System.Windows.Forms.Label();
            this.labelb = new System.Windows.Forms.Label();
            this.scheduleLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.venueLabel = new System.Windows.Forms.Label();
            this.organiserLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFacilitate = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.noOfParticipantLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe WP Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(179, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(94, 21);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Event Title";
            // 
            // labelc
            // 
            this.labelc.AutoSize = true;
            this.labelc.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelc.Location = new System.Drawing.Point(33, 82);
            this.labelc.Name = "labelc";
            this.labelc.Size = new System.Drawing.Size(106, 21);
            this.labelc.TabIndex = 6;
            this.labelc.Text = "Organized By:";
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labela.Location = new System.Drawing.Point(33, 38);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(45, 21);
            this.labela.TabIndex = 7;
            this.labela.Text = "Date:";
            // 
            // labelb
            // 
            this.labelb.AutoSize = true;
            this.labelb.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelb.Location = new System.Drawing.Point(33, 60);
            this.labelb.Name = "labelb";
            this.labelb.Size = new System.Drawing.Size(56, 21);
            this.labelb.TabIndex = 8;
            this.labelb.Text = "Venue:";
            // 
            // scheduleLabel
            // 
            this.scheduleLabel.AutoSize = true;
            this.scheduleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleLabel.Location = new System.Drawing.Point(191, 126);
            this.scheduleLabel.Name = "scheduleLabel";
            this.scheduleLabel.Size = new System.Drawing.Size(73, 21);
            this.scheduleLabel.TabIndex = 9;
            this.scheduleLabel.Text = "Schedule";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(202, 38);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(49, 21);
            this.dateLabel.TabIndex = 10;
            this.dateLabel.Text = "label1";
            // 
            // venueLabel
            // 
            this.venueLabel.AutoSize = true;
            this.venueLabel.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venueLabel.Location = new System.Drawing.Point(202, 60);
            this.venueLabel.Name = "venueLabel";
            this.venueLabel.Size = new System.Drawing.Size(52, 21);
            this.venueLabel.TabIndex = 11;
            this.venueLabel.Text = "label2";
            // 
            // organiserLabel
            // 
            this.organiserLabel.AutoSize = true;
            this.organiserLabel.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organiserLabel.Location = new System.Drawing.Point(202, 82);
            this.organiserLabel.Name = "organiserLabel";
            this.organiserLabel.Size = new System.Drawing.Size(52, 21);
            this.organiserLabel.TabIndex = 12;
            this.organiserLabel.Text = "label3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Description,
            this.Venue});
            this.dataGridView1.Location = new System.Drawing.Point(12, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(470, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 225;
            // 
            // Venue
            // 
            this.Venue.HeaderText = "Venue";
            this.Venue.Name = "Venue";
            this.Venue.ReadOnly = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(321, 305);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 37);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnFacilitate
            // 
            this.btnFacilitate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacilitate.Location = new System.Drawing.Point(165, 305);
            this.btnFacilitate.Name = "btnFacilitate";
            this.btnFacilitate.Size = new System.Drawing.Size(123, 37);
            this.btnFacilitate.TabIndex = 21;
            this.btnFacilitate.Text = "Facilitate";
            this.btnFacilitate.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(31, 305);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(108, 37);
            this.btnRegister.TabIndex = 20;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // noOfParticipantLabel
            // 
            this.noOfParticipantLabel.AutoSize = true;
            this.noOfParticipantLabel.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfParticipantLabel.Location = new System.Drawing.Point(202, 103);
            this.noOfParticipantLabel.Name = "noOfParticipantLabel";
            this.noOfParticipantLabel.Size = new System.Drawing.Size(52, 21);
            this.noOfParticipantLabel.TabIndex = 24;
            this.noOfParticipantLabel.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "No. of Participant:";
            // 
            // eventInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(496, 351);
            this.Controls.Add(this.noOfParticipantLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFacilitate);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.organiserLabel);
            this.Controls.Add(this.venueLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.scheduleLabel);
            this.Controls.Add(this.labelb);
            this.Controls.Add(this.labela);
            this.Controls.Add(this.labelc);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "eventInfoForm";
            this.Text = "Event Info";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label labelc;
        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.Label labelb;
        private System.Windows.Forms.Label scheduleLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label venueLabel;
        private System.Windows.Forms.Label organiserLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venue;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFacilitate;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label noOfParticipantLabel;
        private System.Windows.Forms.Label label5;

    }
}