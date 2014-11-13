using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PPSystem.Web.Areas.Administration.Controllers
{
    public class SettingsController : Controller
    {
        // GET: Administration/Settings
        public ActionResult Index()
        {
            return View();
        }
    }
}