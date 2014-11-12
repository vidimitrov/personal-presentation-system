namespace PPSystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web;
    using Microsoft.AspNet.Identity;
    using PPSystem.Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
        
        protected override void Seed(ApplicationDbContext context)
        {
            //var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context)); 
            //var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
     
            //string name = "Admin";
            //string password = "123456";
 
            ////Create Role Admin if it does not exist
            //if (!RoleManager.RoleExists(name))
            //{
            //    var roleresult = RoleManager.Create(new IdentityRole(name));
            //}
     
            ////Create User=Admin with password=123456
            //var user = new ApplicationUser();
            //user.UserName = name;
            //var adminresult = UserManager.Create(user, password);
     
            ////Add User Admin to Role Admin
            //if (adminresult.Succeeded)
            //{
            //    var result = UserManager.AddToRole(user.Id, name);
            //}

            InitializeIdentityForEF(context);
            base.Seed(context);
        }

        public static void InitializeIdentityForEF(ApplicationDbContext db) 
        {
            if (db.Users.Any()) 
            {
                return;
            }

            //const string name = "admin@admin.com";
            //const string password = "123456";
            //const string roleName = "Admin";
            
            //if (!db.Roles.Any(r => r.Name == roleName))
            //{
            //    db.Roles.Add(new IdentityRole(roleName));
            //}
                
            //var user = userManager.FindByName(name);
            //if (user == null) 
            //{
            //    user = new ApplicationUser { UserName = name, Email = name };
            //    var result = userManager.Create(user, password);
            //    result = userManager.SetLockoutEnabled(user.Id, false);
            //}
  
            //// Add user admin to Role Admin if not already added
            //var rolesForUser = userManager.GetRoles(user.Id);
            //if (!rolesForUser.Contains(role.Name)) 
            //{
            //    var result = userManager.AddToRole(user.Id, role.Name);
            //}
        }
    }
}
