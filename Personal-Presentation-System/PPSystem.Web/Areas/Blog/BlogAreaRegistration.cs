using System.Web.Mvc;

namespace PPSystem.Web.Areas.Blog
{
    public class BlogAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Blog";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Blog_default",
                "Blog/{action}/{id}",
                new { controller = "Blog", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}