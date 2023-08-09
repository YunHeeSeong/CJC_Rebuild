using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Claims;

namespace DataAccessLibrary
{
    public static class GlobalVar
    {
        public static string CompCd = "1340";
        public static string LoginId { get; set; }
        public static string UserId { get; set; }
        public static ClaimsPrincipal LogOutUser { get; set; }
        public static string IpAddr { get; set; }
    }
}
