namespace PPSystem.Web.ViewModels.Portfolio
{
    using System.Collections.Generic;

    using PPSystem.Web.Infrastructure.Mapping;
    using PPSystem.Models.Portfolio;

    public class PortfolioViewModel : IMapFrom<Portfolio>
    {
        public int Id { get; set; }

        public virtual ICollection<ProjectViewModel> Projects { get; set; }
    }
}