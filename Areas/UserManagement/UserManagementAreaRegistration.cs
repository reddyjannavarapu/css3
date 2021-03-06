﻿using System.Web.Mvc;

namespace CSS2.Areas.UserManagement
{
    public class UserManagementAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "UserManagement";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "UserManagement_default",
                "UserManagement/{controller}/{action}/{id}",
                new { action = "UserGroupDetails", id = UrlParameter.Optional }
            );
        }
    }
}