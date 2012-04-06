namespace _2103Project
{
    partial class Analytic
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mostRegisteredEvent = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.eventNameLbl = new System.Windows.Forms.Label();
            this.participantSizeOutput = new System.Windows.Forms.Label();
            this.eventDateOutput = new System.Windows.Forms.Label();
            this.eventNameOutput = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.mostRegisteredEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mostRegisteredEvent);
            this.tabControl1.Location = new System.Drawing.Point(24, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(382, 250);
            this.tabControl1.TabIndex = 0;
            // 
            // mostRegisteredEvent
            // 
            this.mostRegisteredEvent.Controls.Add(this.splitContainer1);
            this.mostRegisteredEvent.Location = new System.Drawing.Point(4, 22);
            this.mostRegisteredEvent.Name = "mostRegisteredEvent";
            this.mostRegisteredEvent.Padding = new System.Windows.Forms.Padding(3);
            this.mostRegisteredEvent.Size = new System.Drawing.Size(374, 224);
            this.mostRegisteredEvent.TabIndex = 0;
            this.mostRegisteredEvent.Text = "Most Event Registered";
            this.mostRegisteredEvent.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.eventNameLbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.participantSizeOutput);
            this.splitContainer1.Panel2.Controls.Add(this.eventDateOutput);
            this.splitContainer1.Panel2.Controls.Add(this.eventNameOutput);
            this.splitContainer1.Size = new System.Drawing.Size(368, 218);
            this.splitContainer1.SplitterDistance = 122;
            this.splitContainer1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Participant Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Event Date";
            // 
            // eventNameLbl
            // 
            this.eventNameLbl.AutoSize = true;
            this.eventNameLbl.Location = new System.Drawing.Point(28, 43);
            this.eventNameLbl.Name = "eventNameLbl";
            this.eventNameLbl.Size = new System.Drawing.Size(75, 13);
            this.eventNameLbl.TabIndex = 0;
            this.eventNameLbl.Text = "Event Name : ";
            // 
            // participantSizeOutput
            // 
            this.participantSizeOutput.AutoSize = true;
            this.participantSizeOutput.Location = new System.Drawing.Point(39, 148);
            this.participantSizeOutput.Name = "participantSizeOutput";
            this.participantSizeOutput.Size = new System.Drawing.Size(108, 13);
            this.participantSizeOutput.TabIndex = 2;
            this.participantSizeOutput.Text = "participantSizeOutput";
            // 
            // eventDateOutput
            // 
            this.eventDateOutput.AutoSize = true;
            this.eventDateOutput.Location = new System.Drawing.Point(39, 91);
            this.eventDateOutput.Name = "eventDateOutput";
            this.eventDateOutput.Size = new System.Drawing.Size(89, 13);
            this.eventDateOutput.TabIndex = 1;
            this.eventDateOutput.Text = "eventDateOutput";
            // 
            // eventNameOutput
            // 
            this.eventNameOutput.AutoSize = true;
            this.eventNameOutput.Location = new System.Drawing.Point(39, 43);
            this.eventNameOutput.Name = "eventNameOutput";
            this.eventNameOutput.Size = new System.Drawing.Size(94, 13);
            this.eventNameOutput.TabIndex = 0;
            this.eventNameOutput.Text = "eventNameOutput";
            // 
            // Analytic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 286);
            this.Controls.Add(this.tabControl1);
            this.Name = "Analytic";
            this.Text = "Analytic";
            this.Load += new System.EventHandler(this.Analytic_Load);
            this.tabControl1.ResumeLayout(false);
            this.mostRegisteredEvent.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mostRegisteredEvent;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label eventNameLbl;
        private System.Windows.Forms.Label participantSizeOutput;
        private System.Windows.Forms.Label eventDateOutput;
        private System.Windows.Forms.Label eventNameOutput;
    }
}