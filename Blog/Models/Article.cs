namespace Blog.Models
{
    public class Article
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
        public required string Category { get; set; }
        public string? Tags { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime PublishedAt { get; set; }
        public int AuthorId { get; set; }
        public required User Author {  get; set; }
        public ICollection<Comment>? Comments {  get; set; }
        public ICollection<Like>? Likes { get; set; }
    }
}
