using Microsoft.AspNetCore.Mvc;

namespace AdditionService.Controllers
{
    [Route("Addition-Service")]
    public class AddController : Controller
    {
        [HttpGet]
        [Route("SUM")]
        public IActionResult Get([FromQuery] int n1, [FromQuery] int n2)
        {
            return Content((n1 + n2).ToString());
        }

    }
}
