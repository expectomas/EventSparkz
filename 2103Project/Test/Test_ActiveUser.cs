using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _2103Project.Entities;

namespace _2103Project.Test
{
    class Test_ActiveUser
    {
        //Test Data
        private List<string> _testData = new List<string>();
        private List<string> _expectedListOfNames = new List<string>();

        public Test_ActiveUser()
        {
            _testData.Add("abcd");
            _testData.Add("Flag");
            _testData.Add("Walk");
            _expectedListOfNames.Add("abcdefghijklmnopqrstuvwxyz");
            _expectedListOfNames.Add("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            _expectedListOfNames.Add("NUS Rag and Flag");
            _expectedListOfNames.Add("Flag Day 2012");
            _expectedListOfNames.Add("Walkathon");
            _expectedListOfNames.Add("WalkADog");
        }

        public bool viewEventListingByEventNameTest()
        {
            bool testResult = false;

            ActiveUser target = new ActiveUser();

            foreach(string testData in _testData)
            {
                string word = testData; // Test Case HERE
                List<EventEntity> actual = new List<EventEntity>();
                actual = target.viewEventListingByEventName(word);

                //Assert
                // List of names of actual events
                foreach(EventEntity events in actual)
                {
                    if (this._expectedListOfNames.Contains(events.getEventName()))
                    {
                        testResult = true;
                    }
                    else
                    {
                        testResult = false;
                    }
                }
            }

            return testResult;

        } 
    }
}
