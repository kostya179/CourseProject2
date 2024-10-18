namespace Blog.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public required string Content { get; set; }
        public DateTime PostedAt { get; set; }
        public int AuthorId { get; set; }
        public required User Author { get; set; }
        public int ArticleId { get; set; }
        public required Article Article { get; set; }
        public ICollection<Like>? Likes { get; set; }
    }
}
