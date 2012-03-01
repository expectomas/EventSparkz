using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2103Project.Entities
{
    class Venue
    {
        private int venueId;
        private string location;

        //Constructor

        public Venue()
        {
        }

        public Venue(int i_venueId, string i_location) 
        {
            venueId = i_venueId;
            location = i_location;
        }

        public bool requestVenueDetails(ref int realisedId, ref string realisedLocation, string purpose)
        {
            bool releasedDetails = false;

           if(purpose.Equals("databaseRequest"))
            {
               realisedId = venueId;

               realisedLocation = location;

               releasedDetails = true;
            }

           return releasedDetails;
        }
    }
}
