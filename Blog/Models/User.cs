namespace Blog.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string UserName { get; set; }
        public required string PasswordHash { get; set; }
        public required string FullName { get; set; }
        public required string AvatarUrl{ get; set; }
        public required string Role { get; set; }
        public DateTime RegisteredAt{ get; set; }
        public ICollection<Article>? Articles { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Like>? Likes { get; set; }
    }
}
