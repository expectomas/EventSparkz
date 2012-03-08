using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using _2103Project.Action;

namespace _2103Project.Entities
{
    class Organiser : ActiveUser
    {
        //Attributes
        private List<EventEntity> Bookings;
        private int eventId;
        private string eventName;
        private DateTime startTime;
        private DateTime endTime;
        private int eventScheduleId;
        private int participantSize;
        private List<Participant> participantList;

        // Constructor
        public Organiser() { }

        public Organiser(int i_eventId, string i_eventName, DateTime i_startTime, DateTime i_endTime, int i_eventScheduleId, int i_participationSize, List<Participant> I_participantList)
        {
            eventId = i_eventId;
            eventName = i_eventName;
            startTime = i_startTime;
            endTime = i_endTime;
            eventScheduleId = i_eventScheduleId;
            participantSize = i_participationSize;
            participantList = I_participantList;
        }
        //Database Access Authetication
        private const string DatabaseToken = "9032!ds$";

        //Methods
        public bool createEvent()
        {
            string path = "event.txt";
            string tempPath = "temp.txt";

            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);
                fs.Close();
            }
            if (!File.Exists(tempPath))
            {
                FileStream fs = File.Create(tempPath);
                fs.Close();
            }
            Database db = Database.CreateDatabase(DatabaseToken);
            db.createEvent(eventId, eventName, startTime, endTime, eventScheduleId, participantSize);
            return true;
        }

        public static int getLastEventId()
        {
            int count = 6;
            string strid = "1";
            StreamReader sr = new StreamReader("event.txt");
            while (sr.Peek() >= 0)
            {
                if (count == 6)
                {
                    strid = sr.ReadLine();
                    count = 1;
                }
                else
                {
                    sr.ReadLine();
                    count++;
                }
            }
            sr.Close();
            return int.Parse(strid);
        }

        public static int getLastScheduleId()
        {
            int count = 2;
            string strschid = "1";
            StreamReader sr = new StreamReader("event.txt");
            while (sr.Peek() >= 0)
            {
                if (count == 6)
                {
                    strschid = sr.ReadLine();
                    count = 1;
                }
                else
                {
                    sr.ReadLine();
                    count++;
                }                    
            }
            sr.Close();
            return int.Parse(strschid);
        }

        public bool cancelEvent(string selectedEventName)
        {
            bool eventCancelled = false;

            Database db = Database.CreateDatabase(DatabaseToken);
            db.deleteEvent(selectedEventName);
            return !eventCancelled;
        }

        public static Queue<string> loadListOfEvent()
        {
            Database db = Database.CreateDatabase(DatabaseToken);
            Queue<string> listOfEvents = new Queue<string>();
            db.loadListOfEvent(listOfEvents);
            return listOfEvents;
        }

        public bool updateEvent()
        {
            bool eventUpdated = false;


            return eventUpdated;
        }

    }
}
