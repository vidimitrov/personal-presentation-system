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
            this.EducationInstitutions = new HashSet<EducationInstitution>();
            this.Experiences = new HashSet<Experience>();
            this.Competitions = new HashSet<Competition>();
            this.Languages = new HashSet<Language>();
            this.Skills = new HashSet<Skill>();
        }

        public CV(string ownerId, DateTime createdOn)
            : base()
        {
            this.OwnerId = ownerId;
            this.CreatedOn = createdOn;
        }

        [Key]
        public int Id { get; set; }

        public virtual string OwnerId { get; set; }

        public virtual ICollection<EducationInstitution> EducationInstitutions 
        {
            get
            {
                return this.educationInstitutions;
            }
            set
            {
                this.educationInstitutions = value;
            }
        }

        public virtual ICollection<Experience> Experiences 
        {
            get
            {
                return this.experiences;
            }
            set
            {
                this.experiences = value;
            }
        }

        public virtual ICollection<Competition> Competitions
        {
            get
            {
                return this.competitions;
            }
            set
            {
                this.competitions = value;
            }
        }

        public virtual ICollection<Language> Languages 
        {
            get
            {
                return this.languages;
            }
            set
            {
                this.languages = value;
            }
        }

        public virtual ICollection<Skill> Skills 
        {
            get
            {
                return this.skills;
            }
            set
            {
                this.skills = value;
            }
        }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}