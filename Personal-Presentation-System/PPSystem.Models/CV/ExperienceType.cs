namespace PPSystem.Data.Models.CV
{
    using System.ComponentModel.DataAnnotations;

    public class ExperienceType
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Work experience, volunteer experience or something else.
        /// </summary>
        public string Name { get; set; }
    }
}
