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
        private string requestString = "databaseRequest";


        //Events Database Interaction Implementation
        public List<EventEntity> getListOfEvents()
        {
            List<EventEntity> listToPop = new List<EventEntity>();
            List<Participant> participantList = new List<Participant>();

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            using (XmlReader scanner = XmlReader.Create("events.xml", settings))
            {
                scanner.MoveToContent();

                scanner.ReadToDescendant("EventEntity");

                do
                {
                    scanner.ReadToDescendant("eventId"); 

                    int eventId = scanner.ReadElementContentAsInt();

                    string eventDescription = scanner.ReadElementContentAsString("name", "");

                    DateTime startTime = scanner.ReadElementContentAsDateTime();

                    DateTime endTime = scanner.ReadElementContentAsDateTime();

                    int eventScheduleId = scanner.ReadElementContentAsInt();

                    int participantSize = scanner.ReadElementContentAsInt();

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

                        Participant newParticipant = new Participant(userId, userName, name, matricNo, pw, em, age, loggedIn, HomeNum, HPContact);

                        participantList.Add(newParticipant);

                    } while (scanner.ReadToNextSibling("User"));

                    scanner.Skip();

                    EventEntity newEvent = new EventEntity(eventId, eventDescription, startTime, endTime, eventScheduleId, participantSize, participantList);

                    listToPop.Add(newEvent);

                } while (scanner.ReadToNextSibling("EventEntity"));

            }
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
            List<string> scheduleItems = new List<string>();
            List<Activity> scheduleActivities = new List<Activity>();

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            using (XmlReader scanner = XmlReader.Create("schedules.xml", settings))
            {
                scanner.MoveToContent();

                scanner.ReadToDescendant("Schedule");

                do
                {
                    scanner.ReadToDescendant("scheduleId");

                    int scheduleId = scanner.ReadElementContentAsInt();

                    scanner.ReadToDescendant("item");

                    //GetAllItems
                    do
                    {
                
                        scheduleItems.Add(scanner.ReadElementContentAsString("item",""));

                    } while (scanner.NodeType!=XmlNodeType.EndElement);

                    scanner.Skip();

                    scanner.ReadToDescendant("Activity");

                    do
                    {
                        scanner.ReadToDescendant("activityId");

                        int activityId = scanner.ReadElementContentAsInt();

                        DateTime time = scanner.ReadElementContentAsDateTime();

                        string activityDescription = scanner.ReadElementContentAsString("description", "");

                        scanner.ReadToFollowing("venueId");

                        int i_venueId = scanner.ReadElementContentAsInt();

                        string i_location = scanner.ReadElementContentAsString("location", "");

                        Venue newVenue = new Venue(i_venueId, i_location);

                        Activity newActivity = new Activity(activityId, time, activityDescription, newVenue);

                        scheduleActivities.Add(newActivity);

                        //Skip end element till /activity end tag
                        scanner.Skip();
                        scanner.Skip();

                    } while (scanner.ReadToNextSibling("Activity"));

                    Schedule newSchedule = new Schedule(scheduleId, scheduleItems, scheduleActivities);

                    listToPop.Add(newSchedule);

                    //Skip /activity end tag
                    scanner.Skip();

                    //Clear both list
                    scheduleItems.Clear();
                    scheduleActivities.Clear();

                }while(scanner.ReadToNextSibling("Schedule"));
            }

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

             XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            using (XmlReader scanner = XmlReader.Create("activities.xml", settings))
            {
                scanner.MoveToContent();

                scanner.ReadToDescendant("Activity");

                do
                {
                    scanner.ReadToDescendant("activityId");

                    int activityId = scanner.ReadElementContentAsInt();

                    DateTime time = scanner.ReadElementContentAsDateTime();

                    string activityDescription = scanner.ReadElementContentAsString("description", "");

                    scanner.ReadToFollowing("venueId");

                    int i_venueId = scanner.ReadElementContentAsInt();

                    string i_location = scanner.ReadElementContentAsString("location", "");

                    Venue newVenue = new Venue(i_venueId, i_location);

                    Activity newActivity = new Activity(activityId, time, activityDescription, newVenue);

                    listToPop.Add(newActivity);

                    //Skip end element till /activity end tag
                    scanner.Skip();
                    scanner.Skip();

                } while (scanner.ReadToNextSibling("Activity"));
            }

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

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            using (XmlReader scanner = XmlReader.Create("venues.xml", settings))
            {
                //Move scanner to content 
                scanner.MoveToContent();

                scanner.ReadToDescendant("Venue");

                do
                {
                    scanner.ReadToDescendant("venueId");

                    int i_venueId = scanner.ReadElementContentAsInt();

                    string i_location = scanner.ReadElementContentAsString("location","");

                    Venue newVenue = new Venue(i_venueId, i_location);

                    listToPop.Add(newVenue);

                } while (scanner.ReadToNextSibling("Venue"));

            }

            return listToPop;
        }
        public bool saveListOfVenues(List<Venue> venueListToSave)
        {
           bool savingSuccessFlag = false;

           int sizeOfList = venueListToSave.Count;

           XmlWriterSettings writerSettings = new XmlWriterSettings();
           writerSettings.Indent = true;

           Venue holdingElement;
           
           try
           {
               using(XmlWriter writer = XmlTextWriter.Create("venues.xml", writerSettings))
               {
                    writer.WriteStartDocument();

                    writer.WriteStartElement("VenuePool");

                    for (int i = 0; i < sizeOfList; i++)
                    {
                        writer.WriteStartElement("Venue");

                        holdingElement = venueListToSave[i];

                        int venueId = 0;
                        string venueLo = "";

                        //Passing venueId and venueLo as Referene
                        holdingElement.requestVenueDetails(ref venueId,ref venueLo,requestString);

                        //Write Element Contents
                        writer.WriteElementString("venueId",venueId.ToString());

                        writer.WriteElementString("location", venueLo);

                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();

                    writer.WriteEndDocument();
               }


           }
           catch (Exception ex)
           {
               savingSuccessFlag = false;
           }

           savingSuccessFlag = true;

           return savingSuccessFlag;
        }

    }
}
