using System;
using System.Collections.Generic;
using System.Text;

namespace ComparisonEngineUI
{
    class Constants
    {
        // Google OAuth
        // For Google login, configure at https://console.developers.google.com/
        public static string GoogleiOSClientId = "<insert IOS client ID here>";
        public static string GoogleAndroidClientId = "433871991239-rq3kn77qftb5qndip967jdb5nbgjebra.apps.googleusercontent.com";

        // These values do not need changing
        public static string GoogleScope = "https://www.googleapis.com/auth/userinfo.email https://www.googleapis.com/auth/userinfo.profile";
        public static string GoogleAuthorizeUrl = "https://accounts.google.com/o/oauth2/auth";
        public static string GoogleAccessTokenUrl = "https://www.googleapis.com/oauth2/v4/token";
        public static string GoogleUserInfoUrl = "https://www.googleapis.com/oauth2/v2/userinfo";

        // Set these to reversed iOS/Android client ids, with :/oauth2redirect appended
        public static string GoogleiOSRedirectUrl = "<insert IOS redirect URL here>:/oauth2redirect";
        public static string GoogleAndroidRedirectUrl = "com.googleusercontent.apps.433871991239-rq3kn77qftb5qndip967jdb5nbgjebra:/oauth2redirect";


        public static string BarsUrl = "http://localhost:8081/api/Bars/";
        public static string DrinksUrl = "http://localhost:8081/api/Drinks/";
        public static string SpecificPricesUrl = "http://localhost:8081/api/SpecificPrices/";
    }
}
