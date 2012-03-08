using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _2103Project.Action;

namespace _2103Project.Entities
{
    class ActiveUser : User
    {
        //Database Access Authetication
        private const string DatabaseToken = "3e#rtfGc";

        User person = new User();

        Database db = Database.CreateDatabase(DatabaseToken);

        public ActiveUser()
        {
        }

        public EventEntity viewEventInfo(int index)
        {
            List<EventEntity> temp = new List<EventEntity>();
            int selectedEventIndex=-1;

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
        }   // Done, Not Tested

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
        }   // Done, Not Tested

        public List<EventEntity> viewEventListingByDate(DateTime selectedDateTime)
        {
            List<EventEntity> eventListing = db.getListOfEvents();

            // Filter events not on selected date
            for (int i = 0; i < eventListing.Count; i++)
            {
                if (eventListing[i].getEventDate() != selectedDateTime)
                {
                    eventListing.RemoveAt(i);
                }
            }
            //

            // If selected date does not matches any event in database
            if (eventListing.Count == 0)
            {
                throw new System.ApplicationException();
            }
            //

            // Sort events according to dates in descending order (Bubble Sort)
            for (int i = 0; i < eventListing.Count; i++)
            {
                bool is_Sorted = true;

                for (int j = 1; j < eventListing.Count - i; j++)
                {
                    if (eventListing[j - 1].getEventDate() < eventListing[j].getEventDate())
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
        }   // Done, Not Tested

        public List<EventEntity> viewEventListingByEventName(string word)
        {
            string temp;
            List<EventEntity> eventListing = db.getListOfEvents();
            List<EventEntity> list = new List<EventEntity>();
            int[] flag = new int[eventListing.Count];   // To trace priority of search result

            word.Trim();    // Remove all leading and trailing white-space characters
            word.ToLower(); // Convert all characters to lowercase characters

            // Check if word is empty
            if (word == null)
            {
                throw new System.ApplicationException("Please type an event name");
            }
            //

            // Filter by Event Name in search priority: (1)FullMatch (2)WordMatch (3)CharactersMatch
            for(int i=0; i<eventListing.Count; i++)
            {
                temp = eventListing[i].getEventName().ToLower();

                // Compare if eventnames match with 'word'
                if (temp == word)
                {
                    list.Add(eventListing[i]);
                    flag[i] = 1;
                }
                //

                // Compare words in eventnames separated by white-spaces with 'word'
                if(temp.Contains(" ") && temp.Contains(word))
                {
                    list.Add(eventListing[i]);
                    flag[i] = 2;
                }
                //

                // Compare 'word' with eventnames' first word.Length-1 characters
                if(temp.Substring(0,word.Length-1) == word)
                {
                    list.Add(eventListing[i]);
                    flag[i] = 3;
                }
                //
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
                    if (flag[j-1] > flag[j])
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
        }   // Done, Not Tested
    }
}
