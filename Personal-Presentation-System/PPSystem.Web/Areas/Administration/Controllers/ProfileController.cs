namespace PPSystem.Web.Areas.Administration.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using PPSystem.Common.Repository;
    using PPSystem.Models;
    using PPSystem.Web.ViewModels.Account;

    using AutoMapper.QueryableExtensions;
    using System.Data;

    public class ProfileController : Controller
    {
        private readonly IDeletableEntityRepository<ApplicationUser> users;

        public ProfileController(IDeletableEntityRepository<ApplicationUser> users)
        {
            this.users = users;
        }

        // GET: Administration/Profile
        public ActionResult Index()
        {
            var owner = this.users.All().Project().To<OwnerViewModel>().First();

            return View(owner);
        }

        [HttpPost]
        public ActionResult EditProfile(OwnerViewModel updatedProfile)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = this.users.All().Where(u => u.Id == updatedProfile.Id).First();
                    
                    if (updatedProfile.FullName != null && user.FullName != updatedProfile.FullName) 
                    {
                        user.FullName = updatedProfile.FullName;
                    }

                    if (updatedProfile.Summary != null && user.Summary != updatedProfile.Summary) 
                    {
                        user.Summary = updatedProfile.Summary;
                    }

                    if (updatedProfile.Location != null && user.Location != updatedProfile.Location) 
                    {
                        user.Location = updatedProfile.Location;
                    }

                    if (updatedProfile.PhoneNumber != null && user.PhoneNumber != updatedProfile.PhoneNumber) 
                    {
                        user.PhoneNumber = updatedProfile.PhoneNumber;
                    }

                    if (updatedProfile.JobCompany != null && user.JobCompany != updatedProfile.JobCompany) 
                    {
                        user.JobCompany = updatedProfile.JobCompany;
                    }

                    if (updatedProfile.JobPosition != null && user.JobPosition != updatedProfile.JobPosition) 
                    {
                        user.JobPosition = updatedProfile.JobPosition;
                    }

                    if (user.IsAvailable != updatedProfile.IsAvailable) 
                    {
                        user.IsAvailable = updatedProfile.IsAvailable;
                    }

                    if (updatedProfile.Facebook != null && user.Facebook != updatedProfile.Facebook) 
                    {
                        user.Facebook = updatedProfile.Facebook;
                    }

                    if (updatedProfile.Google != null && user.Google != updatedProfile.Google) 
                    {
                        user.Google = updatedProfile.Google;
                    }

                    if (updatedProfile.Twitter != null && user.Twitter != updatedProfile.Twitter) 
                    {
                        user.Twitter = updatedProfile.Twitter;
                    }

                    if (updatedProfile.LinkedIn != null && user.LinkedIn != updatedProfile.LinkedIn) 
                    {
                        user.LinkedIn = updatedProfile.LinkedIn;
                    }

                    if (updatedProfile.GitHub != null && user.GitHub != updatedProfile.GitHub) 
                    {
                        user.GitHub = updatedProfile.GitHub;
                    }

                    this.users.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save profile changes.");
            }

            return View();
        }
    }
}