using HomeworkFour.Business.Abstracts;
using HomeworkFour.Business.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HomeworkFour.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IJwtService jwtService;


        public UserController(IJwtService jwtService)
        {
            this.jwtService = jwtService;
        }



        [AllowAnonymous]
        [HttpPost]
        [Route("authenticate")]
        public IActionResult Authenticate(UserDto user)
        {

            var token = jwtService.Authenticate(
                new UserDto
                {
                    Name = user.Name,
                    Password = user.Password
                }
                );

            if (token == null)
            {
                return Unauthorized();
            }

            return Ok(token);
        }

    }
}
