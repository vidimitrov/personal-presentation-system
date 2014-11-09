namespace PPSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using Microsoft.AspNet.Identity.EntityFramework;

    using PPSystem.Models;
    using PPSystem.Data.Migrations;
    using PPSystem.Models.Blog;
    using PPSystem.Models.Portfolio;
    using PPSystem.Models.CV;
    using PPSystem.Common.Models;
    
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }
        
        public IDbSet<Post> Posts { get; set; }
        public IDbSet<Comment> Comments { get; set; }
        public IDbSet<Tag> Tags { get; set; }

        public IDbSet<Portfolio> Portfolios { get; set; }
        public IDbSet<Project> Projects { get; set; }
        public IDbSet<Contributor> Contributors { get; set; }
        public IDbSet<ProjectCategory> ProjectCategories { get; set; }
        public IDbSet<Technology> Technologies { get; set; }

        public IDbSet<CV> CVs { get; set; }
        public IDbSet<Skill> Skills { get; set; }
        public IDbSet<SkillCategory> SkillCategories { get; set; }
        public IDbSet<Competition> Competitions { get; set; }
        public IDbSet<EducationInstitution> EducationInstitutions { get; set; }
        public IDbSet<Experience> Experiences { get; set; }
        public IDbSet<ExperienceType> ExperienceTypes { get; set; }
        public IDbSet<Language> Languages { get; set; }

        public override int SaveChanges()
        {
            this.ApplyAuditInfoRules();
            this.ApplyDeletableEntityRules();
            return base.SaveChanges();
        }

        private void ApplyAuditInfoRules()
        {
            // Approach via @julielerman: http://bit.ly/123661P
            foreach (var entry in
                this.ChangeTracker.Entries()
                    .Where(
                        e =>
                        e.Entity is IAuditInfo && ((e.State == EntityState.Added) || (e.State == EntityState.Modified))))
            {
                var entity = (IAuditInfo)entry.Entity;

                if (entry.State == EntityState.Added)
                {
                    if (!entity.PreserveCreatedOn)
                    {
                        entity.CreatedOn = DateTime.Now;
                    }
                }
                else
                {
                    entity.ModifiedOn = DateTime.Now;
                }
            }
        }

        private void ApplyDeletableEntityRules()
        {
            // Approach via @julielerman: http://bit.ly/123661P
            foreach (
                var entry in
                    this.ChangeTracker.Entries()
                        .Where(e => e.Entity is IDeletableEntity && (e.State == EntityState.Deleted)))
            {
                var entity = (IDeletableEntity)entry.Entity;

                entity.DeletedOn = DateTime.Now;
                entity.IsDeleted = true;
                entry.State = EntityState.Modified;
            }
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
