namespace PPSystem.Models.Portfolio
{
    using PPSystem.Common.Models;
    using System.ComponentModel.DataAnnotations;

    public class ProjectCategory : AuditInfo, IDeletableEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public System.DateTime? DeletedOn { get; set; }
    }
}
