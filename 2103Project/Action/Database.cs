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

        //Singleton Concept 
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

        // write xml for the first time
        public void writeFirstToXml(XmlTextWriter textWriter, int userId, string username, string name, string matricNo, string password, string email, int age,bool loggedIn,  double contactHome, double contactHP)
        {
            textWriter.WriteStartDocument();
            textWriter.WriteStartElement("UserPool");
            textWriter.WriteStartElement("User");
            textWriter.WriteStartElement("userId");
            textWriter.WriteString(userId.ToString());
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("userName");
            textWriter.WriteString(username);
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("name");
            textWriter.WriteString(name.ToUpper());
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("matricNo");
            textWriter.WriteString(matricNo.ToUpper());
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("password");
            textWriter.WriteString(password);
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("email");
            textWriter.WriteString(email);
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("age");
            textWriter.WriteString(age.ToString());
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("loggedIn");
            textWriter.WriteString(loggedIn.ToString());
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("contactHome");
            textWriter.WriteString(contactHome.ToString());
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("contactHP");
            textWriter.WriteString(contactHP.ToString());
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.WriteEndDocument();
            textWriter.Close();
        }

        // function to write the current users xml to temp xml and write a new user xml with combination of temp xml with the new registered detail
        public void writeExistToXml(XmlReader reader, int userId, string username, string name, string matricNo, string password, string email, int age, bool loggedIn, double contactHome, double contactHP)
        {
            XmlTextWriter tempWriter = new XmlTextWriter("temp.xml", Encoding.UTF8);
            tempWriter.WriteStartDocument();
            tempWriter.WriteStartElement("UserPool");
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "userId":
                            tempWriter.WriteStartElement("User");
                            tempWriter.WriteStartElement("userId");
                            tempWriter.WriteString(reader.ReadElementContentAsString());
                            tempWriter.WriteEndElement();

                            tempWriter.WriteStartElement("userName");
                            tempWriter.WriteString(reader.ReadElementContentAsString());
                            tempWriter.WriteEndElement();

                            tempWriter.WriteStartElement("name");
                            tempWriter.WriteString(reader.ReadElementContentAsString());
                            tempWriter.WriteEndElement();

                            tempWriter.WriteStartElement("matricNo");
                            tempWriter.WriteString(reader.ReadElementContentAsString());
                            tempWriter.WriteEndElement();

                            tempWriter.WriteStartElement("password");
                            tempWriter.WriteString(reader.ReadElementContentAsString());
                            tempWriter.WriteEndElement();

                            tempWriter.WriteStartElement("email");
                            tempWriter.WriteString(reader.ReadElementContentAsString());
                            tempWriter.WriteEndElement();

                            tempWriter.WriteStartElement("age");
                            tempWriter.WriteString(reader.ReadElementContentAsString());
                            tempWriter.WriteEndElement();

                            tempWriter.WriteStartElement("loggedIn");
                            tempWriter.WriteString(reader.ReadElementContentAsString());
                            tempWriter.WriteEndElement();

                            tempWriter.WriteStartElement("contactHome");
                            tempWriter.WriteString(reader.ReadElementContentAsString());
                            tempWriter.WriteEndElement();

                            tempWriter.WriteStartElement("contactHP");
                            tempWriter.WriteString(reader.ReadElementContentAsString());
                            tempWriter.WriteEndElement();


                            tempWriter.WriteEndElement();
                            reader.MoveToElement();
                            break;

                        default:
                            break;

                    }
                }
            }
            tempWriter.WriteEndDocument();
            tempWriter.Close();
            reader.Close();
            XmlReader tempreader = XmlReader.Create("temp.xml");
            writeToNewXml(tempreader, userId, username, name, matricNo, password, email, age, loggedIn, contactHome, contactHP);
        }

        // function to overwrite the old users.xml with new details.
        private void writeToNewXml(XmlReader tempreader, int userId, string username, string name, string matricNo, string password, string email, int age, bool loggedIn, double contactHome, double contactHP)
        {
            XmlTextWriter textWriter = new XmlTextWriter("users.xml", Encoding.UTF8);
            textWriter.WriteStartDocument();
            textWriter.WriteStartElement("UserPool");
            while (tempreader.Read())
            {
                if (tempreader.IsStartElement())
                {
                    switch (tempreader.Name)
                    {
                        case "userId":
                            textWriter.WriteStartElement("User");

                            textWriter.WriteStartElement("userId");
                            textWriter.WriteString(tempreader.ReadElementContentAsString());
                            textWriter.WriteEndElement();

                            textWriter.WriteStartElement("userName");
                            textWriter.WriteString(tempreader.ReadElementContentAsString());
                            textWriter.WriteEndElement();

                            textWriter.WriteStartElement("name");
                            textWriter.WriteString(tempreader.ReadElementContentAsString());
                            textWriter.WriteEndElement();

                            textWriter.WriteStartElement("matricNo");
                            textWriter.WriteString(tempreader.ReadElementContentAsString());
                            textWriter.WriteEndElement();

                            textWriter.WriteStartElement("password");
                            textWriter.WriteString(tempreader.ReadElementContentAsString());
                            textWriter.WriteEndElement();

                            textWriter.WriteStartElement("email");
                            textWriter.WriteString(tempreader.ReadElementContentAsString());
                            textWriter.WriteEndElement();

                            textWriter.WriteStartElement("age");
                            textWriter.WriteString(tempreader.ReadElementContentAsString());
                            textWriter.WriteEndElement();

                            textWriter.WriteStartElement("loggedIn");
                            textWriter.WriteString(tempreader.ReadElementContentAsString());
                            textWriter.WriteEndElement();

                            textWriter.WriteStartElement("contactHome");
                            textWriter.WriteString(tempreader.ReadElementContentAsString());
                            textWriter.WriteEndElement();

                            textWriter.WriteStartElement("contactHP");
                            textWriter.WriteString(tempreader.ReadElementContentAsString());
                            textWriter.WriteEndElement();

                            textWriter.WriteEndElement();
                            tempreader.MoveToElement();
                            break;

                        default:
                            break;

                    }
                }
            }

            textWriter.WriteStartElement("User");
            textWriter.WriteStartElement("userId");
            textWriter.WriteString(userId.ToString());
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("username");
            textWriter.WriteString(username);
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("name");
            textWriter.WriteString(name.ToUpper());
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("matricNo");
            textWriter.WriteString(matricNo);
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("password");
            textWriter.WriteString(password);
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("email");
            textWriter.WriteString(email);
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("age");
            textWriter.WriteString(age.ToString());
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("loggedIn");
            textWriter.WriteString(loggedIn.ToString());
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("contactHome");
            textWriter.WriteString(contactHome.ToString());
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("contactHP");
            textWriter.WriteString(contactHP.ToString());
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.WriteEndDocument();
            textWriter.Close();
            tempreader.Close();
        }
        // check duplicate username 
        public bool checkUsernameExist(string username)
        {
            string filename = "users.xml";
            int existflag = 0;
            XmlReader reader = XmlReader.Create(filename);
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "userName":
                            string attribute = reader.ReadElementContentAsString();
                            if (attribute.Equals(username))
                                existflag = 1;
                            break;
                        default:
                            break;
                    }
                }
            }
            reader.Close();
            if (existflag == 1)
                return true;
            else
                return false;
        }
        // retrieve the last registered user ID
        public int getLastID()
        {
            int newID = 1;
            string filename = "users.xml";
            XmlReader reader = XmlReader.Create(filename);
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "userId":
                            string attribute = reader.ReadElementContentAsString();
                            newID = Convert.ToInt32(attribute);
                            break;
                        default:
                            break;
                    }
                }
            }
            reader.Close();
            return newID;
        }

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
                        do
                        {
                            writer.WriteElementString("item", o_listOfItems[itemsCounter]);
                            ++itemsCounter;
                        } while (itemsCounter<o_listOfItems.Count);
                        itemsCounter = 0;
                        writer.WriteEndElement();

                        //Process Activities

                        writer.WriteStartElement("listOfActivities");
                        do
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
                        } while (activitiesCounter < o_Activities.Count);
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
