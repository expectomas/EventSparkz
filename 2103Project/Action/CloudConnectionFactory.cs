using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2103Project.Action
{
    class CloudConnectionFactory : ConnectionFactory
    {
        public CloudConnectionFactory()
        {

        }

        //Override the abstract method in Connection Factory
        public override Connection createConnection(string requestedCon,_2103Project.Action.Connection.TypeOfMsg msgType)
        {
            switch (requestedCon)
            {
                case "AmazonWebServices":
                    return new AmazonConnection(msgType);
                    break;
                case "WindowsAzure":
                    return new WindowAzureConnection(msgType);
                    break; 
                default :
                    throw new Exception("Connection Type is Not Avaliable"); 
                    break;
            }
        }
    }
}
