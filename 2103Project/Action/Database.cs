using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using _2103Project.Entities;

namespace _2103Project.Action
{
    class Database : IDatabase
    {
        //Events Database Interaction Implementation
        public List<EventEntity> getListOfEvents()
        {
            List<EventEntity> listToPop = new List<EventEntity>();

            

            return listToPop;
        }
        public bool saveListOfEvents(List<EventEntity> eventListToSave)
        {
            bool savingSuccessFlag = false;



            return savingSuccessFlag;
        }

        //Schedules Database Interaction
        public List<Schedule> getListOfSchedule()
        {
            List<Schedule> listToPop = new List<Schedule>();


            return listToPop;
        }
        public bool saveListOfSchedule(List<Schedule> scheduleListToSave)
        {
            bool savingSuccessFlag = false;



            return savingSuccessFlag;
        }

        //Activities Database Interaction
        public List<Activity> getListOfActivities()
        {
            List<Activity> listToPop = new List<Activity>();


            return listToPop;
        }
        public bool saveListOfActivities(List<Activity> activityListToSave)
        {
            bool savingSuccessFlag = false;



            return savingSuccessFlag;

        }

        //Users Database Interaction
        public List<User> getListOfUsers()
        {
            List<User> listToPop = new List<User>();

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            using (XmlReader scanner = XmlReader.Create("users.xml", settings))
            {
                    scanner.MoveToContent();

                    scanner.ReadToDescendant("User");

                    do
                    {

                        scanner.ReadToDescendant("userId");

                        int userId = scanner.ReadElementContentAsInt();

                        string userName = scanner.ReadElementContentAsString("userName", "");

                        string name = scanner.ReadElementContentAsString("name", "");

                        string matricNo = scanner.ReadElementContentAsString("matricNo", "");

                        string pw = scanner.ReadElementContentAsString("password", "");

                        string em = scanner.ReadElementContentAsString("email", "");

                        int age = scanner.ReadElementContentAsInt();

                        bool loggedIn = scanner.ReadElementContentAsBoolean();

                        double HomeNum = scanner.ReadElementContentAsDouble();

                        double HPContact = scanner.ReadElementContentAsDouble();

                        User newlyReadUser = new User(userId, userName, name, matricNo, pw, em, age, loggedIn, HomeNum, HPContact);

                        listToPop.Add(newlyReadUser);

                    } while (scanner.ReadToNextSibling("User"));

            }

            return listToPop;
        }
        public bool saveListOfUsers(List<User> userListToSave)
        {
            bool savingSuccessFlag = false;



            return savingSuccessFlag;
        }

        //Venue Database Interaction
        public List<Venue> getListOfVenues()
        {
            List<Venue> listToPop = new List<Venue>();


            return listToPop;
        }
        public bool saveListOfVenues(List<Venue> venueListToSave)
        {
            bool savingSuccessFlag = false;



           return savingSuccessFlag;
        }

    }
}
