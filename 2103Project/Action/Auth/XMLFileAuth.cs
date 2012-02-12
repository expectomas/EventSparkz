using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace _2103Project.Action.Auth
{
    class XMLFileAuth: Authorization
    {
        string holdingUserName, holdingPW;
        string obtainedMatric, obtainedPW, obtainedDomain, obtainedFirstName;

        public void sendUserNamePW(string i_UserName, string i_PW)
        {
            holdingUserName = i_UserName;
            holdingPW = i_PW;
        }

        public bool Authetication()
        {
            bool credentials_valid = false;

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            using (XmlReader scanner = XmlReader.Create("Users.xml",settings))
            {
                scanner.MoveToContent();

                scanner.ReadToDescendant("User");

                scanner.MoveToAttribute("domain");

                obtainedDomain = scanner.ReadContentAsString();
    
                scanner.MoveToAttribute("id");

                obtainedMatric = scanner.ReadContentAsString();

                scanner.MoveToElement();

                scanner.ReadToDescendant("FirstName");

                obtainedFirstName = scanner.ReadElementContentAsString("FirstName", "");

                obtainedPW = scanner.ReadElementContentAsString("Password", "");          
            }

            if (!holdingUserName.Equals(obtainedDomain+"\\"+obtainedMatric) || !holdingPW.Equals(obtainedPW))
                credentials_valid = false;
            else
                credentials_valid = true;
          
            return credentials_valid;
        }
    }
}
