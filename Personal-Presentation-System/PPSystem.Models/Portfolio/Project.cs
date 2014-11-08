namespace PPSystem.Models.Portfolio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Project
    {
        private ICollection<Contributor> contributors;
        private ICollection<Technology> technologies;

        public Project()
        {
            this.contributors = new HashSet<Contributor>();
            this.technologies = new HashSet<Technology>();
        }

        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public ProjectCategory Category { get; set; }

        public string RepoUrl { get; set; }

        public string Description { get; set; }

        public DateTime DateCreated { get; set; }
        
        public string Image { get; set; }
        
        public ICollection<Technology> Technologies
        { 
            get{ return this.technologies; }
            set { this.technologies = value; }
        }

        public virtual ICollection<Contributor> Contributors 
        { 
            get{ return this.contributors; }
            set { this.contributors = value; }
        }
    }
}