using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _2103Project.Action;

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

            foreach (EventEntity accessEvent in currentEvents)
            {
                if (accessEvent.Equals(interestedEvent))
                {
                    accessEvent.addParticipantToEvent(this);
                    eventRegistered = true;
                }
            }

            //Save all events back into database

            db.saveListOfEvents(currentEvents);

            return eventRegistered;
        }

        public bool cancelEventRegistration(EventEntity unInterestedEvent)
        {
            bool eventCancelled = false;

            //Establish database linkage
            IDatabase db = Database.CreateDatabase(DatabaseToken);

            List<EventEntity> currentEvents = db.getListOfEvents();

            foreach (EventEntity accessEvent in currentEvents)
            {
                if (accessEvent.Equals(unInterestedEvent))
                {
                    accessEvent.removeParticipantFromEvent(this);
                    eventCancelled = true;
                }
            }

            //Save all events back into database

            db.saveListOfEvents(currentEvents);
            return eventCancelled;
        }
    }
}
