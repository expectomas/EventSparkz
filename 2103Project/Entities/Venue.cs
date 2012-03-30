using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _2103Project.Action;

/*
 * Authors for this section
 * 
 *   Lim Zhi Hao A0067252H
 *   Tio Wee Leong A0073702M
 * 
 */

namespace _2103Project.Entities
{
    class Venue
    {
        private int venueId;
        private string location;
        private int capacity;

        //Database Access Authetication
        private const string DatabaseToken = "nhgdkc#1";

        //Constructor

        public Venue()
        {
        }

        public Venue(int i_venueId, string i_location) 
        {
            venueId = i_venueId;
            location = i_location;
        }

        //Copy Constructor

        public Venue(Venue oldVenue)
        {
            venueId = oldVenue.venueId;
            location = oldVenue.location;
        }

        public int getVenueId()
        {
            return venueId;
        }

        public string getlocation()
        {
            return location;
        }

        public int getCapacity()
        {
            return capacity;
        }

        public static int getVenueIdfromLocation(string venue)
        {
            int venueID = 1;
            Database db = Database.CreateDatabase(DatabaseToken);
            List<Venue> listOfvenue = db.getListOfVenues();
            foreach (Venue ven in listOfvenue)
            {
                if (venue.Equals(ven.getlocation()))
                    venueID = ven.getVenueId();
            }
            return venueID;
        }

        public static string getVenueLocationfromID(int venueIdentity)
        {
            string venueLocation = "MPSH1";
            Database db = Database.CreateDatabase(DatabaseToken);
            List<Venue> listOfvenue = db.getListOfVenues();
            foreach (Venue ven in listOfvenue)
            {
                if (venueIdentity == ven.getVenueId())
                    venueLocation = ven.getlocation();
            }
            return venueLocation;
        }

        public static int getVenueCapacity(int venuecap)
        {
            int venueCapacity = venuecap;
            Database db = Database.CreateDatabase(DatabaseToken);
            List<Venue> listOfvenue = db.getListOfVenues();
            foreach (Venue ven in listOfvenue)
            {
                if (venueCapacity == ven.getCapacity())
                    venueCapacity = ven.getCapacity();
            }
            return venueCapacity;
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
