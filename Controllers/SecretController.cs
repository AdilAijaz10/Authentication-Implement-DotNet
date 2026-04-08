using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Authentication_Implement_DotNet.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class SecretController : Controller
    {
        private readonly string _mySecretKey;

        // Inject IConfiguration to read from appsettings.json
        public SecretController(IConfiguration configuration)
        {
            _mySecretKey = configuration["Jwt:Key"];
        }

        // GET api/secret/validate?key=yourKeyHere
        [HttpGet("validate")]
        public IActionResult ValidateSecret([FromQuery] string key)
        {
            if (string.IsNullOrEmpty(key))
                return BadRequest(new { success = false, message = "Key is required" });

            bool isValid = key == _mySecretKey;

            return Ok(new { success = isValid });
        }
    }
}
