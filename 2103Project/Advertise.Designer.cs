namespace _2103Project
{
    partial class Advertise
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
            this.eventLabel1 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.imgFileLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusLbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eventLabel1
            // 
            this.eventLabel1.AutoSize = true;
            this.eventLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLabel1.Location = new System.Drawing.Point(25, 28);
            this.eventLabel1.Name = "eventLabel1";
            this.eventLabel1.Size = new System.Drawing.Size(123, 24);
            this.eventLabel1.TabIndex = 0;
            this.eventLabel1.Text = "eventLabel1";
            this.eventLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(30, 147);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(256, 227);
            this.descriptionBox.TabIndex = 1;
            this.descriptionBox.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imgFileLocation
            // 
            this.imgFileLocation.Location = new System.Drawing.Point(29, 95);
            this.imgFileLocation.Name = "imgFileLocation";
            this.imgFileLocation.Size = new System.Drawing.Size(255, 20);
            this.imgFileLocation.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Image File Name (eg. 7v) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // statusLbl1
            // 
            this.statusLbl1.AutoSize = true;
            this.statusLbl1.BackColor = System.Drawing.SystemColors.Control;
            this.statusLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl1.Location = new System.Drawing.Point(84, 388);
            this.statusLbl1.Name = "statusLbl1";
            this.statusLbl1.Size = new System.Drawing.Size(149, 13);
            this.statusLbl1.TabIndex = 6;
            this.statusLbl1.Text = "Sending Advertisement...";
            // 
            // Advertise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 458);
            this.Controls.Add(this.statusLbl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imgFileLocation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.eventLabel1);
            this.Name = "Advertise";
            this.Text = "Advertise";
            this.Activated += new System.EventHandler(this.Advertise_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eventLabel1;
        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox imgFileLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label statusLbl1;
    }
}