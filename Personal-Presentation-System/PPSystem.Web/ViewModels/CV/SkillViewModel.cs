namespace PPSystem.Web.ViewModels.CV
{
    using PPSystem.Models.CV;
    using PPSystem.Web.Infrastructure.Mapping;
    
    public class SkillViewModel : IMapFrom<Skill>
    {
        public string Name { get; set; }

        public int Completion { get; set; }

        public SkillCategory Category { get; set; }
    }
}