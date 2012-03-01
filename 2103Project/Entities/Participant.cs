﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2103Project.Entities
{
    class Participant : ActiveUser
    {
        //Attributes
        public List<EventEntity> registeredEvents;

         //Database Access Authetication
        private const string DatabaseToken = "cd#ew1Tf";

        //Methods
        public bool registerEvent()
        {
            bool eventRegistered = false;

            return eventRegistered;
        }

        public bool cancelEventRegistration()
        {
            bool eventRegistered = false;


            return eventRegistered;
        }

        public Participant()
        {

        }

        public Participant(int i_userId, string i_userName, string i_name, string i_matricNo, string i_password,
                    string i_email, int i_age, bool i_loggedIn, double i_contactHome, double i_contactHP)
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

    }
}
