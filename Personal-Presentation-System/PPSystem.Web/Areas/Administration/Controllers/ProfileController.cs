using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PPSystem.Web.Areas.Administration.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Administration/Profile
        public ActionResult Index()
        {
            return View();
        }
    }
}