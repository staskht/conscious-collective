using Microsoft.AspNetCore.Mvc;
using ServiceContracts;

namespace ConceousCollective.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public IActionResult Profile(Guid id)
        {
            var userProfileResponse = _userService.GetUserInformationById(id);

            if (userProfileResponse == null) 
            {
                return NotFound("User not found");
            }

            return Ok(userProfileResponse);
        }
    }
}
