using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningExample.Controllers.v1
{
    
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class ValuesController : ControllerBase
    {
        [HttpGet] 
        public IActionResult Get()
        {
            return Ok("V-1");
        }

    }


}
