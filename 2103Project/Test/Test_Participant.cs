using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _2103Project.Action;
using _2103Project.Entities;

namespace _2103test._2103Project.Test
{
    class Test_Participant
    {
        public bool Test_registerEvent()
        {
            bool testSuccess = false;
            const string DatabaseToken = "ewknf%32";

            Database db = Database.CreateDatabase(DatabaseToken);
            List<User> userlist = db.getListOfUsers();
            User theuser = userlist[1];
            Participant target = new Participant(theuser);

            db = Database.CreateDatabase(DatabaseToken);
            List<EventEntity> eventlist = db.getListOfEvents();
            EventEntity theEvent = eventlist[1];
            theEvent.setParticipantSize(50);
            if(EventEntity.getParticipantNumber(theEvent.getEventId())==49)
            {
                bool expected = true;
                bool actual;
                actual = target.registerEvent(theEvent);
                //assert
                if (expected == actual)
                    testSuccess = true;
                return testSuccess;
            }
            else
            {
                if (EventEntity.getParticipantNumber(theEvent.getEventId()) == 50)
                {
                    bool expected = false;
                    bool actual;
                    actual = target.registerEvent(theEvent);
                    //assert
                    if (expected == actual)
                        testSuccess = true;
                    return testSuccess;
                }
            }

            return testSuccess;
        }
    }
}