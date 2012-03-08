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

namespace _2103Project
{
    public partial class signupForm : Form
    {
        public signupForm()
        {
            InitializeComponent();
        }

        bool nonNumberEntered;
        private void signupButton_Click(object sender, EventArgs e)
        {
            string emailFmt = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            Regex emailFormat = new Regex(emailFmt);
            if (usernameTextBox.Text == "" || passwordTextBox.Text == "" || cfmPasswordTextBox.Text == "" || memberComboBox.SelectedItem == null || nameTextBox.Text == "" || matricNoTextBox.Text == "" || phoneNumberTextBox.Text == "" || emailTextBox.Text == "")
            {
                MessageBox.Show("Please complete all your details. Thank you.", "Detail Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!passwordTextBox.Text.Equals(cfmPasswordTextBox.Text))
            {
                MessageBox.Show("Your password is cannot be verified. Make sure that your passwords are correct.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!emailFormat.IsMatch(emailTextBox.Text))
            {
                MessageBox.Show("You email address is not in a correct format.", "Email address error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if (temp[i] > 'a' && temp[i] < 'z')
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
                    MessageBox.Show("Your Username must at least 6 characters.", "Username Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (nameErrorCount > 0)
                {
                    MessageBox.Show("Invalid name.", "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (pwdLength.Length < 6)
                {
                    MessageBox.Show("Your Password must at least 6 characters.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (PhoneNo.Length < 8)
                {
                    MessageBox.Show("Your Contact Number is not in a correct format. Please Try again later.", "Phone No Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (matricNo.Length < 9)
                {
                    MessageBox.Show("Your Matriculation Number is not in a correct format. Please Try again later.", "Matric No Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("Your username should only have alphanumeric character. Please Try again.", "Username Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if ((matricNo[0] != 'A' && matricNo[0] != 'U') || (matricNo[8] < 'A' || matricNo[8] > 'Z'))
                    {
                        MessageBox.Show("Your Matriculation Number is not in a correct format. Please Try again.", "Matric No Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            MessageBox.Show("Your Matriculation Number is not in a correct format. Please Try again.", "Matric No Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Warning: All USERNAME will be converted to lower case.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            DialogResult result = MessageBox.Show("Confirm signup?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result == DialogResult.Yes)
                            {
                                string filename = "user.xml";
                                if (File.Exists(filename))
                                {
                                    bool checkUNameExist = checkUsernameExist(username);
                                    if (checkUNameExist == false)
                                    {
                                        XmlReader reader = XmlReader.Create(filename);
                                        // draw xml here
                                        writeExistToXml(reader, username, matricNo);

                                    }
                                    else
                                    {
                                        MessageBox.Show("The username is already existed. Please choose another username. Thank you.", "Username existed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    XmlTextWriter textWriter = new XmlTextWriter(filename, Encoding.UTF8);
                                    // draw xml here
                                    writeToXml(textWriter, username, matricNo);
                                    MessageBox.Show("Hello");
                                }
                            }
                        }
                    }
                }
            }
        }

        void writeToXml(XmlTextWriter textWriter, string username, string matricNo)
        {
            textWriter.WriteStartDocument();
            textWriter.WriteStartElement("UserPool");
            textWriter.WriteStartElement("User");
            textWriter.WriteStartAttribute("username");
            textWriter.WriteString(username);
            textWriter.WriteEndAttribute();
            textWriter.WriteStartElement("password");
            textWriter.WriteString(passwordTextBox.Text);
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("member");
            textWriter.WriteString(memberComboBox.SelectedItem.ToString());
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("name");
            textWriter.WriteString(nameTextBox.Text.ToUpper());
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("matricNo");
            textWriter.WriteString(matricNo);
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("contact");
            textWriter.WriteString(phoneNumberTextBox.Text);
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("email");
            textWriter.WriteString(emailTextBox.Text);
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.WriteEndDocument();
            textWriter.Close();
        }

        void writeExistToXml(XmlReader reader, string username, string matricNo)
        {
            XmlTextWriter tempWriter = new XmlTextWriter("temp.xml", Encoding.UTF8);
            tempWriter.WriteStartDocument();
            tempWriter.WriteStartElement("UserPool");
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "User":
                            tempWriter.WriteStartElement("User");
                            string attribute = reader["username"];
                            tempWriter.WriteStartAttribute("username");
                            tempWriter.WriteString(attribute);
                            tempWriter.WriteEndAttribute();
                            break;

                        case "password":
                            tempWriter.WriteStartElement("password");
                            tempWriter.WriteString(reader.ReadElementContentAsString());
                            tempWriter.WriteEndElement();
                       
                            tempWriter.WriteStartElement("member");
                            tempWriter.WriteString(reader.ReadElementContentAsString());
                            tempWriter.WriteEndElement();

                            tempWriter.WriteStartElement("name");
                            tempWriter.WriteString(reader.ReadElementContentAsString());
                            tempWriter.WriteEndElement();

                            tempWriter.WriteStartElement("matricNo");
                            tempWriter.WriteString(reader.ReadElementContentAsString());
                            tempWriter.WriteEndElement();

                            tempWriter.WriteStartElement("contact");
                            tempWriter.WriteString(reader.ReadElementContentAsString());
                            tempWriter.WriteEndElement();

                            tempWriter.WriteStartElement("email");
                            tempWriter.WriteString(reader.ReadElementContentAsString());
                            tempWriter.WriteEndElement();
                            tempWriter.WriteEndElement();
                            reader.MoveToElement();
                            break;

                        default:
                            break;

                    }
                }
            }
            tempWriter.WriteEndDocument();
            tempWriter.Close();
            reader.Close();
            XmlReader tempreader = XmlReader.Create("temp.xml");
            writeToNewXml(tempreader, username, matricNo);
            MessageBox.Show("Temp created");
        }

        void writeToNewXml(XmlReader tempreader, string username, string matricNo)
        {
            XmlTextWriter textWriter = new XmlTextWriter("user.xml", Encoding.UTF8);
            textWriter.WriteStartDocument();
            textWriter.WriteStartElement("UserPool");
            while (tempreader.Read())
            {
                if (tempreader.IsStartElement())
                {
                    switch (tempreader.Name)
                    {
                        case "User":
                            textWriter.WriteStartElement("User");
                            string attribute = tempreader["username"];
                            textWriter.WriteStartAttribute("username");
                            textWriter.WriteString(attribute);
                            textWriter.WriteEndAttribute();
                            break;

                        case "password":
                            textWriter.WriteStartElement("password");
                            textWriter.WriteString(tempreader.ReadElementContentAsString());
                            textWriter.WriteEndElement();

                            textWriter.WriteStartElement("member");
                            textWriter.WriteString(tempreader.ReadElementContentAsString());
                            textWriter.WriteEndElement();

                            textWriter.WriteStartElement("name");
                            textWriter.WriteString(tempreader.ReadElementContentAsString());
                            textWriter.WriteEndElement();

                            textWriter.WriteStartElement("matricNo");
                            textWriter.WriteString(tempreader.ReadElementContentAsString());
                            textWriter.WriteEndElement();

                            textWriter.WriteStartElement("contact");
                            textWriter.WriteString(tempreader.ReadElementContentAsString());
                            textWriter.WriteEndElement();

                            textWriter.WriteStartElement("email");
                            textWriter.WriteString(tempreader.ReadElementContentAsString());
                            textWriter.WriteEndElement();
                            textWriter.WriteEndElement();
                            tempreader.MoveToElement();
                            break;

                        default:
                            break;

                    }
                }
            }

            textWriter.WriteStartElement("User");
            textWriter.WriteStartAttribute("username");
            textWriter.WriteString(username);
            textWriter.WriteEndAttribute();
            textWriter.WriteStartElement("password");
            textWriter.WriteString(passwordTextBox.Text);
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("member");
            textWriter.WriteString(memberComboBox.SelectedItem.ToString());
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("name");
            textWriter.WriteString(nameTextBox.Text.ToUpper());
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("matricNo");
            textWriter.WriteString(matricNo);
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("contact");
            textWriter.WriteString(phoneNumberTextBox.Text);
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("email");
            textWriter.WriteString(emailTextBox.Text);
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.WriteEndDocument();
            textWriter.Close();
            tempreader.Close();
        }

        bool checkUsernameExist(string username)
        {
            string filename = "user.xml";
            int existflag = 0;
            XmlReader reader = XmlReader.Create(filename);
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "User":
                            string attribute = reader["username"];
                            if (attribute.Equals(username))
                                existflag = 1;
                            break;
                        default:
                            break;
                    }
                }
            }
            reader.Close();
            if (existflag == 1)
                return true;
            else
                return false;
        }
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
            MessageBox.Show("Warning: Please ensure that your particular is accurate to prevent from any inconvenient caused. Thank you.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
