using PPSystem.Models.Portfolio;
using PPSystem.Web.Infrastructure.Mapping;
namespace PPSystem.Web.ViewModels.Portfolio
{
    public class ContributorViewModel : IMapFrom<Contributor>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string VersionControlSystemProfile { get; set; }

        public string ContributionType { get; set; }
    }
}