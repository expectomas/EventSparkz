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
                //Database Access
                Database db = new Database();

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

        

    }
}
