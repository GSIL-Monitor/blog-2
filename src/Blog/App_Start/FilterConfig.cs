﻿using System.Web;
using System.Web.Mvc;

namespace BlogPlus
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
#if DEBUG
            filters.Add(new HandleErrorAttribute());
#else
            //filters.Add(new HandleErrorAttribute());
#endif
        }
    }
}
