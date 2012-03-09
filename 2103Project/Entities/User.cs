using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using _2103Project.Action;
using System.IO;
using System.Xml;

namespace _2103Project.Entities
{
    public class User
    {
        //Database Access Authetication
        private const string DatabaseToken = "ewknf%32";

        //Attributes
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

        //Constructors
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

        public bool login(string tokenUserName, string tokenPassWord,ref User returningUser){

            bool auth = false;
            this.userName = tokenUserName;
            this.password = tokenPassWord;

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

                        //Set user to loggedIn
                        
                        cu.loggedIn = true;

                        //Set all attributes of this user

                        userId = cu.userId;
                        userName = cu.userName;
                        name = cu.name;
                        matricNo = cu.matricNo;
                        password = cu.password;
                        email = cu.email;
                        age = cu.age;
                        loggedIn = true;
                        contactHome = cu.contactHome;
                        contactHP = cu.contactHP;

                        break;
                    }
                }

                //Save LoginIn Status
                db.saveListOfUsers(obtainedUserList);
            }


            if (auth)
            {
                returningUser = this;
                return true;
            }
            else
            {
                returningUser = returningUser;
                return false;
            }
        }

        public bool logout()
        {
                bool loggedOutSuccess = false;

                Database db = Database.CreateDatabase(DatabaseToken);

                List<User> obtainedUserList = db.getListOfUsers();

                foreach (User cu in obtainedUserList)
                {
                    if (cu.userName == this.userName && this.password == cu.password)
                    {
                        cu.loggedIn = false;
                        loggedOutSuccess = true;
                    }
                }

                db.saveListOfUsers(obtainedUserList);

                return loggedOutSuccess;
        }

        public bool createNewUser()
        {
            Database db = Database.CreateDatabase(DatabaseToken);
            bool userCreated = true;
            bool checkUNameExist = true;
                List<User> listOfUsers = db.getListOfUsers();
                foreach(User checkUser in listOfUsers)
                {
                    if (checkUser.userName == userName)
                        checkUNameExist = false;
                }
                if (checkUNameExist == true)
                {
                    User test = new User(userId, userName, name, matricNo, password, email, age, loggedIn, contactHome, contactHP);
                    listOfUsers.Add(test);
                    db.saveListOfUsers(listOfUsers);
                }
                else
                {
                    userCreated = false;
                }
            return userCreated;
        }

        public int getUserId()
        {
            return userId;
        }

        public static int retrievelastID()
        {
            int newID = 1;
            Database db = Database.CreateDatabase(DatabaseToken);
            List<User> listOfUsers = db.getListOfUsers();
            foreach (User checkUser in listOfUsers)
            {
                newID = checkUser.userId;
            }
            newID++;
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
