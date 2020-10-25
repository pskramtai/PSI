using System;
using System.Collections.Generic;
using System.Text;

namespace Comparison_Engine.User_Classes
{
    public sealed class UserLoginLogic
    {
        private static readonly Lazy<UserLoginLogic> lazy = new Lazy<UserLoginLogic>(() => new UserLoginLogic());

        public static UserLoginLogic Instance { get { return lazy.Value; } }

        private UserLoginLogic()
        {

        }

        //Will need to talk over together how we should approach user login
        public Boolean ValidateUserLogin(string username, string password)
        {
            return true;
        }
    }
}
