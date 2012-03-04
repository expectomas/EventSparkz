using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _2103Project.Action;

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
            //Establish database linkage
            IDatabase db = Database.CreateDatabase(DatabaseToken);

            List<Participant> allParticipants = new List<Participant>();

            

            return allParticipants;
        }
    }
}
