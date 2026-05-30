using Microsoft.AspNetCore.Mvc;
using ServiceContracts;
using ServiceContracts.DTOs;

namespace ConceousCollective.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("[action]")]
        public IActionResult Register(RegisterRequest request)
        {
            var result = _authService.Register(request);

            if (result.Contains("already exists"))
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpPost("[action]")]
        public IActionResult Login(LoginRequest request)
        {
            var result = _authService.Login(request);

            if (result.Contains("Invalid"))
            {
                return Unauthorized(result);
            }

            return Ok(result);
        }
    }
}
