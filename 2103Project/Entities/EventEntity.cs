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
        private int eventOrganiserId;
        private List<int> facilitatorList;

        //Database Access Authetication
        private const string DatabaseToken = "431fW13x";

        //Constructors

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

        public bool requestEventEntitiyDetails(ref int o_eventId, ref string o_name, ref DateTime o_startTime, ref DateTime o_endTime, ref int o_eventScheduleId, ref int o_participantSize, ref List<Participant> o_participantList, ref List<int> o_facilitatorList,ref int o_organiserId, string purpose)
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
    }
}
