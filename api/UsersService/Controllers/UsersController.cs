using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UsersService.Configuration;
using UsersService.Data;

namespace UsersService.Controllers
{
    [ApiController]
    [Route("users")]
    public class UsersController : ControllerBase
    {
        private readonly AuthOptions _options;
        private readonly ApplicationDbContext _context;
        public UsersController(AuthOptions options, ApplicationDbContext context)
        {
            _options = options;
            _context = context;
        }

        [HttpPost("register")]
        public IActionResult Register()
        {
            // TODO: Зробити логіку реєстрації (логін , ім'я , електронна пошта , пароль)
            return Ok(new
            {
                msg = "Not Implemented"
            });
        }

        [HttpPost("login")]
        public IActionResult Login()
        {
            // TODO: Зробити логіку авторизації (логін і пароль)
            return Ok(new
            {
                msg = "Not Implemented"
            });
        }

        [HttpPost("info")]
        public IActionResult PrivateInfo()
        {
            // TODO: Зробити логіку отримання приватної інформації (Name, Email , Password, Login , PhotoUrl)
            return Ok(new
            {
                email = User.Identity?.Name,
                msg = "Not Implemented"
            });
        }

        [HttpGet("info/{login}")]
        public IActionResult PublicInfo(string login)
        {
            // TODO: Зробити логіку отримання публічної інформації про користувача (Email , Name , PhotoUrl)
            return Ok(new
            {
                msg = "Not implemented",
                login
            });
        }
    }
}
