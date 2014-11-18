namespace PPSystem.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using Postal;
    using PPSystem.Web.ViewModels.Contacts;
    using PPSystem.Web.Models.Emails;

    public class ContactsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SendMail(EmailViewModel inputEmail)
        {
            if (ModelState.IsValid)
            {
                var email = new ContactEmail
                {
                    To = "vidimitrov94@gmail.com", //this.User.Identity.Name,
                    From = inputEmail.EmailFrom,
                    Message = inputEmail.Content
                };

                email.Send();
            }

            return RedirectToAction("Index", "Contacts");
        }
    }
}