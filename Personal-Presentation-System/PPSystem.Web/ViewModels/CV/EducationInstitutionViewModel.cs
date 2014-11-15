namespace PPSystem.Web.ViewModels.CV
{
    using System;

    using PPSystem.Models.CV;
    using PPSystem.Web.Infrastructure.Mapping;

    public class EducationInstitutionViewModel : IMapFrom<EducationInstitution>
    {
        public string Name { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }
    }
}