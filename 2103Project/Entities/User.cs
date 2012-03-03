using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _2103Project.Action;

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

        public static bool createNewUser()
        {
            bool userCreated = false;


            return userCreated;
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
