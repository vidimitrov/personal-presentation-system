namespace PPSystem.Web.Areas.Blog.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }

        // GET: Blog/Manage
        public ActionResult Manage()
        {
            return View();
        }
    }
}