namespace _2103Project
{
    partial class welcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcomeForm));
            this.SplashScreen = new System.Windows.Forms.PictureBox();
            this.loginProgressBar = new System.Windows.Forms.ProgressBar();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SplashScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashScreen
            // 
            this.SplashScreen.Image = ((System.Drawing.Image)(resources.GetObject("SplashScreen.Image")));
            this.SplashScreen.Location = new System.Drawing.Point(12, 12);
            this.SplashScreen.Name = "SplashScreen";
            this.SplashScreen.Size = new System.Drawing.Size(257, 179);
            this.SplashScreen.TabIndex = 9;
            this.SplashScreen.TabStop = false;
            // 
            // loginProgressBar
            // 
            this.loginProgressBar.Location = new System.Drawing.Point(13, 198);
            this.loginProgressBar.Name = "loginProgressBar";
            this.loginProgressBar.Size = new System.Drawing.Size(256, 23);
            this.loginProgressBar.TabIndex = 10;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(56, 252);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(159, 30);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "User name here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Welcome!";
            // 
            // welcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(284, 291);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.loginProgressBar);
            this.Controls.Add(this.SplashScreen);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "welcomeForm";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.welcomeForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.SplashScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SplashScreen;
        private System.Windows.Forms.ProgressBar loginProgressBar;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label2;
    }
}