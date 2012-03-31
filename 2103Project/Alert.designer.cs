namespace _2103Project
{
    partial class AlertForm
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
            this.alertListView = new System.Windows.Forms.ListView();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // alertListView
            // 
            this.alertListView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertListView.GridLines = true;
            this.alertListView.Location = new System.Drawing.Point(12, 12);
            this.alertListView.Name = "alertListView";
            this.alertListView.Size = new System.Drawing.Size(345, 289);
            this.alertListView.TabIndex = 0;
            this.alertListView.UseCompatibleStateImageBehavior = false;
            this.alertListView.View = System.Windows.Forms.View.Details;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(146, 307);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // AlertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 335);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.alertListView);
            this.Name = "AlertForm";
            this.Text = "Alert";
            this.Load += new System.EventHandler(this.AlertForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView alertListView;
        private System.Windows.Forms.Button okBtn;

    }
}