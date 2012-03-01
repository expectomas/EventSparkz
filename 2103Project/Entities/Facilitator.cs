using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2103Project.Entities
{
    class Facilitator : ActiveUser
    {
        //Attributes

        public List<EventEntity> facilitatingEvents;

        //Database Access Authetication
        private const string DatabaseToken = "5hfoipe@";

        //Methods

        public List<Participant> viewParticipantList()
        {

            List<Participant> allParticipants = new List<Participant>();

            return allParticipants;
        }
    }
}
