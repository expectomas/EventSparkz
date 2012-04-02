namespace _2103Project
{
    partial class editBudgetForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.addBudgetItem = new System.Windows.Forms.Button();
            this.budgetItemTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveChangeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.budgetListListView = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dpTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.dpTextBox);
            this.groupBox3.Controls.Add(this.costTextBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.addBudgetItem);
            this.groupBox3.Controls.Add(this.budgetItemTextBox);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(499, 101);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(210, -3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 21);
            this.label12.TabIndex = 41;
            this.label12.Text = "Budget:";
            // 
            // addBudgetItem
            // 
            this.addBudgetItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBudgetItem.Location = new System.Drawing.Point(394, 23);
            this.addBudgetItem.Name = "addBudgetItem";
            this.addBudgetItem.Size = new System.Drawing.Size(92, 63);
            this.addBudgetItem.TabIndex = 36;
            this.addBudgetItem.Text = "Add Item";
            this.addBudgetItem.UseVisualStyleBackColor = true;
            this.addBudgetItem.Click += new System.EventHandler(this.addBudgetItem_Click);
            // 
            // budgetItemTextBox
            // 
            this.budgetItemTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetItemTextBox.Location = new System.Drawing.Point(109, 23);
            this.budgetItemTextBox.Name = "budgetItemTextBox";
            this.budgetItemTextBox.Size = new System.Drawing.Size(279, 29);
            this.budgetItemTextBox.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 21);
            this.label11.TabIndex = 37;
            this.label11.Text = "Cost:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 21);
            this.label10.TabIndex = 36;
            this.label10.Text = "Budget Item:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalPriceTextBox);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.saveChangeButton);
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.budgetListListView);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 282);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // saveChangeButton
            // 
            this.saveChangeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangeButton.Location = new System.Drawing.Point(363, 240);
            this.saveChangeButton.Name = "saveChangeButton";
            this.saveChangeButton.Size = new System.Drawing.Size(123, 29);
            this.saveChangeButton.TabIndex = 41;
            this.saveChangeButton.Text = "Save Change";
            this.saveChangeButton.UseVisualStyleBackColor = true;
            this.saveChangeButton.Click += new System.EventHandler(this.saveChangeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(7, 240);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(123, 29);
            this.deleteButton.TabIndex = 39;
            this.deleteButton.Text = "Delete Item";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // budgetListListView
            // 
            this.budgetListListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetListListView.FullRowSelect = true;
            this.budgetListListView.GridLines = true;
            this.budgetListListView.Location = new System.Drawing.Point(7, 27);
            this.budgetListListView.Name = "budgetListListView";
            this.budgetListListView.Size = new System.Drawing.Size(479, 207);
            this.budgetListListView.TabIndex = 40;
            this.budgetListListView.UseCompatibleStateImageBehavior = false;
            this.budgetListListView.View = System.Windows.Forms.View.Details;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(193, -3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 21);
            this.label8.TabIndex = 32;
            this.label8.Text = "Budget List:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(174, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 17);
            this.label14.TabIndex = 46;
            this.label14.Text = ".";
            // 
            // dpTextBox
            // 
            this.dpTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpTextBox.Location = new System.Drawing.Point(191, 57);
            this.dpTextBox.MaxLength = 2;
            this.dpTextBox.Name = "dpTextBox";
            this.dpTextBox.Size = new System.Drawing.Size(31, 29);
            this.dpTextBox.TabIndex = 45;
            this.dpTextBox.Text = "00";
            this.dpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dpTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dpTextBox_KeyDown);
            this.dpTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dpTextBox_KeyPress);
            // 
            // costTextBox
            // 
            this.costTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costTextBox.Location = new System.Drawing.Point(109, 57);
            this.costTextBox.MaxLength = 5;
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(61, 29);
            this.costTextBox.TabIndex = 44;
            this.costTextBox.Text = "100";
            this.costTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.costTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.costTextBox_KeyDown);
            this.costTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.costTextBox_KeyPress);
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Enabled = false;
            this.totalPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceTextBox.Location = new System.Drawing.Point(238, 240);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(119, 29);
            this.totalPriceTextBox.TabIndex = 44;
            this.totalPriceTextBox.Text = "0.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(136, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 21);
            this.label13.TabIndex = 43;
            this.label13.Text = "Total Cost ($):";
            // 
            // editBudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(526, 413);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "editBudgetForm";
            this.Text = "Edit Budget";
            this.Load += new System.EventHandler(this.editBudgetForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button addBudgetItem;
        private System.Windows.Forms.TextBox budgetItemTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saveChangeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListView budgetListListView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox dpTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.Label label13;

    }
}