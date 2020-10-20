using System;
using System.Collections.Generic;
using System.Text;
using Comparison_Engine.User_Classes;

namespace Comparison_Engine.Base_Classes
{
    public class User
    {
        //some general variables that will likely be needed for the User class
        public string username { get; set; }

        public Bar favoriteBar { get; set; }

        public string currentLocation { get; set; }

        //Enum defined in UserTrustLogic.cs
        public UserTrustLogic.UserTrustType userTrust { get; set; }

    }
}
