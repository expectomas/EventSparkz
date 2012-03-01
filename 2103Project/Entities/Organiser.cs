using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2103Project.Entities
{
    class Organiser : ActiveUser
    {
        //Attributes
        public List<EventEntity> viewBookings;

         //Database Access Authetication
        private const string DatabaseToken = "9032!ds$";
        
        //Methods
        public bool createEvent()
        {
            bool eventCreated = false;


            return eventCreated;
        }

        public bool cancelEvent()
        {
            bool eventCancelled = false;



            return eventCancelled;
        }

        public bool updateEvent()
        {
            bool eventUpdated = false;


            return eventUpdated;
        }
       
    }
}
