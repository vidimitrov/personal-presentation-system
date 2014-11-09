using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PPSystem.Web.Controllers
{
    public class ContactsController : Controller
    {
        // GET: Contacts
        public ActionResult Index()
        {
            return View();
        }
    }
}