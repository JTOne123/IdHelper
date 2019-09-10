﻿using Coldairarrow.Util;
using System.Web.Mvc;

namespace Demo.AspNetMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Content($"WorkerId:{IdHelper.WorkerId},Id:{IdHelper.GetId()}");
        }
    }
}