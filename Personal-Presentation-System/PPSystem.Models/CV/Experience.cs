namespace PPSystem.Data.Models.CV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Experience
    {
        [Key]
        public int Id { get; set; }

        public ExperienceType Type { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        public string CompanyName { get; set; }

        public string JobTitle { get; set; }

        public string Description { get; set; }
    }
}
