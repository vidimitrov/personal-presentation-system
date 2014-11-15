namespace PPSystem.Web.ViewModels.Account
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    using PPSystem.Models;
    using PPSystem.Web.Infrastructure.Mapping;

    public class OwnerViewModel : IMapFrom<ApplicationUser>
    {
        public string Id { get; set; }

        [Display(Name = "Full name")]
        public string FullName { get; set; }

        public string Photo { get; set; }
        
        [Display(Name = "Is available")]
        public bool IsAvailable { get; set; }

        [Display(Name = "Job position")]
        public string JobPosition { get; set; }

        [Display(Name = "Job company")]
        public string JobCompany { get; set; }

        public string Summary { get; set; }

        public string Location { get; set; }

        public string Email { get; set; }

        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Facebook profile")]
        public string Facebook { get; set; }
        
        [Display(Name = "Google profile")]
        public string Google { get; set; }
        
        [Display(Name = "Twitter profile")]
        public string Twitter { get; set; }
        
        [Display(Name = "LinkedIn profile")]
        public string LinkedIn { get; set; }
        
        [Display(Name = "Github profile")]
        public string GitHub { get; set; }
    }
}