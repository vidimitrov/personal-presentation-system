namespace PPSystem.Web.ViewModels.CV
{
    using System.Collections.Generic;

    using PPSystem.Models.CV;
    using PPSystem.Web.Infrastructure.Mapping;

    public class CvViewModel : IMapFrom<PPSystem.Models.CV.CV>
    {
        public virtual ICollection<EducationInstitution> EducationInstitutions { get; set; }

        public virtual ICollection<Experience> Experiences { get; set; }

        public virtual ICollection<Competition> Competitions { get; set; }

        public virtual ICollection<Language> Languages { get; set; }

        public virtual ICollection<Skill> Skills { get; set; }
    }
}