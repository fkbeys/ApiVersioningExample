using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningExample.Controllers.multi
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class MultiController : ControllerBase
    {
        [HttpGet]
        [MapToApiVersion("1.0")]
        public IActionResult Get1()
        {
            return Ok("V-1");
        }


        [HttpGet]
        [MapToApiVersion("2.0")]
        public IActionResult Get2()
        {
            return Ok("V-2");
        }


    }
}
