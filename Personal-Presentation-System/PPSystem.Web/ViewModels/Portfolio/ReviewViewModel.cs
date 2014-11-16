namespace PPSystem.Web.ViewModels.Portfolio
{
    using PPSystem.Models.Portfolio;
    using PPSystem.Web.Infrastructure.Mapping;

    public class ReviewViewModel: IMapFrom<Review>
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public string ReviewerName { get; set; }
    }
}