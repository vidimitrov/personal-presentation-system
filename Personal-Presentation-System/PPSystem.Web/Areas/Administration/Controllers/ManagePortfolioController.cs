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

    public class ManagePortfolioController : Controller
    {
        private readonly IDeletableEntityRepository<Portfolio> portfolios;
        private readonly IDeletableEntityRepository<Project> projects;

        public ManagePortfolioController(IDeletableEntityRepository<Project> projects,
            IDeletableEntityRepository<Portfolio> portfolios)
        {
            this.projects = projects;
            this.portfolios = portfolios;
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
    }
}