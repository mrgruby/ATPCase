using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerAllocator;

namespace AtpCase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllocationController : ControllerBase
    {
        [HttpGet("AllocateServer")]
        public IActionResult Allocate(string serverType) 
        {
            var res = AllocateServer.Allocate(serverType);
            return Ok(res);
        }
    }
}
