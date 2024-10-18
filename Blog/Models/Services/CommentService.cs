namespace Blog.Models.Services
{
    public class CommentService
    {
        public async Task<Comment> GetCommentByIdAsync(int id) 
        {
            return null;
        }
        public async Task<IEnumerable<Comment>> GetCommentsForArticleAsync(int articleId)
        {
            return null;
        }
        public async Task<Comment> CreateCommentAsync(Comment comment) 
        {
            return null;
        }
        public async Task DeleteCommentAsync(int id) 
        {
            
        }
    }
}
