using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    [Route("Calculate")]
    public class ArithmaticController:Controller
    {
        [HttpGet]
        [Route("SUM")]
        public IActionResult Summation([FromQuery] int n1, [FromQuery] int n2)
        {
            HttpClient client = new HttpClient();
            string url =string.Format("https://localhost:44301/Addition-Service/SUM?n1={0}&n2={1}", n1,n2);
            HttpResponseMessage res
                = client.GetAsync(url).Result;
            if (res.IsSuccessStatusCode)
            {
                return new JsonResult("Summation " + res.Content.ReadAsStringAsync().Result);
            }
            throw new Exception("Internal server Error");
        }

        [HttpGet]
        [Route("SUB")]
        public IActionResult Subtraction([FromQuery] int n1, [FromQuery] int n2)
        {
            HttpClient client = new HttpClient();
            string url = string.Format("https://localhost:44395/Subtraction-Service/SUB?n1={0}&n2={1}", n1, n2);
            HttpResponseMessage res
                = client.GetAsync(url).Result;
            if (res.IsSuccessStatusCode)
            {
                return new JsonResult("Subtraction " + res.Content.ReadAsStringAsync().Result);
            }
            throw new Exception("Internal server Error");
        }
    }
}
