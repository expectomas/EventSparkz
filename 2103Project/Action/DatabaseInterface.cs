﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _2103Project.Entities;

/*
 * Authors for this section
 * 
 *   Lim Zhi Hao A0067252H
 *   
 * 
 */

namespace _2103Project.Action
{
    interface IDatabase
    {
        //Events Database Interaction
        List<EventEntity> getListOfEvents();                            //Done
        bool saveListOfEvents(List<EventEntity> eventListToSave);       //Done

        //Schedules Database Interaction
        List<Schedule> getListOfSchedule();                             //Done
        bool saveListOfSchedule(List<Schedule> scheduleListToSave);     //Done

        //Activities Database Interaction
        List<Activity> getListOfActivities();                           //Done
        bool saveListOfActivities(List<Activity> activityListToSave);   //Done

        //Users Database Interaction
        List<User> getListOfUsers();                                    //Done
        bool saveListOfUsers(List<User> userListToSave);                //Done

        //Venue Database Interaction
        List<Venue> getListOfVenues();                                  //Done
        bool saveListOfVenues(List<Venue> venueListToSave);             //Done

        List<Budget> getListOfBudget();
        bool saveListOfBudgets(List<Budget> budgetListToSave);
    }
}
