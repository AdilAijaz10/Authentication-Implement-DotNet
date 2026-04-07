using Authentication_Implement_DotNet.Services;
using Authentication_Implement_DotNet.Models;
using Authentication_Implement_DotNet.Repositories;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace Authentication_Implement_DotNet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly JwtService _jwtService;

        public AuthController(JwtService jwtService)
        {
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public IActionResult Login(Models.LoginRequest request)
        {
            // 🔴 Hardcoded credentials
            if (request.UserId == "admin" && request.Password == "1234")
            {
                var token = _jwtService.GenerateToken(request.UserId);
                return Ok(new { token });
            }

            return Unauthorized("Invalid credentials");
        }
    }
}
