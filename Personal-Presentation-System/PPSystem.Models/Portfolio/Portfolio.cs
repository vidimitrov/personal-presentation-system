namespace PPSystem.Data.Models.Portfolio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Portfolio
    {
        private ICollection<Project> projects;

        public Portfolio()
        {
            this.projects = new HashSet<Project>();
        }

        [Key]
        public int Id { get; set; }

        public virtual ICollection<Project> Projects
        {
            get { return this.projects; }
            set { this.projects = value; }
        }
    }
}