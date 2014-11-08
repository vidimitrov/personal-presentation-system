namespace PPSystem.Models.Portfolio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Contributor
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string VersionControlSystemProfile { get; set; }

        public string ContributionType { get; set; }
    }
}
