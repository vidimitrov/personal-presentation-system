namespace PPSystem.Models.Portfolio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using PPSystem.Common.Models;

    public class Portfolio : AuditInfo, IDeletableEntity
    {
        private ICollection<Project> projects;

        public Portfolio()
        {
            this.CreatedOn = DateTime.Now;

            this.projects = new HashSet<Project>();
        }

        [Key]
        public int Id { get; set; }

        public virtual ICollection<Project> Projects
        {
            get { return this.projects; }
            set { this.projects = value; }
        }

        public bool IsDeleted { get; set; }

        public System.DateTime? DeletedOn { get; set; }
    }
}