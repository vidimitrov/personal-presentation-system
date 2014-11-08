namespace PPSystem.Models
{
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public string FullName { get; set; }

        public bool IsAvailable { get; set; }

        public string Photo { get; set; }

        public string JobPosition { get; set; }

        public string JobCompany { get; set; }

        public string Summary { get; set; }

        public string PhoneNumber { get; set; }

        public string Location { get; set; }

        public string WebSite { get; set; }

        public string Skype { get; set; }

        public string Facebook { get; set; }

        public string Google { get; set; }

        public string Twitter { get; set; }

        public string LinkedIn { get; set; }

        public string GitHub { get; set; }
    }
}
