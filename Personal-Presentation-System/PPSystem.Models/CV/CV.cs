namespace PPSystem.Models.CV
{
    using PPSystem.Common.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CV : AuditInfo, IDeletableEntity
    {
        private ICollection<EducationInstitution> educationInstitutions;
        private ICollection<Experience> experiences;
        private ICollection<Competition> competitions;
        private ICollection<Language> languages;
        private ICollection<Skill> skills;

        public CV()
        {
            this.educationInstitutions = new HashSet<EducationInstitution>();
            this.experiences = new HashSet<Experience>();
            this.competitions = new HashSet<Competition>();
            this.languages = new HashSet<Language>();
            this.skills = new HashSet<Skill>();
        }

        [Key]
        public int Id { get; set; }

        public virtual ICollection<EducationInstitution> EducationInstitutions { get; set; }

        public virtual ICollection<Experience> Experiences { get; set; }

        public virtual ICollection<Competition> Competitions { get; set; }

        public virtual ICollection<Language> Languages { get; set; }

        public virtual ICollection<Skill> Skills { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}