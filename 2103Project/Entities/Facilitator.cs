﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _2103Project.Action;

namespace _2103Project.Entities
{
    class Facilitator : ActiveUser
    {
        //Attributes

        private List<EventEntity> FacilitatingEvents;

        //Database Access Authetication
        private const string DatabaseToken = "5hfoipe@";

        //Constructor
        
        public Facilitator(int i_userId, string i_userName, string i_name, string i_matricNo, string i_password,
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

        //Methods

        private bool loadAllRegisteredEvents()
        {
            Database db = Database.CreateDatabase(DatabaseToken);

            FacilitatingEvents = new List<EventEntity>();

            List<EventEntity> obtainedEventList = db.getListOfEvents();

            for (int i = 0; i < obtainedEventList.Count; i++)
            {
                EventEntity currentEvent = obtainedEventList[i];

                if (currentEvent.doesFacilitatorExist(userId))
                    FacilitatingEvents.Add(currentEvent);
            }

            return true;
        }

        public List<Participant> viewParticipantList()
        {
            //Establish database linkage
            IDatabase db = Database.CreateDatabase(DatabaseToken);

            List<Participant> allParticipants = new List<Participant>();

            

            return allParticipants;
        }
    }
}
