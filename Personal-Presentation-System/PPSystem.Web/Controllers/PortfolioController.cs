namespace PPSystem.Web.Controllers
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

    public class PortfolioController : Controller
    {
        private readonly IDeletableEntityRepository<Portfolio> portfolios;

        public PortfolioController(IDeletableEntityRepository<Portfolio> portfolios)
        {
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

            return View();
        }
    }
}