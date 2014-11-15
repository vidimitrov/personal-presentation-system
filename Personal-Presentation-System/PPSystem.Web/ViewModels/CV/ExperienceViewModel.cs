namespace PPSystem.Web.ViewModels.CV
{
    using System;

    using PPSystem.Models.CV;
    using PPSystem.Web.Infrastructure.Mapping;

    public class ExperienceViewModel : IMapFrom<Experience>
    {
        public ExperienceType Type { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        public string CompanyName { get; set; }

        public string JobTitle { get; set; }

        public string Description { get; set; }
    }
}