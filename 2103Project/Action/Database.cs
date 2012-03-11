using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using _2103Project.Entities;

/*
 * Authors for this section
 * 
 *   Lim Zhi Hao A0067252H
 *   Tio Wee Leong A0073702M
 * 
 */

namespace _2103Project.Action
{
    class Database : IDatabase
    {
        //Static Database Instance (Singleton)

        private static Database instance;

        //Database Attribute
        private string requestString = "databaseRequest";
        
        //Database Access Authetication
        private const string ActiveUserToken = "3e#rtfGc";
        private const string ActivityToken = "r$32Hgvc";
        private const string EventEntityToken = "431fW13x";
        private const string FacilitatorToken = "5hfoipe@";
        private const string OrganiserToken = "9032!ds$";
        private const string ParticipantToken = "cd#ew1Tf";
        private const string ScheduleToken = "642!e345";
        private const string UserToken = "ewknf%32";
        private const string VenueToken = "nhgdkc#1";
         
        private Database()
        {

        }

        //Singleton Concept : Lazy instantiation using double locking mechanism 
        public static Database CreateDatabase(string tokenRequired)
        {
            if (instance == null)
            {
                switch (tokenRequired)
                {
                    case ActiveUserToken:
                        instance =  new Database();
                        break;
                    case ActivityToken:
                        instance =  new Database();
                        break;
                    case EventEntityToken:
                        instance = new Database();
                        break;
                    case FacilitatorToken:
                        instance = new Database();
                        break;
                    case OrganiserToken:
                        instance = new Database();
                        break;
                    case ParticipantToken:
                        instance = new Database();
                        break;
                    case ScheduleToken:
                        instance = new Database();
                        break;
                    case UserToken:
                        instance = new Database();
                        break;
                    case VenueToken:
                        instance = new Database();
                        break;
                }
            }

            return instance;
        }

