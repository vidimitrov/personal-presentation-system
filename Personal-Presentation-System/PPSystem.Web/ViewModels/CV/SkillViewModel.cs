namespace PPSystem.Web.ViewModels.CV
{
    using PPSystem.Models.CV;
    using PPSystem.Web.Infrastructure.Mapping;
    
    public class SkillViewModel : IMapFrom<Skill>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Completion { get; set; }

        public SkillCategory Category { get; set; }

        public bool IsDeleted { get; set; }
    }
}