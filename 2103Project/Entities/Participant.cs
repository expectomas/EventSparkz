﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _2103Project.Action;

/*
 * Authors for this section
 * 
 *   Lim Zhi Hao A0067252H
 *   Tio Wee Leong A0073702M
 * 
 */

namespace _2103Project.Entities
{
    class Participant : ActiveUser
    {
        //Attributes
        private List<EventEntity> registeredEvents;

         //Database Access Authetication
        private const string DatabaseToken = "cd#ew1Tf";

        //Constructors

        public Participant()
        {

        }

        public Participant(User copyingUser)
        {
            userId = copyingUser.getUserId();
            userName = copyingUser.getUserName();
            name = copyingUser.getName();
            matricNo = copyingUser.getMatricNo();
            password = copyingUser.getPW();
            email = copyingUser.getEmail();
            age = copyingUser.getAge();
            loggedIn = copyingUser.getLoggedIn();
            contactHome = copyingUser.getContactHome();
            contactHP = copyingUser.getContactHP();

            loadAllRegisteredEvents();
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

        //Methods

        private bool loadAllRegisteredEvents()
        {
            Database db = Database.CreateDatabase(DatabaseToken);

            registeredEvents = new List<EventEntity>();

            List<EventEntity> obtainedEventList = db.getListOfEvents();

            for (int i = 0; i < obtainedEventList.Count; i++)
            {
                EventEntity currentEvent = obtainedEventList[i];

                if (currentEvent.doesParticipantExist(userId))
                    registeredEvents.Add(currentEvent);
            }

            return true;
        }

        public bool registerEvent(EventEntity interestedEvent)
        {
            bool eventRegistered = false;

            //Establish database linkage
            IDatabase db = Database.CreateDatabase(DatabaseToken);

            List<EventEntity> currentEvents = db.getListOfEvents();

            for(int i=0;i<currentEvents.Count;i++)
            {
                if(interestedEvent.getEventId().Equals(currentEvents[i].getEventId()))
                {
                        currentEvents[i].addParticipantToEvent(this);
                        registeredEvents.Add(interestedEvent);
                        eventRegistered = true;
                }
            }

            //Save all events back into database

            db.saveListOfEvents(currentEvents);

            return eventRegistered;
        }               //Unit Test

        public bool cancelEventRegistration(int unInterestedEventId)
        {
            bool eventCancelled = false;

            //Establish database linkage
            IDatabase db = Database.CreateDatabase(DatabaseToken);

            List<EventEntity> currentEvents = db.getListOfEvents();

            for (int i = 0; i < currentEvents.Count; i++)
            {
                if (currentEvents[i].getEventId().Equals(unInterestedEventId))
                {
                    currentEvents[i].removeParticipantFromEvent(this);

                    eventCancelled = true;
                }
            }

            //Save all events back into database

            db.saveListOfEvents(currentEvents);

            for (int i = 0; i < registeredEvents.Count; i++)
            {
                //Remove from existing list as well
                if (unInterestedEventId.Equals(registeredEvents[i].getEventId()))
                {
                    registeredEvents.RemoveAt(i);
                }
            }

            return eventCancelled;
        }

        public List<EventEntity> getRegisteredEvents()
        {
            return new List<EventEntity>(registeredEvents);
        }
    }
}