        //Events Database Interaction Implementation
        public List<EventEntity> getListOfEvents()
        {
            List<EventEntity> listToPop = new List<EventEntity>();
            List<Participant> participantList = new List<Participant>();

            List<int> facilitatorList = new List<int>();

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

                    int organiserId = scanner.ReadElementContentAsInt();

                    if (scanner.ReadToDescendant("User"))
                    {

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

                    }

                    scanner.Skip();

                    if (scanner.ReadToDescendant("User"))
                    {
                        do
                        {
                            scanner.ReadToDescendant("userId");

                            int facilitatorId = scanner.ReadElementContentAsInt();

                            facilitatorList.Add(facilitatorId);

                        } while (scanner.ReadToNextSibling("User"));
                    }

                    scanner.Skip();

                    EventEntity newEvent = new EventEntity(eventId, eventDescription, startTime, endTime, eventScheduleId, participantSize, participantList,facilitatorList,organiserId);

                    participantList.Clear();
                    facilitatorList.Clear();

                    listToPop.Add(newEvent);

                } while (scanner.ReadToNextSibling("EventEntity"));

            }
            return listToPop;
        }
        public bool saveListOfEvents(List<EventEntity> eventListToSave)
        {
            bool savingSuccessFlag = false;

            //Event Attributes
            int o_eventId=0;
            string o_name="";
            DateTime o_startTime=DateTime.Now; 
            DateTime o_endTime=DateTime.Now; 
            int o_eventScheduleId=0;
            int o_participantSize=0;
            int o_organiserId = 0;
            List<Participant> o_participantList = new List<Participant>();
            List<int> o_facilitatorList = new List<int>();

            //Participant Attributes
             int o_userId =0 ;
            string o_userName ="";
            string o_participantName = "";
            string o_matricNo = "";
            string o_password = "";
            string o_email = "";
            int o_age = 0;
            bool o_loggedIn = false;
            double o_contactHome = 0;
            double o_hPContact = 0;

            int sizeOfList = eventListToSave.Count();

            XmlWriterSettings writerSettings = new XmlWriterSettings();
            writerSettings.Indent = true;

            EventEntity holdingElement;
            Participant holdingParticipant;
            int participantCounter = 0;
            int facilitatorCounter = 0;

            try
            {
                using (XmlWriter writer = XmlTextWriter.Create("events.xml", writerSettings))
                {
                    writer.WriteStartDocument();

                    writer.WriteStartElement("EventPool");

                    for (int i = 0; i < sizeOfList; i++)
                    {
                        holdingElement = eventListToSave[i];
                        holdingElement.requestEventEntitiyDetails(ref o_eventId, ref o_name, ref o_startTime, ref o_endTime, ref o_eventScheduleId, ref o_participantSize, ref o_participantList, ref o_facilitatorList, ref o_organiserId, requestString);

                        writer.WriteStartElement("EventEntity");

                        writer.WriteElementString("eventId", o_eventId.ToString());

                        writer.WriteElementString("name", o_name);

                        writer.WriteElementString("startTime", o_startTime.ToString("s"));

                        writer.WriteElementString("endTime", o_endTime.ToString("s"));

                        writer.WriteElementString("eventScheduleId", o_eventScheduleId.ToString());

                        writer.WriteElementString("participantSize", o_participantSize.ToString());

                        writer.WriteElementString("organiserId", o_organiserId.ToString());

                        //List of Participants
                        writer.WriteStartElement("participantList");

                        //Use while loop because there might be no participants
                        while(participantCounter<o_participantList.Count)
                        {
                            holdingParticipant = o_participantList[participantCounter];
                            holdingParticipant.requestUserDetail(ref o_userId, ref o_userName, ref o_participantName, ref o_matricNo, ref o_password, ref o_email
                                                        , ref o_age, ref o_loggedIn, ref o_contactHome, ref o_hPContact, requestString);

                            writer.WriteStartElement("User");

                            writer.WriteElementString("userId", o_userId.ToString());
                            writer.WriteElementString("userName", o_userName);
                            writer.WriteElementString("name", o_participantName);
                            writer.WriteElementString("matricNo", o_matricNo.ToString());
                            writer.WriteElementString("password", o_password);
                            writer.WriteElementString("email", o_email);
                            writer.WriteElementString("age", o_age.ToString());
                            writer.WriteElementString("loggedIn", o_loggedIn.ToString().ToLower());
                            writer.WriteElementString("contactHome", o_contactHome.ToString());
                            writer.WriteElementString("contactHP", o_hPContact.ToString());

                            writer.WriteEndElement();

                            ++participantCounter;
                        }

                        participantCounter = 0;

                        //End Tag Participant List
                        writer.WriteEndElement();

                        writer.WriteStartElement("facilitatorList");

                        while (facilitatorCounter < o_facilitatorList.Count)
                        {
                            writer.WriteStartElement("User");

                            writer.WriteElementString("userId", o_facilitatorList[facilitatorCounter].ToString());

                            writer.WriteEndElement();

                            ++facilitatorCounter;
                        }

                        facilitatorCounter = 0;

                        //End Tag Faciltator List

                        writer.WriteEndElement();

                        //End Tag Event entity

                        writer.WriteEndElement();
                    }


                    writer.WriteEndElement();
                }

                savingSuccessFlag = true;
            }
            catch (Exception ex)
            {
                savingSuccessFlag = false;
            }


            return savingSuccessFlag;
        }

        //Schedules Database Interaction Implementation
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
                    while (scanner.Name!="listOfItems")
                    {
                
                        scheduleItems.Add(scanner.ReadElementContentAsString("item",""));

                    } 

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

                    //Clone Two new list

                    List<string> clonedItemList = new List<string>(scheduleItems);
                    List<Activity> clonedActivityList = new List<Activity>(scheduleActivities);

                    Schedule newSchedule = new Schedule(scheduleId, clonedItemList,clonedActivityList);

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

            //Schedule Attributes
            int o_scheduleId = 0;
            List<string> o_listOfItems = new List<string>();
            List<Activity> o_Activities = new List<Activity>();

            //Activity Attributes
            int o_activityId = 0;
            DateTime o_time = DateTime.Now;
            string o_description = "";
            Venue o_venue = new Venue();

            //Venue Attributes
            int o_venueId = 0;
            string o_venueDescription = "";

            int sizeOfList = scheduleListToSave.Count();

            XmlWriterSettings writerSettings = new XmlWriterSettings();
            writerSettings.Indent = true;

            Schedule holdingElement;
            int itemsCounter = 0;
            int activitiesCounter = 0;

            try
            {
                using (XmlWriter writer = XmlTextWriter.Create("schedules.xml", writerSettings))
                {
                    writer.WriteStartDocument();

                    writer.WriteStartElement("SchedulePool");

                    for (int i = 0; i < sizeOfList; i++)
                    {
                        holdingElement = scheduleListToSave[i];
                        holdingElement.requestScheduleDetail(ref o_scheduleId,ref o_listOfItems,ref o_Activities, requestString);

                        //Schedule Details

                        writer.WriteStartElement("Schedule");

                        writer.WriteElementString("scheduleId",o_scheduleId.ToString());

                        //Process List of Items

                        writer.WriteStartElement("listOfItems");
                        while(itemsCounter<o_listOfItems.Count)
                        {
                            writer.WriteElementString("item", o_listOfItems[itemsCounter]);
                            ++itemsCounter;
                        }
                        itemsCounter = 0;
                        writer.WriteEndElement();

                        //Process Activities

                        writer.WriteStartElement("listOfActivities");
                        while (activitiesCounter < o_Activities.Count) 
                        {
                            o_Activities[activitiesCounter].requestActivityDetails(ref o_activityId, ref o_time, ref o_description, ref o_venue, requestString);

                            writer.WriteStartElement("Activity");

                            //Activity Details
                            writer.WriteElementString("activityId", o_activityId.ToString());
                            writer.WriteElementString("time", o_time.ToString("s"));
                            writer.WriteElementString("description", o_description);

                            //Contains one Venue class

                            writer.WriteStartElement("hostingVenue");

                            o_venue.requestVenueDetails(ref o_venueId, ref o_venueDescription, requestString);

                            writer.WriteStartElement("Venue");
                            writer.WriteElementString("venueId", o_venueId.ToString());
                            writer.WriteElementString("location", o_venueDescription);
                            writer.WriteEndElement();

                            //EndTag hosting Venue
                            writer.WriteEndElement();


                            //EndTag Activity

                            writer.WriteEndElement();

                            ++activitiesCounter;
                        } 
                        activitiesCounter = 0;

                        writer.WriteEndElement();

                        //Write End Tag for Schedule

                        writer.WriteEndElement();
                    }

                    savingSuccessFlag = true;

                }
            }
            catch (Exception ex)
            {
                savingSuccessFlag = false;
            }


            return savingSuccessFlag;
        }

        //Activities Database Interaction Implementation
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

            //Activity Attributes
            int o_activityId = 0;
            DateTime o_time = DateTime.Now;
            string o_description = "";
            Venue o_venue = new Venue();

            //Venue Attributes
            int o_venueId = 0;
            string o_venueDescription = "";

            int sizeOfList = activityListToSave.Count;

            XmlWriterSettings writerSettings = new XmlWriterSettings();
            writerSettings.Indent = true;

            Activity holdingElement;

            try
            {
                using (XmlWriter writer = XmlTextWriter.Create("activities.xml", writerSettings))
                {
                    writer.WriteStartDocument();

                    writer.WriteStartElement("ActivityPool");

                    for (int i = 0; i < sizeOfList; i++)
                    {
                        holdingElement = activityListToSave[i];

                        holdingElement.requestActivityDetails(ref o_activityId,ref o_time,ref o_description,ref o_venue, requestString);

                        writer.WriteStartElement("Activity");
                        
                        //Activity Details
                        writer.WriteElementString("activityId", o_activityId.ToString());
                        writer.WriteElementString("time", o_time.ToString("s"));
                        writer.WriteElementString("description", o_description);

                        //Contains one Venue class

                        writer.WriteStartElement("hostingVenue");

                        o_venue.requestVenueDetails(ref o_venueId, ref o_venueDescription, requestString);

                        writer.WriteStartElement("Venue");
                        writer.WriteElementString("venueId", o_venueId.ToString());
                        writer.WriteElementString("location", o_venueDescription);
                        writer.WriteEndElement();

                        //EndTag hosting Venue
                        writer.WriteEndElement();


                        //EndTag Activity

                        writer.WriteEndElement();
                    }

                    savingSuccessFlag = true;

                }
            }
            catch (Exception ex)
            {
                savingSuccessFlag = false;
            }

            return savingSuccessFlag;

        }

        //Users Database Interaction Implementation
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

            //ref User attributes
            int o_userId =0 ;
            string o_userName ="";
            string o_name = "";
            string o_matricNo = "";
            string o_password = "";
            string o_email = "";
            int o_age = 0;
            bool o_loggedIn = false;
            double o_contactHome = 0;
            double o_hPContact = 0;

            int sizeOfList = userListToSave.Count;

            XmlWriterSettings writerSettings = new XmlWriterSettings();
            writerSettings.Indent = true;

            User holdingElement;

            try
            {
                using (XmlWriter writer = XmlTextWriter.Create("users.xml", writerSettings))
                {
                    writer.WriteStartDocument();

                    writer.WriteStartElement("UserPool");

                    for (int i = 0; i < sizeOfList; i++)
                    {
                        holdingElement = userListToSave[i];

                        holdingElement.requestUserDetail(ref o_userId,ref o_userName,ref o_name,ref o_matricNo,ref o_password,ref o_email
                                                         ,ref o_age,ref o_loggedIn,ref o_contactHome,ref o_hPContact,requestString);

                        writer.WriteStartElement("User");

                        writer.WriteElementString("userId", o_userId.ToString());
                        writer.WriteElementString("userName", o_userName);
                        writer.WriteElementString("name", o_name);
                        writer.WriteElementString("matricNo", o_matricNo.ToString());
                        writer.WriteElementString("password", o_password);
                        writer.WriteElementString("email", o_email);
                        writer.WriteElementString("age", o_age.ToString());
                        writer.WriteElementString("loggedIn", o_loggedIn.ToString().ToLower());
                        writer.WriteElementString("contactHome", o_contactHome.ToString());
                        writer.WriteElementString("contactHP", o_hPContact.ToString());

                        writer.WriteEndElement();

                    }

                    writer.WriteEndElement();
                }

                savingSuccessFlag = true;

            }
            catch (Exception ex)
            {
                savingSuccessFlag = false;
            }

            return savingSuccessFlag;
        }

        //Venue Database Interaction Implementation
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
               savingSuccessFlag = true;


           }
           catch (Exception ex)
           {
               savingSuccessFlag = false;
           }
           return savingSuccessFlag;
        }

    }
}
