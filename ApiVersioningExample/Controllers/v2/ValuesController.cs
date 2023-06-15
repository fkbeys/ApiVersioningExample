using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningExample.Controllers.v2
{
   
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("2.0")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("V-2");
        }

    }


}
