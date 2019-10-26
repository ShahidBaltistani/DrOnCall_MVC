using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorOnCall.Web
{
    public class WebUtil
    {
        public static readonly string CURRENT_USER;
        public static readonly int ADMIN_ROLE_ID;
        public static readonly int User_ROLE_ID;
        public static readonly int Doctor_ROLE_ID;
        public static readonly string MY_COOKIE;

        static WebUtil()
        {
            CURRENT_USER = "CurrentUser";
            ADMIN_ROLE_ID = 1;
            User_ROLE_ID = 2;
            Doctor_ROLE_ID = 3;
            MY_COOKIE = "info";
        }
    }
}