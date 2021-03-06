﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApiOwinStructureMap.App_Start
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "AllCustomers",
                routeTemplate: "customers",
                defaults: new { controller = "Customers", action = "Get" }
                );
        }
    }
}