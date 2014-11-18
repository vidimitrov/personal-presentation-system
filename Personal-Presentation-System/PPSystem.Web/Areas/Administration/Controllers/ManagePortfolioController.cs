namespace PPSystem.Web.Areas.Administration.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using AutoMapper.QueryableExtensions;
    
    using PPSystem.Common.Repository;
    using PPSystem.Models.Portfolio;
    using PPSystem.Web.ViewModels.Portfolio;
    using System.Data;

    public class ManagePortfolioController : Controller
    {
        private static string DEFAULT_IMAGE = "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";

        private readonly IDeletableEntityRepository<Portfolio> portfolios;
        private readonly IDeletableEntityRepository<Project> projects;
        private readonly IDeletableEntityRepository<Technology> technologies;
        private readonly IDeletableEntityRepository<Contributor> contributors;

        public ManagePortfolioController(IDeletableEntityRepository<Project> projects,
            IDeletableEntityRepository<Portfolio> portfolios,
            IDeletableEntityRepository<Technology> technologies,
            IDeletableEntityRepository<Contributor> contributors)
        {
            this.projects = projects;
            this.portfolios = portfolios;
            this.technologies = technologies;
            this.contributors = contributors;
        }

        public ActionResult Index()
        {
            var portfolio = this.portfolios.All().Project().To<PortfolioViewModel>().FirstOrDefault();

            if (portfolio == null) 
            {
                var initialPortfolio = new Portfolio();

                this.portfolios.Add(initialPortfolio);
                this.portfolios.SaveChanges();
            }

            var projects = this.projects.All().Project().To<ProjectViewModel>().ToList();

            return View(projects);
        }

        public ActionResult AddProject()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProject(ProjectViewModel inputProject)
        {
            var portfolio = this.portfolios.All().FirstOrDefault();
            var image = inputProject.Image == string.Empty || inputProject.Image == null ? DEFAULT_IMAGE : inputProject.Image;

            if (ModelState.IsValid)
            {
                var project = new Project()
                {
                    Title = inputProject.Title,
                    Description = inputProject.Description,
                    Rating = 0,
                    RepoUrl = inputProject.RepoUrl,
                    CreatedOn = DateTime.Now,
                    Image = image
                };

                portfolio.Projects.Add(project);
                
                this.portfolios.SaveChanges();
            }

            return RedirectToAction("Index", "ManagePortfolio");
        }

        public ActionResult DeleteProject(int id)
        {
            this.projects.Delete(this.projects.GetById(id));
            this.projects.SaveChanges();

            return RedirectToAction("Index", "ManagePortfolio");
        }

        public ActionResult EditProject(int id)
        {
            var project = this.projects.All()
                .Project()
                .To<ProjectViewModel>()
                .Where(e => e.Id == id)
                .FirstOrDefault();

            return View(project);
        }

        [HttpPost]
        public ActionResult EditProject(ProjectViewModel editedProject)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var project = this.projects.All().Where(u => u.Id == editedProject.Id).First();
                    
                    if (editedProject.Image != null && editedProject.Image != project.Image) 
                    {
                        project.Image = editedProject.Image;
                    }

                    if (editedProject.Rating != null && editedProject.Rating != project.Rating) 
                    {
                        project.Rating = editedProject.Rating;
                    }

                    if (editedProject.RepoUrl != null && editedProject.RepoUrl != project.RepoUrl) 
                    {
                        project.RepoUrl = editedProject.RepoUrl;
                    }

                    if (editedProject.Title != null && editedProject.Title != project.Title) 
                    {
                        project.Title = editedProject.Title;
                    }

                    if (editedProject.Description != null && editedProject.Description != project.Description) 
                    {
                        project.Description = editedProject.Description;
                    }

                    this.projects.SaveChanges();

                    return RedirectToAction("Index", "ManagePortfolio");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save project changes.");
            }

            return View();
        }

        public ActionResult AddTechnology()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTechnology(TechnologyViewModel inputTechnology)
        {
            // Implement this

            return View();
        }

        public ActionResult DeleteTechnology(int id)
        {
            this.technologies.Delete(this.technologies.GetById(id));
            this.technologies.SaveChanges();

            return RedirectToAction("Index", "ManagePortfolio");
        }

        public ActionResult AddContributor()
        {
            // Implement this

            return View();
        }

        [HttpPost]
        public ActionResult AddContributor(ContributorViewModel inputContributor)
        {
            return View();
        }

        public ActionResult DeleteContributor(int id)
        {
            this.contributors.Delete(this.contributors.GetById(id));
            this.contributors.SaveChanges();

            return RedirectToAction("Index", "ManagePortfolio");
        }
    }
}