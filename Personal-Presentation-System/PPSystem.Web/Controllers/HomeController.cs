namespace PPSystem.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using PPSystem.Common.Repository;
    using PPSystem.Models;
    using PPSystem.Models.Blog;
    using PPSystem.Data;

    public class HomeController : Controller
    {
        private readonly IDeletableEntityRepository<ApplicationUser> users;

        public HomeController(IDeletableEntityRepository<ApplicationUser> users)
        {
            this.users = users;
        }

        public ActionResult Index()
        {
            ICollection<ApplicationUser> allUsers = this.users.All().ToList();

            if (allUsers.Count == 0)
            {
                return this.Redirect("/Configuration"); //RedirectToAction("ManageLogins", new { Message = message });
            }

            return View();
        }
    }
}