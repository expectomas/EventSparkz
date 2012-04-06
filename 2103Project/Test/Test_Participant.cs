using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _2103Project.Entities;

namespace _2103test._2103Project.Test
{
    class Test_Participant
    {
        public bool Test_registerEvent(Participant testParticipant, EventEntity testEvent )
        {
            bool testSuccess = false;

            Participant target = testParticipant;
            EventEntity interestedEvent = testEvent;
            bool expected = true;
            bool actual;
            actual = target.registerEvent(interestedEvent);
            if (expected == actual)
                testSuccess = true;

            return testSuccess;
        }
    }
}