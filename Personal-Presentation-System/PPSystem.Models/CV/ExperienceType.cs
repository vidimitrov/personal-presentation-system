namespace PPSystem.Models.CV
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using PPSystem.Common.Models;

    public class ExperienceType : AuditInfo, IDeletableEntity
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Work experience, volunteer experience or something else.
        /// </summary>
        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
