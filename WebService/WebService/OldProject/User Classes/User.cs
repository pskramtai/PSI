﻿using System;
using System.Collections.Generic;
using System.Text;
using WebService.OldProject.Base_Classes;

namespace WebService.OldProject.User_Classes
{
    public sealed class User
    {
        private static readonly Lazy<User> lazy = new Lazy<User>(() => new User());

        public static User Instance { get { return lazy.Value; } }

        //some general variables that will likely be needed for the User class
        public string username { get; set; }

        public BarOld favoriteBar { get; set; }

        public string currentLocation { get; set; }

        //Enum defined in UserTrustLogic.cs
        public UserTrustLogic.UserTrustType userTrust { get; set; }

        private User()
        {
            username = "Guest";
            userTrust = UserTrustLogic.UserTrustType.None;
        }

        public void ChangeUsername(string newUsername)
        {
            username = newUsername;
            SaveUserInfo();
        }

        public void ChangeFaveBar(BarOld newBar)
        {
            favoriteBar = newBar;
            SaveUserInfo();
        }

        public void ChangeCurrentLoaction(string newLocation) //will need to talk about how this should be handled
        {

        }

        public void ChangeUserTrust(UserTrustLogic.UserTrustType newTrust)
        {
            userTrust = newTrust;
            SaveUserInfo();
        }

        public void SaveUserInfo() //will need to save user data somewhere
        {

        }
    }
}
