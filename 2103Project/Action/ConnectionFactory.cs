using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2103Project.Action
{
    abstract class ConnectionFactory
    {
        public ConnectionFactory()
        {

        }

        abstract public Connection createConnection(string requestedCon,_2103Project.Action.Connection.TypeOfMsg msgType);
    }
}
