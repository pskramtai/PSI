using System;
using System.Collections.Generic;
using System.Text;

namespace Comparison_Engine.User_Classes
{
    public sealed class UserLoginLogic
    {
        private static readonly Lazy<UserLoginLogic> lazy = new Lazy<UserLoginLogic>(() => new UserLoginLogic());

        public static UserLoginLogic Instance { get { return lazy.Value; } }

        private User user = User.Instance;

        public bool loggedIn = false;

        private Dictionary<string, string> userPasswordKVP = new Dictionary<string, string>() //some default logins for now, will be removed in the future
        {
            {"Username", "Password" },
            {"admin", "admin" },
            {"test", "test" }
        };

        private UserLoginLogic()
        {

        }

        //Will need to talk over together how we should approach user login
        public bool ValidateUserLogin(string username, string password)
        {
            if (AreCredentialsReal(new KeyValuePair<string, string>(username, password)) && !loggedIn)
            {
                loggedIn = true;
                user.username = username;
                //also set the trust level, favorite bar here for the user
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool AreCredentialsReal(KeyValuePair<string, string> userKeyValuePair) //this will definitely change once we have somewhere to store actual user accounts
        {
            if(userPasswordKVP.TryGetValue(userKeyValuePair.Key, out string value) && value == userKeyValuePair.Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LogOutUser()
        {
            if (loggedIn)
            {
                user.username = "Guest";
                user.favoriteBar = null;
                user.userTrust = UserTrustLogic.UserTrustType.None;
            }
        }
    }
}
