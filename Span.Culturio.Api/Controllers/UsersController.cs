using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Span.Culturio.Api.Services.User;
using Span.Culturio.Api.Models;
using Span.Culturio.Api.Services;

namespace Span.FairBank.Api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;

        public UsersController(ILogger<UsersController> logger, IConfiguration configuration, IUserService userService)
        {
            _logger = logger;
            _configuration = configuration;
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<PaginatedListDto<UserDto>>> GetUsers(int pageIndex = 1, int pageSize = 10)
        {
            var users = await _userService.GetUsers(pageIndex, pageSize);
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetUser(int id)
        {
            var user = await _userService.GetUser(id);
            if (user is null)
                return NotFound("User not found.");

            return Ok(user);
        }
    }
}