using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _2103Project.Entities;

namespace _2103Project
{
    public partial class editBudgetForm : Form
    {
        int currentEventID = 1;
        private User currentUser;

        public editBudgetForm(User incomingUser, int incomingEventID)
        {
            currentUser = incomingUser;
            currentEventID = incomingEventID;
            InitializeComponent();
            initBudgetList();
        }

        bool nonNumberEntered = false;

        public void initBudgetList()
        {
            budgetListListView.Columns.Insert(0, "Item", 180, HorizontalAlignment.Left);
            budgetListListView.Columns.Insert(1, "Cost ($)", 80, HorizontalAlignment.Left);
            budgetListListView.Columns.Insert(2, "ITEMID", 0, HorizontalAlignment.Left);
        }

        private void costTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void dpTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void dpTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {         // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

        private void costTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {         // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < budgetListListView.Items.Count; i++)
            {
                if (budgetListListView.Items[i].Selected)
                    budgetListListView.Items[i].Remove();
            }
            float totalPrice = 0;
            for (int i = 0; i < budgetListListView.Items.Count; i++)
            {
                totalPrice += float.Parse(budgetListListView.Items[i].SubItems[1].Text);
            }
            totalPriceTextBox.Text = totalPrice.ToString("N2");
        }

        private void saveChangeButton_Click(object sender, EventArgs e)
        {
            Organiser org = new Organiser(currentUser);
            List<string> listItem = new List<string>();
            List<double> listPrice = new List<double>();
            List<int> listID = new List<int>();
            for (int i = 0; i < budgetListListView.Items.Count; i++)
            {
                listItem.Add(budgetListListView.Items[i].SubItems[0].Text);
                listPrice.Add(double.Parse(budgetListListView.Items[i].SubItems[1].Text));
                listID.Add(int.Parse(budgetListListView.Items[i].SubItems[2].Text));
            }
            org.saveBudget(listItem, listPrice, listID, double.Parse(totalPriceTextBox.Text), currentEventID);
            MessageBox.Show("You have successfully save your new budget", "Save successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        int addflag = 0;
        int newItemID = 0;
        private void addBudgetItem_Click(object sender, EventArgs e)
        {
            if (costTextBox.Text.Equals(String.Empty) || budgetItemTextBox.Text.Equals(String.Empty) || dpTextBox.Text.Equals(String.Empty))
            {
                MessageBox.Show("The item or price is empty. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Organiser org = new Organiser(currentUser);
                float totalPrice = float.Parse(totalPriceTextBox.Text);
                ListViewItem newItem = new ListViewItem(budgetItemTextBox.Text);
                float price = float.Parse(costTextBox.Text) + float.Parse(dpTextBox.Text) / 100.0f;
                newItem.SubItems.Add(price.ToString("N2"));
                if (addflag == 0)
                {
                    newItemID = org.getNewItemID();
                    newItem.SubItems.Add(newItemID.ToString());
                }
                else
                {
                    newItemID++;
                    newItem.SubItems.Add(newItemID.ToString());
                }
                budgetListListView.Items.Add(newItem);
                totalPriceTextBox.Text = (totalPrice + price).ToString("N2");
                addflag = 1;
            }
        }

        private void editBudgetForm_Load(object sender, EventArgs e)
        {
            List<int> listOfItemID = EventEntity.getListOfItemIDFromEventID(currentEventID);
            Queue<string> listOfItem = EventEntity.getListOfBudgetItemFromEventID(currentEventID);
            Queue<double> listOfCost = EventEntity.getListOfBudgetCostFromEventID(currentEventID);
            double totalPrice = EventEntity.getTotalPriceFromEventID(currentEventID);
            int listIndex = 0;
            while (listOfItem.Count != 0)
            {
                ListViewItem newItem = new ListViewItem(listOfItem.Dequeue());
                newItem.SubItems.Add(listOfCost.Dequeue().ToString("N2"));
                newItem.SubItems.Add(listOfItemID[listIndex].ToString());
                budgetListListView.Items.Add(newItem);
                listIndex++;
            }
            totalPriceTextBox.Text = totalPrice.ToString("N2");
        }
    }
}
