using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2103Project.Entities
{
    class EventEntity
    {
        //Attributes
        private int eventId;
        private string name;
        private DateTime startTime;
        private DateTime endTime;
        private int eventScheduleId;
        private int participantSize;
        private List<Participant> participantList;

        //Database Access Authetication
        private const string DatabaseToken = "431fW13x";

        //Methods

        public string getEventName()
        {
            return name;
        }

        public int getEventId()
        {
            return eventId;
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

        public EventEntity()
        {
        }

        public EventEntity(int i_eventId, string i_name, DateTime i_startTime, DateTime i_endTime, int i_eventScheduleId, int i_participantSize, List<Participant> i_participantList)
        {
            eventId = i_eventId;
            name = i_name;
            startTime = i_startTime;
            endTime = i_endTime;
            eventScheduleId = i_eventScheduleId;
            participantSize = i_participantSize;
            participantList = i_participantList;
        }

    }
}
