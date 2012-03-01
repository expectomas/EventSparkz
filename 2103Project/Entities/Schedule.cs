﻿using System;
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

        public Schedule()
        {
        }

        public Schedule(int i_scheduleId, List<string> i_listOfItems, List<Activity> i_activities)
        {
            scheduleId = i_scheduleId;
            listOfItems = i_listOfItems;
            activities = i_activities;
        }
    }
}