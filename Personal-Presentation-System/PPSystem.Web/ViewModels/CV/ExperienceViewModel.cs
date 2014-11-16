namespace PPSystem.Web.ViewModels.CV
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using PPSystem.Models.CV;
    using PPSystem.Web.Infrastructure.Mapping;

    public class ExperienceViewModel : IMapFrom<Experience>
    {
        public int Id { get; set; }

        public ExperienceType Type { get; set; }

        [Display(Name = "Worked from")]
        public DateTime? From { get; set; }
        
        [Display(Name = "Worked to")]
        public DateTime? To { get; set; }

        public bool IsDeleted { get; set; }

        public string CompanyName { get; set; }

        public string JobTitle { get; set; }

        public string Description { get; set; }
    }
}