namespace PPSystem.Models.CV
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using PPSystem.Common.Models;

    public class Competition : AuditInfo, IDeletableEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Reward { get; set; }

        public string Image { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
