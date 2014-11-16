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
                        
            if (ModelState.IsValid)
            {
                var project = new Project()
                {
                    Title = inputProject.Title,
                    Description = inputProject.Description,
                    Rating = 0,
                    RepoUrl = inputProject.RepoUrl,
                    CreatedOn = DateTime.Now,
                    Image = inputProject.Image
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