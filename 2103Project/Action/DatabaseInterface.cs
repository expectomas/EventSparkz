using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using _2103Project.Entities;

namespace _2103Project.Action
{
    interface IDatabase
    {
        //Events Database Interaction
        List<EventEntity> getListOfEvents();                        //Done
        bool saveListOfEvents(List<EventEntity> eventListToSave);
        void createEvent(int eventId, string eventName, DateTime startTime, DateTime endTime, int eventScheduleId, int participantSize);
        void loadListOfEvent(Queue<string> listOfEvents);
        void deleteEvent(string selectedEventName);

        //Schedules Database Interaction
        List<Schedule> getListOfSchedule();                         //Done
        bool saveListOfSchedule(List<Schedule> scheduleListToSave);

        //Activities Database Interaction
        List<Activity> getListOfActivities();                       //Done
        bool saveListOfActivities(List<Activity> activityListToSave);

        //Users Database Interaction
        List<User> getListOfUsers();                                //Done
        bool saveListOfUsers(List<User> userListToSave);            //Done
        void writeFirstToXml(XmlTextWriter textWriter, int userId, string username, string name, string matricNo, string password, string email, int age, bool loggedIn, double contactHome, double contactHP);
        void writeExistToXml(XmlReader reader, int userId, string username, string name, string matricNo, string password, string email, int age, bool loggedIn, double contactHome, double contactHP);
        bool checkUsernameExist(string username);
        int getLastID();

        //Venue Database Interaction
        List<Venue> getListOfVenues();                              //Done
        bool saveListOfVenues(List<Venue> venueListToSave);         //Done

    }
}
