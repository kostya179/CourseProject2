using Blog.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LikeController : ControllerBase
    {
        private readonly LikeService _likeService;

        public LikeController(LikeService likeService)
        {
            _likeService = likeService;
        }

        [HttpPost("article/{id}")]
        public async Task<IActionResult> LikeArticle(int id)
        {
            return null;
        }

        [HttpDelete("article/{id}")]
        public async Task<IActionResult> UnlikeArticle(int id)
        {
            return null;
        }

        [HttpPost("comment/{id}")]
        public async Task<IActionResult> LikeComment(int id)
        {
            return null;
        }

        [HttpDelete("comment/{id}")]
        public async Task<IActionResult> UnlikeComment(int id)
        {
            return null;
        }
    }
}
