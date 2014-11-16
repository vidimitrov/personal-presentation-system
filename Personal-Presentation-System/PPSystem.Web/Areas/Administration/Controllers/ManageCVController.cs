namespace PPSystem.Web.Areas.Administration.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using AutoMapper.QueryableExtensions;

    using PPSystem.Common.Repository;
    using PPSystem.Models.CV;
    using PPSystem.Web.ViewModels.CV;
    using System;
    using System.Data;

    public class ManageCVController : Controller
    {
        private readonly IDeletableEntityRepository<CV> cvs;
        private readonly IDeletableEntityRepository<Experience> experiences;

        public ManageCVController(IDeletableEntityRepository<CV> cvs, IDeletableEntityRepository<Experience> experiences)
        {
            this.cvs = cvs;
            this.experiences = experiences;
        }

        public ActionResult Index()
        {
            var cv = this.cvs.All().Project().To<CvViewModel>().FirstOrDefault();

            return View(cv);
        }

        public ActionResult ManageSkills()
        {
            return View();
        }

        public ActionResult ManageEducationInstitutions()
        {
            return View();
        }

        public ActionResult ManageCompetitions()
        {
            return View();
        }

        public ActionResult ManageLanguages()
        {
            var cv = this.cvs.All().Project().To<CvViewModel>().FirstOrDefault();
            var languages = cv.Languages;
            
            return View(languages);
        }

        public ActionResult AddLanguage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddLanguage(LanguageViewModel inputLanguage)
        {
            var cv = this.cvs.All().FirstOrDefault();
                        
            if (ModelState.IsValid)
            {
                var language = new Language()
                {
                    Name = inputLanguage.Name
                };

                cv.Languages.Add(language);
                
                this.cvs.SaveChanges();
            }

            return RedirectToAction("Index", "ManageCV");
        }

        public ActionResult ManagePreviousExperience()
        {
            //var cv = this.cvs.All().Project().To<CvViewModel>().FirstOrDefault();
            var experiences = this.experiences.All().Project().To<ExperienceViewModel>().ToList();
            
            return View(experiences);
        }

        public ActionResult AddExperience()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddExperience(ExperienceViewModel inputExperience)
        {
            var cv = this.cvs.All().FirstOrDefault();

            var dateFrom = ParseStringToDate(Request["date-from"]);
            var dateTo = ParseStringToDate(Request["date-to"]);
            
            if (ModelState.IsValid)
            {
                var experience = new Experience()
                {
                    CompanyName = inputExperience.CompanyName,
                    CreatedOn = DateTime.Now,
                    Description = inputExperience.Description,
                    From = dateFrom,
                    To = dateTo,
                    JobTitle = inputExperience.JobTitle,
                    Type = inputExperience.Type
                };

                cv.Experiences.Add(experience);

                this.cvs.SaveChanges();
            }

            return RedirectToAction("Index", "ManageCV");
        }

        public ActionResult DeleteExperience(int id)
        {
            this.experiences.Delete(this.experiences.GetById(id));
            this.experiences.SaveChanges();

            return RedirectToAction("ManagePreviousExperience", "ManageCV");
        }

        public ActionResult EditExperience(int id)
        {
            var experience = this.experiences.All()
                .Project()
                .To<ExperienceViewModel>()
                .Where(e => e.Id == id)
                .FirstOrDefault();

            return View(experience);
        }

        [HttpPost]
        public ActionResult EditExperience(ExperienceViewModel updatedExperience)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var experience = this.experiences.All().Where(u => u.Id == updatedExperience.Id).First();
                    
                    if (updatedExperience.JobTitle != null && updatedExperience.JobTitle != experience.JobTitle) 
                    {
                        experience.JobTitle = updatedExperience.JobTitle;
                    }

                    if (updatedExperience.CompanyName != null && updatedExperience.CompanyName != experience.CompanyName) 
                    {
                        experience.CompanyName = updatedExperience.CompanyName;
                    }

                    if (updatedExperience.Description != null && updatedExperience.Description != experience.Description) 
                    {
                        experience.Description = updatedExperience.Description;
                    }

                    this.experiences.SaveChanges();

                    return RedirectToAction("ManagePreviousExperience", "ManageCV");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save experience changes.");
            }

            return View();
        }

        private DateTime? ParseStringToDate(string dateString)
        {
            if (dateString == string.Empty) 
            {
                return null;
            }

            var splittedDate = dateString.Split('/');

            var dateToDay = int.Parse(splittedDate[0]);
            var dateToMonth = int.Parse(splittedDate[1]);
            var dateToYear = int.Parse(splittedDate[2]);

            var parsedDate = new DateTime(dateToYear, dateToMonth, dateToDay);

            return parsedDate;
        }
    }
}