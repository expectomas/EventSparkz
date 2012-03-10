using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2103Project.Entities
{
    class Schedule
    {
        //Items refer to inventory required for a single event
        public int scheduleId;
        public List<string> listOfItems;
        public List<Activity> activities;

        //Database Access Authetication
        private const string DatabaseToken = "642!e345";

        public Schedule()
        {
        }

        public Schedule(int i_scheduleId, List<string> i_listOfItems, List<Activity> i_activities)
        {
            scheduleId = i_scheduleId;
            listOfItems = i_listOfItems;
            activities = i_activities;
        }

        // Constructor Copy
        public Schedule(Schedule oldSchedule)
        {
            scheduleId = oldSchedule.scheduleId;
            listOfItems = oldSchedule.listOfItems;
            activities = oldSchedule.activities;
        }

        public int getScheduleID()
        {
            return scheduleId;
        }
        public bool requestScheduleDetail(ref int referredScheduleId, ref List<string> referredListOfItems, ref List<Activity> referredListOfActivities, string purpose)
        {
             bool releasedDetails = false;

             if (purpose.Equals("databaseRequest"))
             {
                 referredScheduleId = scheduleId;
                 referredListOfItems = listOfItems;
                 referredListOfActivities = activities;
                 releasedDetails = true;
             }
             else
             {
                 releasedDetails = false;
             }

            return releasedDetails;
        }
    }
}
