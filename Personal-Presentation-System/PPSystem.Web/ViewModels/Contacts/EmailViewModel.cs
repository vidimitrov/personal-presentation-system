using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace PPSystem.Web.ViewModels.Contacts
{
    public class EmailViewModel
    {
        [DisplayName("Your email")]
        public string EmailFrom { get; set; }
        
        [DisplayName("Your message")]
        public string Content { get; set; }
    }
}