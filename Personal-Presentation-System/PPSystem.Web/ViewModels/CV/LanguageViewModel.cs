namespace PPSystem.Web.ViewModels.CV
{
    using PPSystem.Models.CV;
    using PPSystem.Web.Infrastructure.Mapping;

    public class LanguageViewModel : IMapFrom<Language>
    {
        public string Name { get; set; }
    }
}