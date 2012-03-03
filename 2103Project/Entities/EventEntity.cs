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

            try
            {
                foreach (Participant alreadyRegistered in this.participantList)
                {
                    if (alreadyRegistered.Equals(unInterestedParticipant))
                    {
                        participantList.Remove(alreadyRegistered);
                    }
                }
            }
            catch (Exception ex)
            {
                successRemoved = false;
            }

            return successRemoved;
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
