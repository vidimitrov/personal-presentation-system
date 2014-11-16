namespace PPSystem.Web.Controllers
{
    using System;
    using System.Web.Mvc;
    using System.Linq;

    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.Owin;
    using Microsoft.Owin.Security;
    using Microsoft.AspNet.Identity.EntityFramework;

    using AutoMapper.QueryableExtensions;

    using PPSystem.Common.Repository;
    using PPSystem.Models.CV;
    using PPSystem.Web.ViewModels.CV;
    using PPSystem.Models;

    public class CVController : Controller
    {
        private readonly IDeletableEntityRepository<CV> cvs;
        private readonly IDeletableEntityRepository<ApplicationUser> users;

        protected UserManager<ApplicationUser> UserManager { get; set; }
        
        public CVController(IDeletableEntityRepository<CV> cvs, 
            IDeletableEntityRepository<ApplicationUser> users)
        {
            this.cvs = cvs;
            this.users = users;
        }

        public ActionResult Index()
        {
            var cv = this.cvs.All().Project().To<CvViewModel>().FirstOrDefault();

            if (cv == null) 
            {
                var currentUserId = User.Identity.GetUserId();

                var owner = this.users.All().Where(u => u.Id == currentUserId).FirstOrDefault();

                if (owner == null) 
                {
                    return this.Redirect("/Configuration");
                }

                var initialCV = new CV(owner.Id, DateTime.Now);

                this.cvs.Add(initialCV);
                this.cvs.SaveChanges();

                cv = this.cvs.All().Project().To<CvViewModel>().FirstOrDefault();
            }

            return View(cv);
        }
    }
}