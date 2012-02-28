using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _2103Project.Entities;

namespace _2103Project.Action
{
    interface IDatabase
    {
        //Events Database Interaction
        List<EventEntity> getListOfEvents();
        bool saveListOfEvents(List<EventEntity> eventListToSave);

        //Schedules Database Interaction
        List<Schedule> getListOfSchedule();
        bool saveListOfSchedule(List<Schedule> scheduleListToSave);

        //Activities Database Interaction
        List<Activity> getListOfActivities();
        bool saveListOfActivities(List<Activity> activityListToSave);

        //Users Database Interaction
        List<User> getListOfUsers();
        bool saveListOfUsers(List<User> userListToSave);

        //Venue Database Interaction
        List<Venue> getListOfVenues();
        bool saveListOfVenues(List<Venue> venueListToSave);

    }
}
