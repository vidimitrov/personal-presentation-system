namespace PPSystem.Data.Models.CV
{
    using System.ComponentModel.DataAnnotations;

    public class Skill
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Completion { get; set; }

        public SkillCategory Category { get; set; }
    }
}