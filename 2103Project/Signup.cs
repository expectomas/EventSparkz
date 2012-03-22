using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Text.RegularExpressions;
using System.IO;
using _2103Project.Entities;

/*
 * Authors for this section
 * 
 *   Tio Wee Leong A0073702M
 *   Tan Siong Wee, Edmund  A0076627W
*/


namespace _2103Project
{
    public partial class signupForm : Form
    {
        public signupForm()
        {
            InitializeComponent();
        }

        bool nonNumberEntered;

        private void phoneNumberTextBox_KeyDown(object sender, KeyEventArgs e)
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

        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {         // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

        private void signupForm_Load(object sender, EventArgs e)
        {
        }

        private void signupButton_Click_1(object sender, EventArgs e)
        {
            string emailFmt = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            Regex emailFormat = new Regex(emailFmt);
            if (usernameTextBox.Text == "" && passwordTextBox.Text == "" && cfmPasswordTextBox.Text == "" && ageComboBox.SelectedItem == null && nameTextBox.Text == "" && matricNoTextBox.Text == "" && phoneNumberTextBox.Text == "" && emailTextBox.Text == "" && homeTextBox.Text == "")
            {
                MessageBox.Show("Please complete all your details. Thank You.", "Detail Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Please enter your username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Please enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cfmPasswordTextBox.Text == "")
            {
                MessageBox.Show("Please confirm your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ageComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select your age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (matricNoTextBox.Text == "")
            {
                MessageBox.Show("Please enter your matric no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (phoneNumberTextBox.Text == "" || homeTextBox.Text == "")
            {
                MessageBox.Show("Please enter a contact number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (emailTextBox.Text == "")
            {
                MessageBox.Show("Please enter your email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nameTextBox.Text == "")
            {
                MessageBox.Show("Please enter your name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!passwordTextBox.Text.Equals(cfmPasswordTextBox.Text))
            {
                MessageBox.Show("Your Passwords do not match. Please Try Again.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!emailFormat.IsMatch(emailTextBox.Text))
            {
                MessageBox.Show("You Email Address is not in a correct format.", "Email address error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int userNameErrorCount = 0;
                int nameErrorCount = 0;
                string matricNo = matricNoTextBox.Text;
                matricNo = matricNo.ToUpper();
                string PhoneNo = phoneNumberTextBox.Text;
                string pwdLength = passwordTextBox.Text;
                string username = usernameTextBox.Text;
                username = username.ToLower();
                string temp = nameTextBox.Text;
                temp = temp.ToLower();
                int nameLength = temp.Length;
                for (int i = 0; i < nameLength; i++)
                {
                    if (temp[i] >= 'a' && temp[i] <= 'z')
                    {
                        // do nothing
                    }
                    else
                    {
                        if (temp[i] == ' ' || temp[i] == '/' || temp[i] == '.')
                        {
                            // do nothing
                        }
                        else
                            nameErrorCount++;
                    }
                }

                if (username.Length < 6)
                {
                    MessageBox.Show("Your Username must have at least 6 characters.", "Username Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (nameErrorCount > 0)
                {
                    MessageBox.Show("Invalid Name.", "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (pwdLength.Length < 6)
                {
                    MessageBox.Show("Your Password must have at least 6 characters.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (PhoneNo.Length < 8)
                {
                    MessageBox.Show("Your Contact Number is not in a correct format. Please Try Again.", "Phone No Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (matricNo.Length < 9)
                {
                    MessageBox.Show("Your Matriculation Number is not in a correct format. Please Try Again.", "Matric No Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int uNameLength = username.Length;
                    for (int i = 0; i < uNameLength; i++)
                    {
                        if (username[i] >= 'a' && username[i] <= 'z')
                        {
                            // do nothing
                        }
                        else
                        {
                            if (username[i] < '0' || username[i] > '9')
                                userNameErrorCount++;
                        }
                    }
                    if (userNameErrorCount > 0)
                    {
                        MessageBox.Show("Your Username should only have alphanumeric characters. Please Try Again.", "Username Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if ((matricNo[0] != 'A' && matricNo[0] != 'U') || (matricNo[8] < 'A' || matricNo[8] > 'Z'))
                    {
                        MessageBox.Show("Your Matriculation Number is not in a correct format. Please Try Again.", "Matric No Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int matricNoCountError = 0;
                        for (int i = 1; i < 8; i++)
                        {
                            if (matricNo[i] < '0' || matricNo[i] > '9')
                                matricNoCountError++;
                        }
                        if (matricNoCountError > 0)
                        {
                            MessageBox.Show("Your Matriculation Number is not in a correct format. Please Try Again.", "Matric No Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Confirm signup?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result == DialogResult.Yes)
                            {
                                string filename = "users.xml";
                                int getID = 1;
                                if (File.Exists(filename))
                                {
                                    getID = User.retrievelastID();
                                }
                                User signUp = new User(getID, username, nameTextBox.Text, matricNo, passwordTextBox.Text, emailTextBox.Text, int.Parse(ageComboBox.SelectedItem.ToString()), false, double.Parse(homeTextBox.Text), double.Parse(phoneNumberTextBox.Text));
                                bool checkUNameExist = signUp.createNewUser();
                                if (checkUNameExist == true)
                                {
                                    MessageBox.Show("You have successfully created an account. Thank You!", "Create success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Username already exists. Please choose another Username. Thank You.", "Username existed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void homeTextBox_KeyDown_1(object sender, KeyEventArgs e)
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

        private void homeTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {         // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }
    }
}
