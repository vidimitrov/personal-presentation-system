namespace PPSystem.Models.CV
{
    using System.ComponentModel.DataAnnotations;

    public class Language
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
