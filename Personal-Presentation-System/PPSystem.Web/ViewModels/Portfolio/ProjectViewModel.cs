namespace PPSystem.Web.ViewModels.Portfolio
{
    using System.Collections.Generic;

    using PPSystem.Models.Portfolio;
    using PPSystem.Web.Infrastructure.Mapping;

    public class ProjectViewModel: IMapFrom<Project>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public ProjectCategory Category { get; set; }

        public string RepoUrl { get; set; }

        public string Description { get; set; }
                
        public string Image { get; set; }

        public int Rating { get; set; }

        public virtual ICollection<ReviewViewModel> Reviews { get; set; }

        public virtual ICollection<TechnologyViewModel> Technologies { get; set; }

        public virtual ICollection<ContributorViewModel> Contributors { get; set; }
    }
}