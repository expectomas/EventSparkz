using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _2103Project.Entities;

namespace _2103Project
{
    class Test
    {
        public Test() 
        { 
        }
                
        ActiveUser au = new ActiveUser();
        //Facilitator f = new Facilitator();
        Organiser o = new Organiser();
        Participant p = new Participant();

        public void testViewEventListing()
        {
            au.viewEventListing();
        }

        private void testViewEventListingByDate()
        {
            //au.viewEventListingByDate(...);
        }

        private void testViewEventListingByEventName()
        {
           //au.viewEventListingByEventName(...);
        }

        private void testViewEventInfo()
        {
            //au.viewEventInfo(...);
        }

        private void testViewParticipantList()
        {
            //f.viewParticipantList();
        }

        private void testCreateEvent()
        {
            //o.createEvent();
        }

        private void testCancelEvent()
        {
            //o.cancelEvent();
        }

        private void testUpdateEvent()
        {
            //o.updateEvent();
        }

        private void testRegisterEvent()
        {
            //p.registerEvent();
        }

        private void testCancelRegisteredEvent()
        {
            //p.cancelRegisteredEvent();
        }
    }
}
