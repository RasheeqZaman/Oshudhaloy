﻿using System.Web;
using System.Web.Mvc;

namespace Medicus_V1._6._2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}