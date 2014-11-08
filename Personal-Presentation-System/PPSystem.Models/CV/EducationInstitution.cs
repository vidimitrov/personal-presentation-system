namespace PPSystem.Models.CV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class EducationInstitution
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
