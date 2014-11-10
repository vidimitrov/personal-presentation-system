namespace PPSystem.Data.Models.Portfolio
{
    using System.ComponentModel.DataAnnotations;

    public class ProjectCategory
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
