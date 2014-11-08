namespace PPSystem.Models.CV
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Competition
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Reward { get; set; }

        public string Image { get; set; }
    }
}
