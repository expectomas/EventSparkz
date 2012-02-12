using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2103Project.Action
{
    interface Authorization
    {
        //Methods are automatically public
              void sendUserNamePW(string i_UserName, string i_PW);
              bool Authetication();
    }
}
