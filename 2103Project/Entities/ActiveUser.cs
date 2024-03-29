﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _2103Project.Action;

/*
 * Authors for this section
 * 
 *   Tan Siong Wee, Edmund A0076627W
 *   Lim Zhi Hao A0067252H
 */

namespace _2103Project.Entities
{
    class ActiveUser : User
    {
        //Database Access Authetication
        private const string DatabaseToken = "3e#rtfGc";

        User person = new User();

        Database db = Database.CreateDatabase(DatabaseToken);

        static List<Alert> userAlerts = new List<Alert>();

        public ActiveUser()
        {

        }

        public ActiveUser(User copyingUser)
        {
            userId = copyingUser.getUserId();
            userName = copyingUser.getUserName();
            name = copyingUser.getName();
            matricNo = copyingUser.getMatricNo();
            password = copyingUser.getPW();
            email = copyingUser.getEmail();
            age = copyingUser.getAge();
            loggedIn = copyingUser.getLoggedIn();
            contactHome = copyingUser.getContactHome();
            contactHP = copyingUser.getContactHP();

        }

        // Event Display
        public EventEntity viewEventInfo(int index)
        {
            List<EventEntity> temp = new List<EventEntity>();
            int selectedEventIndex = -1;

            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i].getEventId() == index)
                {
                    selectedEventIndex = i;
                }
            }

            // If event is not found in database...
            if (selectedEventIndex < 0)
            {
                throw new System.ApplicationException();
            }
            //

            return temp[selectedEventIndex];
        } 
        public List<EventEntity> viewEventListing()
        {
            List<EventEntity> eventListing = db.getListOfEvents();

            // Sort by Event ID in descending order (Bubble Sort)
            for (int i = 0; i < eventListing.Count; i++)
            {
                bool is_Sorted = true;

                for (int j = 1; j < eventListing.Count - i; j++)
                {
                    if (eventListing[j - 1].getEventId() < eventListing[j].getEventId())
                    {
                        EventEntity temp = eventListing[j - 1];
                        eventListing[j - 1] = eventListing[j];
                        eventListing[j] = temp;
                        is_Sorted = false;
                    }
                }
                if (is_Sorted) i = eventListing.Count;
            }
            //

            return eventListing;
        }   
        public List<EventEntity> viewEventListingByDate(DateTime selectedDateTime)
        {
            List<EventEntity> eventListing = db.getListOfEvents();
            List<EventEntity> temp = new List<EventEntity>();

            // Filter events not on selected date
            for (int i = 0; i < eventListing.Count; i++)
            {
                if (eventListing[i].getEventDate().Date == selectedDateTime.Date)
                {
                    temp.Add(eventListing[i]);
                }
            }
            //

            // Sort events according to dates in descending order (Bubble Sort)
            for (int i = 0; i < temp.Count; i++)
            {
                bool is_Sorted = true;

                for (int j = 1; j < temp.Count - i; j++)
                {
                    if (temp[j - 1].getEventDate() < temp[j].getEventDate())
                    {
                        EventEntity tempo = temp[j - 1];
                        temp[j - 1] = temp[j];
                        temp[j] = tempo;
                        is_Sorted = false;
                    }
                }
                if (is_Sorted) i = temp.Count;
            }
            //

            return temp;
        }   
        public List<EventEntity> viewEventListingByEventName(string word)
        {
            string temp;
            List<EventEntity> eventListing = db.getListOfEvents();
            List<EventEntity> list = new List<EventEntity>();
            int[] flag = new int[eventListing.Count + 1];   // To trace priority of search result
            string[] separator = new string[] { " " };  // For string.split

            word = word.ToLower(); // Convert all characters to lowercase characters

            // Filter by Event Name in search priority: (1)FullMatch (2)WordMatch (3)CharactersMatch
            for (int i = 0; i < eventListing.Count; i++)
            {
                bool found = false; // If an event in eventListing matches the search field, 'found' is set
                temp = eventListing[i].getEventName().ToLower();

                // Check if search text > event's name
                if (word.Length > temp.Length)
                {
                    break;
                }
                //

                // Compare if eventnames match with 'word'
                if (temp == word && found == false)
                {
                    list.Add(eventListing[i]);
                    flag[i] = 1;
                    found = true;
                }
                //

                // Compare words in eventnames separated by white-spaces with 'word'
                if (temp.Contains(" ") && found == false) // If event name has words separated by white-spaces
                {
                    string[] result = temp.Split(separator, StringSplitOptions.RemoveEmptyEntries); // Compare if each word in the event name equals to 'word'

                    foreach (string s in result)
                    {
                        if (s == word)
                        {
                            list.Add(eventListing[i]);
                            flag[i] = 2;
                            found = true;
                            break;
                        }
                    }
                }
                //

                // Compare 'word' with eventnames' first word.Length-1 characters
                if (temp.Substring(0, word.Length) == word && found == false)
                {
                    list.Add(eventListing[i]);
                    flag[i] = 3;
                    found = true;
                }
                //%
            }
            //

            // Raise error for no match search
            if (eventListing.Count == 0)
            {
                throw new System.ApplicationException("No match found");
            }
            //

            // Sort 'list' according to search priority in ascending order (Bubble Sort)
            for (int i = 0; i < list.Count; i++)
            {
                bool is_Sorted = true;

                for (int j = 1; j < list.Count - i; j++)
                {
                    if (flag[j - 1] > flag[j])
                    {
                        int tem = flag[j - 1];
                        flag[j - 1] = flag[j];
                        flag[j] = tem;
                        EventEntity tempo = list[j - 1];
                        list[j - 1] = list[j];
                        list[j] = tempo;
                        is_Sorted = false;
                    }
                }
                if (is_Sorted) i = list.Count;
            }
            //

            return list;
        }   

        // Check For Starting Events For This Curent User
        public void checkForStartingEvent()
        {
            Organiser o = new Organiser(this);
            Participant p = new Participant(this);
            Facilitator f = new Facilitator(this);
            List<EventEntity> listOfOrganizedEvents = o.getOrganisedEvents();
            List<EventEntity> listOfRegisteredEvents = p.getRegisteredEvents();
            List<EventEntity> listOfFacilitatingEvents = f.getFacilitatedEvents();
            EventEntity eve = new EventEntity();
            TimeSpan difference = new TimeSpan(1, 0, 0, 0);

            foreach (EventEntity events in listOfOrganizedEvents)
            {
                if ((events.getEventStartTime().Subtract(System.DateTime.Now)) <= difference)
                    events.setEventStartFlag(events.getEventId());
            }

            foreach (EventEntity events in listOfRegisteredEvents)
            {
                if ((events.getEventStartTime().Subtract(System.DateTime.Now)) <= difference)
                    events.setEventStartFlag(events.getEventId());
            }

            foreach (EventEntity events in listOfFacilitatingEvents)
            {
                if ((events.getEventStartTime().Subtract(System.DateTime.Now)) <= difference)
                    events.setEventStartFlag(events.getEventId());
            }
        }

        // Alert Search
        public int scoutAlert()
        {
            int numOfAlerts = 0;
            userAlerts.Clear();
            Participant p = new Participant(this);
            Facilitator f = new Facilitator(this);
            Organiser o = new Organiser(this);
            List<EventEntity> listOfRegisteredEvents = new List<EventEntity>();
            List<EventEntity> listOfFacilitatingEvents = new List<EventEntity>();
            List<EventEntity> listOfOrganizingEvents = new List<EventEntity>();
            EventEntity eve = new EventEntity();
            listOfFacilitatingEvents = f.getFacilitatedEvents();
            listOfOrganizingEvents = o.getOrganisedEvents();
            listOfRegisteredEvents = p.getRegisteredEvents();

            // Alert if User is PARTICIPANT of this updated event
            foreach (EventEntity e in listOfRegisteredEvents)
            {
                if (e.getEventUpdatedFlag(e.getEventId()) == true)
                {
                    userAlerts.Add(eve.createAlert(e.getEventId(), 1));
                    numOfAlerts++;
                }
            }

            // Alert if User if FACILITATOR of this updated event
            foreach (EventEntity e in listOfFacilitatingEvents)
            {
                if (e.getEventUpdatedFlag(e.getEventId()) == true)
                {
                    userAlerts.Add(eve.createAlert(e.getEventId(), 1));
                    numOfAlerts++;
                }
            }

            // Alert if User is PARTICIPANT of this starting event
            foreach (EventEntity e in listOfRegisteredEvents)
            {
                if (e.getEventStartFlag(e.getEventId()) == true)
                {
                    userAlerts.Add(eve.createAlert(e.getEventId(), 3));
                    numOfAlerts++;
                }
            }

            // Alert if User is FACILITATOR of this starting event
            foreach (EventEntity e in listOfFacilitatingEvents)
            {
                if (e.getEventStartFlag(e.getEventId()) == true)
                {
                    userAlerts.Add(eve.createAlert(e.getEventId(), 3));
                    numOfAlerts++;
                }
            }

            // Alert if User is ORGANIZER of this starting event
            foreach (EventEntity e in listOfOrganizingEvents)
            {
                if (e.getEventStartFlag(e.getEventId()) == true)
                {
                    userAlerts.Add(eve.createAlert(e.getEventId(), 3));
                    numOfAlerts++;
                }
            }

            return numOfAlerts;
        }

        // Get List of Alerts For This Current User
        public List<Alert> getListOfAlerts()
        {
            return userAlerts;
        }
    }
}
