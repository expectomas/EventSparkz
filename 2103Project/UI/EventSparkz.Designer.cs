namespace _2103Project.UI
{
    partial class EventSparkz
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
            this.logoES = new System.Windows.Forms.PictureBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.linkNewuser = new System.Windows.Forms.LinkLabel();
            this.linkTutorial = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.logoES)).BeginInit();
            this.SuspendLayout();
            // 
            // logoES
            // 
            this.logoES.Image = global::_2103Project.Properties.Resources.loginLogo;
            this.logoES.Location = new System.Drawing.Point(145, 49);
            this.logoES.Name = "logoES";
            this.logoES.Size = new System.Drawing.Size(257, 188);
            this.logoES.TabIndex = 1;
            this.logoES.TabStop = false;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(213, 286);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(120, 50);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "ENTER";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // linkNewuser
            // 
            this.linkNewuser.AutoSize = true;
            this.linkNewuser.Font = new System.Drawing.Font("Futura Lt", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNewuser.Location = new System.Drawing.Point(12, 414);
            this.linkNewuser.Name = "linkNewuser";
            this.linkNewuser.Size = new System.Drawing.Size(138, 16);
            this.linkNewuser.TabIndex = 3;
            this.linkNewuser.TabStop = true;
            this.linkNewuser.Text = "Register as New User";
            // 
            // linkTutorial
            // 
            this.linkTutorial.AutoSize = true;
            this.linkTutorial.Font = new System.Drawing.Font("Futura Lt", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkTutorial.Location = new System.Drawing.Point(437, 414);
            this.linkTutorial.Name = "linkTutorial";
            this.linkTutorial.Size = new System.Drawing.Size(85, 16);
            this.linkTutorial.TabIndex = 4;
            this.linkTutorial.TabStop = true;
            this.linkTutorial.Text = "View Tutorial";
            // 
            // EventSparkz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 439);
            this.Controls.Add(this.linkTutorial);
            this.Controls.Add(this.linkNewuser);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.logoES);
            this.Name = "EventSparkz";
            this.Text = "EventSparkz";
            ((System.ComponentModel.ISupportInitialize)(this.logoES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoES;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.LinkLabel linkNewuser;
        private System.Windows.Forms.LinkLabel linkTutorial;
    }
}