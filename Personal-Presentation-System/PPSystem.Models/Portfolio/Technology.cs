namespace PPSystem.Models.Portfolio
{
    using System.ComponentModel.DataAnnotations;

    public class Technology
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
