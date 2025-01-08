using FortyFlavors.Core.Api.Services;
using FortyFlavors.Core.Application.DTOs.DtoS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FortyFlavors.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthenticationService _authService;

        public AuthController(AuthenticationService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login(UserLoginDto loginDto)
        {
           
            if (loginDto.Username == "admin" && loginDto.Password == "password")
            {
                var roles = new List<string> { "Admin" };
                var token = _authService.GenerateJwtToken(loginDto.Username, roles);
                return Ok(new { Token = token });
            }

            return Unauthorized("Geçersiz kullanıcı adı veya şifre.");
        }
    }
}
