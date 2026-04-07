using Authentication_Implement_DotNet.Repositories;
using Authentication_Implement_DotNet.Services;
using Authentication_Implement_DotNet.Models;
using Authentication_Implement_DotNet.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace Authentication_Implement_DotNet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : Controller
    {
        private readonly IHelloRepository _repo;

        public HelloController(IHelloRepository repo)
        {
            _repo = repo;
        }
        
        [HttpGet("get1")]
        public IActionResult Get()
        {
            var message = _repo.GetMessage();
            return Ok(message);
        }

        [HttpGet("adil")]
        public IActionResult GetAdil()
        {
            var message = _repo.GetMessage();
            return Ok(message);
        }
    }

}
