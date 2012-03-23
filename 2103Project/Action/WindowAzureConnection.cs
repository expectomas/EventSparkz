using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _2103Project.Entities;

namespace _2103Project.Action
{
    class WindowAzureConnection : Connection
    {
        public WindowAzureConnection(TypeOfMsg requestMsgType)
        {

        }

        public override List<Advertisement> checkMessages()
        {
            List<Advertisement> newAdList = new List<Advertisement>();


            return newAdList;
        }

        public override void sendMessage(Advertisement adv)
        {
            throw new NotImplementedException();
        }
    }
}
