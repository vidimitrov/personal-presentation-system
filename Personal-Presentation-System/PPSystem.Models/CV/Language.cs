namespace PPSystem.Models.CV
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using PPSystem.Common.Models;

    public class Language : AuditInfo, IDeletableEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
