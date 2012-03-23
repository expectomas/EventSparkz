using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _2103Project.Entities;

namespace _2103Project.Action
{
    abstract class Connection
    {
        public enum TypeOfMsg { Announcement, Alerts, SystemMsg };

        public abstract List<Advertisement> checkMessages();

        public abstract void sendMessage(Advertisement adv);
    }
}
