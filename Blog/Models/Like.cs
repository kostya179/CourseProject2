namespace Blog.Models
{
    public class Like
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public required User User { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
        public int CommentId { get; set; }
        public required Comment Comment { get; set; }
    }
}
