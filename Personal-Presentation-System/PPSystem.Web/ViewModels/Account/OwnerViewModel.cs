namespace PPSystem.Web.ViewModels.Account
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    using PPSystem.Models;
    using PPSystem.Web.Infrastructure.Mapping;

    public class OwnerViewModel : IMapFrom<ApplicationUser>
    {
        [Display(Name = "Full name")]
        public string FullName { get; set; }

        public string Photo { get; set; }

        public string JobPosition { get; set; }

        public string JobCompany { get; set; }

        public string Summary { get; set; }

        public string Location { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Facebook { get; set; }

        public string Google { get; set; }

        public string Twitter { get; set; }

        public string LinkedIn { get; set; }

        public string GitHub { get; set; }
    }
}