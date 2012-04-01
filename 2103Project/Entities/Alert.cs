using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _2103Project.Action;

namespace _2103Project.Entities
{
    class Alert : EventEntity
    {
        //Attributes
        private string alertedEventName;
        private string alert;

        //Constructors
        public Alert()
        {
        }
        
        public Alert(string i_alertedEventName, string i_alert)
        {
            alertedEventName = i_alertedEventName;
            alert = i_alert;
        }

        // Getters
        public string getAlertedEventName()
        {
            return alertedEventName;
        }

        public string getAlert()
        {
            return alert;
        }
    }
}
