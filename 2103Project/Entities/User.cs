﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using _2103Project.Action;
using System.IO;
using System.Xml;

namespace _2103Project.Entities
{
    class User
    {
        protected int userId;
        protected string userName;
        protected string name;
        protected string matricNo;
        protected string password;
        protected string email;
        protected int age;
        protected bool loggedIn=false;
        protected double contactHome;
        protected double contactHP;


        //Database Access Authetication
        private const string DatabaseToken = "ewknf%32";

        public User(){
        }

        public User(int i_userId, string i_userName, string i_name, string i_matricNo, string i_password,
                    string i_email, int i_age, bool i_loggedIn,double i_contactHome, double i_contactHP)
        {
            userId = i_userId;
            userName = i_userName;
            name = i_name;
            matricNo = i_matricNo;
            password = i_password;
            email = i_email;
            age = i_age;
            loggedIn = i_loggedIn;
            contactHome = i_contactHome;
            contactHP = i_contactHP;
        }

        public bool checkEmailFormat(string email)
        {
            string emailFmt = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            Regex emailFormat = new Regex(emailFmt);
            return emailFormat.IsMatch(email);
        }

        public bool checkNameFormat(string name)
        {
            int nameErrorCount = 0;
            int nameLength = name.Length;
            for (int i = 0; i < nameLength; i++)
            {
                if (name[i] >= 'a' && name[i] <= 'z')
                {
                    // do nothing
                }
                else
                {
                    if (name[i] == ' ' || name[i] == '/' || name[i] == '.')
                    {
                        // do nothing
                    }
                    else
                        nameErrorCount++;
                }
            }
            if (nameErrorCount > 0)
                return false;
            return true;
        }

        public bool checkUserNameFormat(string username)
        {
            int uNameLength = username.Length;
            int userNameErrorCount = 0;
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
                return false;
            return true;
        }

        public bool checkMatricNoFormat(string matricNo)
        {
            int matricNoCountError = 0;
            for (int i = 1; i < 8; i++)
            {
                if (matricNo[i] < '0' || matricNo[i] > '9')
                    matricNoCountError++;
            }
            if (matricNoCountError > 0)
                return false;
            return true;
        }

        public bool login(string tokenUserName, string tokenPassWord){

            bool auth = false;

            if (loggedIn == true)
                auth = true;
            else
            {
                Database db = Database.CreateDatabase(DatabaseToken);

                List<User> obtainedUserList = db.getListOfUsers();

                foreach(User cu in obtainedUserList)
                {
                    if (cu.userName == tokenUserName && tokenPassWord == cu.password)
                    {
                        auth = true;
                        break;
                    }
                }
            }

            return auth;
        }

        public bool logout(){
            bool auth = false;

            return auth;
        }

        public bool createNewUser()
        {
            Database db = Database.CreateDatabase(DatabaseToken);
            bool userCreated = true;
            string filename = "users.xml";
            if (File.Exists(filename))
            {
                bool checkUNameExist = db.checkUsernameExist(userName);
                if (checkUNameExist == false)
                {
                    XmlReader reader = XmlReader.Create(filename);
                    // draw xml here
                    db.writeExistToXml(reader, userId, userName, name, matricNo, password, email, age, loggedIn, contactHome, contactHP);
                }
                else
                {
                    userCreated = false;
                }
            }
            else
            {
                XmlTextWriter textWriter = new XmlTextWriter(filename, Encoding.UTF8);
                // draw xml here
                db.writeFirstToXml(textWriter, userId, userName, name, matricNo, password, email, age, loggedIn, contactHome, contactHP);
            }
            return userCreated;
        }        

        public static int retrievelastID()
        {
            Database db = Database.CreateDatabase(DatabaseToken);
            int newID = db.getLastID();
            return newID;
        }

        public bool requestUserDetail(ref int i_userId, ref string i_userName, ref string i_name, ref string i_matricNo, ref string i_password,
                    ref string i_email, ref int i_age, ref bool i_loggedIn, ref double i_contactHome, ref double i_contactHP, string purpose)
        {
            
            bool releasedDetails = false;

            if(purpose.Equals("databaseRequest"))
            {
                i_userId = userId;
                i_userName = userName;
                i_name = name;
                i_matricNo = matricNo;
                i_password = password;
                i_email  = email;
                i_age = age;
                i_loggedIn = loggedIn;
                i_contactHome = contactHome;
                i_contactHP  = contactHP;

                releasedDetails = true;
            }

            return releasedDetails;
        }
    }
}
