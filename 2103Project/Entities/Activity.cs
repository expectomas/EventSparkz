using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _2103Project.Action;

namespace _2103Project.Entities
{
    class Activity
    {
        private int activityId;
        private DateTime time;
        private string description;
        private Venue hostingVenue;

        //Database Access Authetication
        private const string DatabaseToken = "r$32Hgvc";

        public Activity()
        {

        }

        public Activity(int i_activityId, DateTime i_datetime, string i_description, Venue i_hostingVenue)
        {
            activityId = i_activityId;
            time = i_datetime;
            description = i_description;
            hostingVenue = i_hostingVenue;
        }

        public int getActivityId()
        {
            return activityId;
        }

        public Venue getVenue()
        {
            return hostingVenue;
        }

        public static Venue getVenueFromActivityID(int incomingActivityID)
        {
            Database db = Database.CreateDatabase(DatabaseToken);
            List<Activity> listOfActDb = db.getListOfActivities();
            Venue newVen = new Venue();
            foreach (Activity act in listOfActDb)
            {
                if (act.getActivityId() == incomingActivityID)
                    newVen = act.getVenue();
            }
            return newVen;
        }
        public bool requestActivityDetails(ref int o_activityId,ref DateTime sending_datetime,ref string sending_description,ref Venue sending_hostingVenue, string purpose)
        {
            if (purpose.Equals("databaseRequest"))
            {
                o_activityId = activityId;
                sending_datetime = time;
                sending_description = description;
                sending_hostingVenue = new Venue(hostingVenue);
                return true;
            }
            else
                return false;
        }

        
    }
}
