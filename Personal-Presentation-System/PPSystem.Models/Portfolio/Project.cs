namespace PPSystem.Models.Portfolio
{
    using PPSystem.Common.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Project : AuditInfo, IDeletableEntity
    {
        private ICollection<Contributor> contributors;
        private ICollection<Technology> technologies;
        private ICollection<Review> reviews;

        public Project()
        {
            this.contributors = new HashSet<Contributor>();
            this.technologies = new HashSet<Technology>();
            this.reviews = new HashSet<Review>();
        }

        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public ProjectCategory Category { get; set; }

        public string RepoUrl { get; set; }

        public string Description { get; set; }
                
        public string Image { get; set; }

        public int Rating { get; set; }

        public virtual ICollection<Review> Reviews
        { 
            get{ return this.reviews; }
            set { this.reviews = value; }
        }
        
        public virtual ICollection<Technology> Technologies
        { 
            get{ return this.technologies; }
            set { this.technologies = value; }
        }

        public virtual ICollection<Contributor> Contributors 
        { 
            get{ return this.contributors; }
            set { this.contributors = value; }
        }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}