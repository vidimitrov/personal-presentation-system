namespace PPSystem.Web.ViewModels.CV
{
    using System.Collections.Generic;

    using PPSystem.Models.CV;
    using PPSystem.Web.Infrastructure.Mapping;

    public class CvViewModel : IMapFrom<PPSystem.Models.CV.CV>
    {
        public virtual ICollection<EducationInstitutionViewModel> EducationInstitutions { get; set; }

        public virtual ICollection<ExperienceViewModel> Experiences { get; set; }

        public virtual ICollection<CompetitionViewModel> Competitions { get; set; }

        public virtual ICollection<LanguageViewModel> Languages { get; set; }

        public virtual ICollection<SkillViewModel> Skills { get; set; }
    }
}