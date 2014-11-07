namespace PPSystem.Models.Blog
{
    using System.ComponentModel.DataAnnotations;

    public class Comment
    {
        public Comment()
        {
            this.IsVisible = true;
        }

        [Key]
        public int Id { get; set; }

        public bool IsVisible { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public string ContactEmail { get; set; }

        public int PostId { get; set; }

        public virtual Post Post { get; set; }
    }
}