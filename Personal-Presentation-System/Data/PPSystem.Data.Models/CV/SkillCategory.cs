namespace PPSystem.Data.Models.CV
{
    using System.ComponentModel.DataAnnotations;

    public class SkillCategory
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}