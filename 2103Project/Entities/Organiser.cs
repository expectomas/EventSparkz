using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using _2103Project.Action;

/*
 * Authors for this section
 * 
 *   Tio Wee Leong A0073702M
 *   Lim Zhi Hao A0067252H
 *  
 */


namespace _2103Project.Entities
{
    class Organiser : ActiveUser
    {
        //Attributes
        private List<EventEntity> createdEvents;

        // Constructor

        public Organiser(User copyingUser)
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

            loadOrganisedEvent();
        }


        //Database Access Authetication
        private const string DatabaseToken = "9032!ds$";

        //Methods

        private bool loadOrganisedEvent()
        {
            Database db = Database.CreateDatabase(DatabaseToken);

            List<EventEntity> obtainedEvents = db.getListOfEvents();

            createdEvents = new List<EventEntity>();

            EventEntity currentEntity;

            for (int i = 0; i < obtainedEvents.Count; i++)
            {
                currentEntity = obtainedEvents[i];

                if (currentEntity.doesOrganiserExist(userId))
                    createdEvents.Add(currentEntity);
            }

            return true;
        }

        public bool createEvent(EventEntity events)
        {
            Database db = Database.CreateDatabase(DatabaseToken);
            List<EventEntity> eventList = db.getListOfEvents();

            //Add event into the database
            eventList.Add(events);
            db.saveListOfEvents(eventList);

            //Add event into Organiser's own list
            createdEvents.Add(events);

            return true;
        }

        public int getCheckVenueId(string location)
        {
            int venueID = 1;
            Database db = Database.CreateDatabase(DatabaseToken);
            List<Venue> listOfVenue = db.getListOfVenues();
            foreach (Venue ven in listOfVenue)
            {
                if (location == ven.getlocation())
                    venueID = ven.getVenueId();
            }
            return venueID;
        }

        public int getNewActivityId()
        {
            int newActivityId = 1;
            Database db = Database.CreateDatabase(DatabaseToken);
            List<Activity> listOfActivity = db.getListOfActivities();
            foreach (Activity act in listOfActivity)
                newActivityId = act.getActivityId();
            newActivityId++;
            return newActivityId;
        }

        public bool addNewActivity(Activity newAct)
        {
            Database db = Database.CreateDatabase(DatabaseToken);
            List<Activity> activityList = db.getListOfActivities();
            activityList.Add(newAct);
            db.saveListOfActivities(activityList);
            return true;
        }

        public static int getNewEventId()
        {
            int newEventID = 0;
            Database db = Database.CreateDatabase(DatabaseToken);
            List<EventEntity> eventList = db.getListOfEvents();
            foreach (EventEntity eve in eventList)
            {
                newEventID = eve.getEventId();
            }
            newEventID++;
            return newEventID;
        }

        public bool addSchedule(Schedule newSchedule)
        {
            Database db = Database.CreateDatabase(DatabaseToken);
            List<Schedule> listOfSchedule = db.getListOfSchedule();
            listOfSchedule.Add(newSchedule);
            db.saveListOfSchedule(listOfSchedule);
            return true;
        }

        public static int getNewScheduleId()
        {
            int newScheduleID = 0;
            Database db = Database.CreateDatabase(DatabaseToken);
            List<EventEntity> eventList = db.getListOfEvents();
            foreach (EventEntity eve in eventList)
            {
                newScheduleID = eve.getScheduleID();
            }
            newScheduleID++;
            return newScheduleID;
        }

        public bool cancelEvent(int selectedEventId)
        {
            bool eventCancelled = false;

            //Update Database
            Database db = Database.CreateDatabase(DatabaseToken);
            List<EventEntity> eventList = db.getListOfEvents();
            List<EventEntity> newEventList = new List<EventEntity>();

            foreach (EventEntity events in eventList)
            {
                if (!(selectedEventId.Equals(events.getEventId()) && userId == events.getOrganiserID()))
                    newEventList.Add(events);
            }

            db.saveListOfEvents(newEventList);


            //Update Orgniser's own list
            for(int i =0;i<createdEvents.Count;i++)
            {
                EventEntity deregisteringEvent = createdEvents[i];

                if (deregisteringEvent.getEventId() == selectedEventId)
                    createdEvents.RemoveAt(i);
            }

            return !eventCancelled;
        }

        public bool updateEvent()
        {
            bool eventUpdated = false;


            return eventUpdated;
        }

        public List<EventEntity> getOrganisedEvents()
        {
            return new List<EventEntity>(createdEvents);
        }

        public List<Facilitator> viewListOfFacilitator(EventEntity thisEvent)
        {
            List<Facilitator> outputFacilitatorList = new List<Facilitator>();

            List<int> listOfFacilitatorId = thisEvent.getListOfFacilitator();

            Database db = Database.CreateDatabase(DatabaseToken);

            List<User> listOfUsers = db.getListOfUsers();

            for (int i = 0; i < listOfUsers.Count; i++)
            {
                if(listOfFacilitatorId.Contains(listOfUsers[i].getUserId()))
                    outputFacilitatorList.Add(new Facilitator(listOfUsers[i]));
            }

            return outputFacilitatorList;
        }
    }
}
