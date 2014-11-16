namespace PPSystem.Web.ViewModels.Portfolio
{
    using PPSystem.Models.Portfolio;
    using PPSystem.Web.Infrastructure.Mapping;

    public class TechnologyViewModel : IMapFrom<Technology>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}