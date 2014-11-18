namespace PPSystem.Web.Models.Emails
{
    using Postal;

    public class ContactEmail : Email
    {
        public string To { get; set; }

        public string From { get; set; }

        public string Message { get; set; }
    }
}