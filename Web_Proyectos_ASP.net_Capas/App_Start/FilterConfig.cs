﻿using System.Web;
using System.Web.Mvc;

namespace Web_Proyectos_ASP.net_Capas
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
