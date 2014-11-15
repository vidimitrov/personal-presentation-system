namespace PPSystem.Web.Controllers
{
    using System.Web.Mvc;
    using System.Linq;

    using AutoMapper.QueryableExtensions;

    using PPSystem.Common.Repository;
    using PPSystem.Models.CV;
    using PPSystem.Web.ViewModels.CV;

    public class CVController : Controller
    {
        private readonly IDeletableEntityRepository<CV> cvs;

        public CVController(IDeletableEntityRepository<CV> cvs)
        {
            this.cvs = cvs;
        }

        public ActionResult Index()
        {
            var cv = this.cvs.All().Project().To<CvViewModel>().FirstOrDefault();

            return View(cv);
        }
    }
}