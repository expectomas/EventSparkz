using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2103Project.Entities
{
    class ActiveUser:User
    {
        //Attributes 
        
        //Methods
        public EventEntity viewEventInfo(){
            
            EventEntity eventInfo = new EventEntity();

            return eventInfo;
        }

        public List<EventEntity> viewEventListing(){
            List<EventEntity> eventListing = new List<EventEntity>();

            return eventListing;
        }

        public List<EventEntity> viewEventListingByDate(DateTime selectedDateTime){
            List<EventEntity> eventListing = new List<EventEntity>();

            return eventListing;
        }

        public List<EventEntity> viewEventListingByEventName(){
            List<EventEntity> eventListing = new List<EventEntity>();

            return eventListing;
        }
        public EventEntity searchEvent()
        {
            EventEntity eventInfo = new EventEntity();

            return eventInfo;
        }
    }
}
