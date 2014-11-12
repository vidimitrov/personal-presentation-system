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
        private readonly IDeletableEntityRepository<Post> posts;

        public HomeController(IDeletableEntityRepository<ApplicationUser> users, 
            IDeletableEntityRepository<Post> posts)
        {
            this.users = users;
            this.posts = posts;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}