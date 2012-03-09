using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using _2103Project.Action;

namespace _2103Project.Entities
{
    class Organiser : ActiveUser
    {
        //Attributes
        private List<EventEntity> Bookings;

        // Constructor
        public Organiser()
        {
        }

        //Database Access Authetication
        private const string DatabaseToken = "9032!ds$";

        //Methods

        private bool loadOrganisedEvent()
        {
            Database db = Database.CreateDatabase(DatabaseToken);

            List<EventEntity> obtainedEvents = db.getListOfEvents();

            Bookings = new List<EventEntity>();

            EventEntity currentEntity;

            for (int i = 0; i < obtainedEvents.Count; i++)
            {
                currentEntity = obtainedEvents[i];

                if (currentEntity.doesOrganiserExist(userId))
                    Bookings.Add(currentEntity);
            }

            return true;
        }

        public bool createEvent(EventEntity events)
        {
            Database db = Database.CreateDatabase(DatabaseToken);
            List<EventEntity> eventList = db.getListOfEvents();
            eventList.Add(events);
            db.saveListOfEvents(eventList);
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

        public bool cancelEvent(string selectedEventName, User selectedOrganiser)
        {
            bool eventCancelled = false;

            Database db = Database.CreateDatabase(DatabaseToken);
            List<EventEntity> eventList = db.getListOfEvents();
            List<EventEntity> newEventList = new List<EventEntity>();
            foreach (EventEntity events in eventList)
            {
                if (!(selectedEventName.Equals(events.getEventName()) && selectedOrganiser.getUserId() == events.getOrganiserID()))
                    newEventList.Add(events);
            }
            db.saveListOfEvents(newEventList);
            return !eventCancelled;
        }

        public bool updateEvent()
        {
            bool eventUpdated = false;


            return eventUpdated;
        }

    }
}
