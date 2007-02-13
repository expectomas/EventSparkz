namespace _2103Project.UI
{
    partial class EventInfo
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
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblOrganizer = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblParticipants = new System.Windows.Forms.Label();
            this.lblNoOfParticpants = new System.Windows.Forms.Label();
            this.tableInfo = new System.Windows.Forms.DataGridView();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnFacilitate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.linkOrganizerName = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tableInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Futura Md", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(12, 9);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(207, 31);
            this.lblEventName.TabIndex = 0;
            this.lblEventName.Text = "ETHAN&YINXING ";
            // 
            // lblOrganizer
            // 
            this.lblOrganizer.AutoSize = true;
            this.lblOrganizer.Font = new System.Drawing.Font("Futura Lt", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrganizer.Location = new System.Drawing.Point(400, 17);
            this.lblOrganizer.Name = "lblOrganizer";
            this.lblOrganizer.Size = new System.Drawing.Size(62, 16);
            this.lblOrganizer.TabIndex = 1;
            this.lblOrganizer.Text = "Organizer:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Futura Lt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(13, 53);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 20);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(62, 54);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(96, 18);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "XX/XX/XXXX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Futura Lt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(164, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "TO";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(199, 54);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(96, 18);
            this.lblEndDate.TabIndex = 6;
            this.lblEndDate.Text = "XX/XX/XXXX";
            // 
            // lblParticipants
            // 
            this.lblParticipants.AutoSize = true;
            this.lblParticipants.Font = new System.Drawing.Font("Futura Lt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipants.Location = new System.Drawing.Point(13, 92);
            this.lblParticipants.Name = "lblParticipants";
            this.lblParticipants.Size = new System.Drawing.Size(136, 20);
            this.lblParticipants.TabIndex = 7;
            this.lblParticipants.Text = "No. Of Participants:";
            // 
            // lblNoOfParticpants
            // 
            this.lblNoOfParticpants.AutoSize = true;
            this.lblNoOfParticpants.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfParticpants.Location = new System.Drawing.Point(155, 94);
            this.lblNoOfParticpants.Name = "lblNoOfParticpants";
            this.lblNoOfParticpants.Size = new System.Drawing.Size(16, 18);
            this.lblNoOfParticpants.TabIndex = 8;
            this.lblNoOfParticpants.Text = "2";
            // 
            // tableInfo
            // 
            this.tableInfo.AllowUserToAddRows = false;
            this.tableInfo.AllowUserToDeleteRows = false;
            this.tableInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableInfo.Location = new System.Drawing.Point(12, 126);
            this.tableInfo.Name = "tableInfo";
            this.tableInfo.ReadOnly = true;
            this.tableInfo.Size = new System.Drawing.Size(510, 249);
            this.tableInfo.TabIndex = 9;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(65, 392);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(85, 35);
            this.btnRegister.TabIndex = 17;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnFacilitate
            // 
            this.btnFacilitate.Location = new System.Drawing.Point(228, 392);
            this.btnFacilitate.Name = "btnFacilitate";
            this.btnFacilitate.Size = new System.Drawing.Size(85, 35);
            this.btnFacilitate.TabIndex = 18;
            this.btnFacilitate.Text = "Facilitate";
            this.btnFacilitate.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(388, 392);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 35);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // linkOrganizerName
            // 
            this.linkOrganizerName.AutoSize = true;
            this.linkOrganizerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkOrganizerName.Location = new System.Drawing.Point(468, 18);
            this.linkOrganizerName.Name = "linkOrganizerName";
            this.linkOrganizerName.Size = new System.Drawing.Size(49, 15);
            this.linkOrganizerName.TabIndex = 20;
            this.linkOrganizerName.TabStop = true;
            this.linkOrganizerName.Text = "YinXing";
            // 
            // EventInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 439);
            this.Controls.Add(this.linkOrganizerName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFacilitate);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.tableInfo);
            this.Controls.Add(this.lblNoOfParticpants);
            this.Controls.Add(this.lblParticipants);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblOrganizer);
            this.Controls.Add(this.lblEventName);
            this.Name = "EventInfo";
            this.Text = "EventInfo";
            ((System.ComponentModel.ISupportInitialize)(this.tableInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblOrganizer;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblParticipants;
        private System.Windows.Forms.Label lblNoOfParticpants;
        private System.Windows.Forms.DataGridView tableInfo;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnFacilitate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.LinkLabel linkOrganizerName;
    }
}