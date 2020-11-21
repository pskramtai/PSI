using System;
using System.Collections.Generic;
using System.Text;

namespace Comparison_Engine.User_Classes
{
    public sealed class UserTrustLogic
    {
        //Class for managing user trust, things like should we trust any edits they make to a bars menu
        //or any changes to a drink

        private static readonly Lazy<UserTrustLogic> lazy = new Lazy<UserTrustLogic>(() => new UserTrustLogic());

        public static UserTrustLogic Instance { get { return lazy.Value; } }

        private UserTrustLogic()
        {

        }

        //Enum with any different User types we might need for user contribution validation
        public enum UserTrustType
        {
            None,
            UpdatesDrunk,
            Normal,
            UpdatesWell,
            AlwaysTrust
        }
    }
}
