namespace PPSystem.Models.Portfolio
{
    using PPSystem.Common.Models;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Review : AuditInfo, IDeletableEntity
    {
        [Key]
        public int Id { get; set; }

        public string Content { get; set; }

        public string ReviewerName { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
