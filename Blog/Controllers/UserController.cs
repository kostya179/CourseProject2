using Blog.Models;
using Blog.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(User user)
        {
            return null;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(string username, string password)
        {
            return null;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            return null;
        }
    }
}
