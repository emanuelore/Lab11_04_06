﻿using System.Web;
using System.Web.Mvc;

namespace DAEA_LAB11_JE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
