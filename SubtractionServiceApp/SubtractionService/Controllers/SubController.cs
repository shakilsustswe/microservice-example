using Microsoft.AspNetCore.Mvc;

namespace SubtractionService.Controllers
{
    [Route("Subtraction-Service")]
    public class SubController : Controller
    {
        [HttpGet]
        [Route("SUB")]
        public IActionResult Get([FromQuery] int n1, [FromQuery] int n2)
        {
            if (n1 >= n2)
            {
                return Content((n1 - n2).ToString());
            }
            else
            {
                return Content((n2 - n1).ToString());
            }

        }
    }
}
