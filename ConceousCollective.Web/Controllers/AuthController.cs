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

            if (!result)
            {
                return BadRequest("User already registered!");
            }

            return Ok("Registered succesfully!");
        }

        [HttpPost("[action]")]
        public IActionResult Login(LoginRequest request)
        {
            var result = _authService.Login(request);

            if (result == null)
            {
                return Unauthorized("Invalid email or password");
            }

            return Ok(result);
        }
    }
}
