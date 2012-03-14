using System;
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
    class EventEntity
    {
        public enum EventInfoStates
        {
            registeredParticipant, unregisteredActiveUser,
            facilitator, organiser
        };

        //Attributes
        private int eventId;
        private string name;
        private DateTime startTime;
        private DateTime endTime;
        private int eventScheduleId;
        private int participantSize;
        private List<Participant> participantList;
        private int eventOrganiserId;
        private List<int> facilitatorList;

        //Database Access Authetication
        private const string DatabaseToken = "431fW13x";

        //Constructors
        public EventEntity()
        {

        }

        public EventEntity(int i_eventId, string i_name, DateTime i_startTime, DateTime i_endTime, int i_eventScheduleId, int i_participantSize, List<Participant> i_participantList, List<int> i_facilitatorIdList, int i_eventOrganiserId)
        {
            eventId = i_eventId;
            name = i_name;
            startTime = i_startTime;
            endTime = i_endTime;
            eventScheduleId = i_eventScheduleId;
            participantSize = i_participantSize;
            participantList = new List<Participant>(i_participantList);
            facilitatorList = new List<int>(i_facilitatorIdList);
            eventOrganiserId = i_eventOrganiserId;
        }

        //Methods

        public static EventEntity getEventFromEventId(int eventId)
        {
            Database db = Database.CreateDatabase(DatabaseToken);
            List<EventEntity> listOfEvents = db.getListOfEvents();

            for (int i = 0; i < listOfEvents.Count; i++)
            {
                if (listOfEvents[i].getEventId() == eventId)
                    return listOfEvents[i];
            }

            return null;
        }

        public string getEventName()
        {
            return name;
        }

        public int getEventId()
        {
            return eventId;
        }

        public int getOrganiserID()
        {
            return eventOrganiserId;
        }

        public int getScheduleID()
        {
            return eventScheduleId;
        }

        public DateTime getEventDate()
        {
            return startTime;
        }

        public int getEventDurationByHr()
        {
            int timeDuration = (endTime - startTime).Hours;

            return timeDuration;
        }

        public List<Participant> getParticipantList()
        {
            return participantList;
        }

        public int getParticipatSize()
        {
            return participantSize;
        }

        public void setPartipantSize(int partNum)
        {
            participantSize = partNum;
        }
        public bool addParticipantToEvent(Participant newParticipant)
        {
            bool successAdded = false;
            try
            {
                participantList.Add(newParticipant);
                successAdded = true;
            }
            catch (Exception ex)
            {
                successAdded = false;
            }

            return successAdded;
        }

        public bool removeParticipantFromEvent(Participant unInterestedParticipant)
        {
            bool successRemoved = true;
            int i = 0;

            try
            {
                foreach (Participant alreadyRegistered in this.participantList)
                {
                    if (alreadyRegistered.getUserId().Equals(unInterestedParticipant.getUserId()))
                    {
                        participantList.RemoveAt(i);
                        ++i;
                    }
                }
            }
            catch (Exception ex)
            {
                successRemoved = false;
            }

            return successRemoved;
        }

        public bool addFacilitatorToEvent(int newFacilitatorId)
        {
            try
            {
                facilitatorList.Add(newFacilitatorId);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool removeFacilitatorFromEvent(int removingFacilitatorId)
        {
            bool successRemoved = false;

            try
            {
                for (int i = 0; i < facilitatorList.Count; i++)
                {
                    if (removingFacilitatorId == facilitatorList[i])
                    {
                        facilitatorList.RemoveAt(i);
                        successRemoved = true;

                    }
                }
            }
            catch (Exception ex)
            {
                successRemoved = false;
            }

            return successRemoved;
        }

        public static int getParticipantNumber(int eventID)
        {
            int totalParticipateNumber = 0;
            Database db = Database.CreateDatabase(DatabaseToken);
            List<EventEntity> listOfEvents = db.getListOfEvents();
            foreach (EventEntity eve in listOfEvents)
            {
                if (eve.getEventId() == eventID)
                    totalParticipateNumber = eve.getParticipatSize();
            }
            return totalParticipateNumber;
        }

        public static DateTime getStartTime(int eventID)
        {
            DateTime startTime = DateTime.Now;
            Database db = Database.CreateDatabase(DatabaseToken);
            List<EventEntity> listOfEvents = db.getListOfEvents();
            foreach (EventEntity eve in listOfEvents)
            {
                if (eve.getEventId() == eventID)
                    startTime = eve.getEventDate();
            }
            return startTime;
        }

        public static string getStartVenueFromEventID(int eventID)
        {
            Venue startVenue;
            int scheduleId = 1;
            Database db = Database.CreateDatabase(DatabaseToken);
            List<EventEntity> listOfEvents = db.getListOfEvents();
            foreach (EventEntity eve in listOfEvents)
            {
                if (eve.getEventId() == eventID)
                    scheduleId = eve.getScheduleID();
            }
            List<Activity> listOfActivity = Schedule.retrieveListOfActivityfromScheduleID(scheduleId);
            int state = 0, activityId = 1;
            foreach (Activity act in listOfActivity)
            {
                if (state == 0)
                {
                    activityId = act.getActivityId();
                    state = 1;
                }
            }
            startVenue = Activity.getVenueFromActivityID(activityId);
            return startVenue.getlocation();
        }

        public static Queue<string> getListOfVenueFromEventID(int eventID)
        {
            int scheduleId = 1;
            Queue<string> queueStrVenue = new Queue<string>();
            Database db = Database.CreateDatabase(DatabaseToken);
            List<EventEntity> listOfEvents = db.getListOfEvents();
            foreach (EventEntity eve in listOfEvents)
            {
                if (eve.getEventId() == eventID)
                    scheduleId = eve.getScheduleID();
            }
            List<Activity> listOfActivity = Schedule.retrieveListOfActivityfromScheduleID(scheduleId);
            Queue<int> listOfActivityID = new Queue<int>();
            foreach (Activity act in listOfActivity)
            {
                listOfActivityID.Enqueue(act.getActivityId());
            }
            List<Activity> listOfActDb = db.getListOfActivities();
            Queue<Venue> listOfVenue = new Queue<Venue>();
            foreach (Activity act in listOfActDb)
            {
                if (listOfActivityID.Count != 0)
                {
                    if (act.getActivityId() == listOfActivityID.Peek())
                    {
                        listOfVenue.Enqueue(act.getVenue());
                        listOfActivityID.Dequeue();
                    }
                }
            }
            List<Venue> listOfVenueDb = db.getListOfVenues();
            while (listOfVenue.Count != 0)
            {
                for (int i = 0; i < listOfVenueDb.Count; i++)
                {
                    if (listOfVenue.Peek().getVenueId() == listOfVenueDb[i].getVenueId())
                    {
                        queueStrVenue.Enqueue(listOfVenue.Dequeue().getlocation());
                        break;
                    }
                }
            }
            return queueStrVenue;
        }

        public static Queue<string> getListOfDescriptionFromEventID(int eventID)
        {
            int scheduleId = 1;
            Queue<string> listOfDesc = new Queue<string>();
            Database db = Database.CreateDatabase(DatabaseToken);
            List<EventEntity> listOfEvents = db.getListOfEvents();
            foreach (EventEntity eve in listOfEvents)
            {
                if (eve.getEventId() == eventID)
                    scheduleId = eve.getScheduleID();
            }
            List<Activity> listOfActivity = Schedule.retrieveListOfActivityfromScheduleID(scheduleId);
            foreach (Activity act in listOfActivity)
            {
                listOfDesc.Enqueue(act.getDescription());
            }
            return listOfDesc;
        }

        public static Queue<DateTime> getListOfTimeFromEventID(int eventID)
        {
            int scheduleId = 1;
            Queue<DateTime> listOfDate = new Queue<DateTime>();
            Database db = Database.CreateDatabase(DatabaseToken);
            List<EventEntity> listOfEvents = db.getListOfEvents();
            foreach (EventEntity eve in listOfEvents)
            {
                if (eve.getEventId() == eventID)
                    scheduleId = eve.getScheduleID();
            }
            List<Activity> listOfActivity = Schedule.retrieveListOfActivityfromScheduleID(scheduleId);
            foreach (Activity act in listOfActivity)
            {
                listOfDate.Enqueue(act.getDate());
            }
            return listOfDate;
        }

        public bool doesParticipantExist(int i_userId)
        {
            for (int i = 0; i < participantList.Count; i++)
            {
                if (participantList[i].getUserId() == i_userId)
                {
                    return true;
                }

            }
            return false;
        }

        public bool doesOrganiserExist(int i_userId)
        {
            if (eventOrganiserId == i_userId)
            {
                return true;
            }
            else
                return false;
        }

        public bool doesFacilitatorExist(int i_userId)
        {
            for (int i = 0; i < facilitatorList.Count; i++)
            {
                if (facilitatorList[i] == i_userId)
                {
                    return true;
                }
            }
            return false;
        }

        public bool requestEventEntitiyDetails(ref int o_eventId, ref string o_name, ref DateTime o_startTime, ref DateTime o_endTime, ref int o_eventScheduleId, ref int o_participantSize, ref List<Participant> o_participantList, ref List<int> o_facilitatorList, ref int o_organiserId, string purpose)
        {
            if (purpose.Equals("databaseRequest"))
            {
                o_eventId = eventId;
                o_name = name;
                o_startTime = startTime;
                o_endTime = endTime;
                o_eventScheduleId = eventScheduleId;
                o_participantSize = participantSize;
                o_participantList = new List<Participant>(participantList);
                o_facilitatorList = new List<int>(facilitatorList);
                o_organiserId = eventOrganiserId;

                return true;
            }
            else
                return false;
        }

        public static bool setParticipantNumFromEventID(int currentEventID, int participantSize)
        {
            Database db = Database.CreateDatabase(DatabaseToken);
            List<EventEntity> listOfEvent = db.getListOfEvents();
            foreach (EventEntity events in listOfEvent)
            {
                if (events.getEventId() == currentEventID)
                    events.setPartipantSize(participantSize);
            }
            db.saveListOfEvents(listOfEvent);
            return true;
        }

        public static bool setSchedule(int currentEventID, List<DateTime> listOfDateTime, List<string> listOfdescription, List<Venue> listOfVenue)
        {
            int scheduleId = 1;
            Database db = Database.CreateDatabase(DatabaseToken);
            List<EventEntity> listOfEvent = db.getListOfEvents();
            foreach (EventEntity events in listOfEvent)
            {
                if (currentEventID == events.getEventId())
                    scheduleId = events.getScheduleID();
            }
            List<Schedule> listOfSchedule = db.getListOfSchedule();
            List<Activity> listOfActivity = new List<Activity>();
            foreach (Schedule sch in listOfSchedule)
            {
                if (scheduleId == sch.getScheduleID())
                    listOfActivity = sch.getlistOfActivity();
            }
            Queue<Activity> queueActivity = new Queue<Activity>();
            Activity act;
            for( int i = 0; i < listOfActivity.Count ; i++)
            {
                act = listOfActivity[i];
                queueActivity.Enqueue(act);
                act.setDateTime(listOfDateTime[i]);
                act.setDescription(listOfdescription[i]);
                act.setVenue(listOfVenue[i]);
            }
            db.saveListOfSchedule(listOfSchedule);
            List<Activity> lisotOfActDB = db.getListOfActivities();
            foreach(Activity actDB in lisotOfActDB)
            {
                if (queueActivity.Count != 0)
                {
                    if (actDB.getActivityId() == queueActivity.Peek().getActivityId())
                    {
                        actDB.setDateTime(queueActivity.Peek().getDate());
                        actDB.setDescription(queueActivity.Peek().getDescription());
                        actDB.setVenue(queueActivity.Peek().getVenue());
                        queueActivity.Dequeue();
                    }
                }
            }
            db.saveListOfActivities(lisotOfActDB);

            return true;
        }

        public EventInfoStates determineUserState(int i_userId)
        {
            if (doesParticipantExist(i_userId))
            {
                return EventInfoStates.registeredParticipant;
            }
            else if (doesFacilitatorExist(i_userId))
            {
                return EventInfoStates.facilitator;
            }
            else if (doesOrganiserExist(i_userId))
            {
                return EventInfoStates.organiser;
            }
            return EventInfoStates.unregisteredActiveUser;
        }

        public List<int> getListOfFacilitator()
        {
            return facilitatorList;
        }
    }
}
