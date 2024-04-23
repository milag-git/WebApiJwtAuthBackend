using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JwtWebApis.Models.DTO;

namespace JwtWebApis.Controllers
{
    //  [Route("api/[controller]/{action}")]
      [Route("[controller]")]

    [ApiController]
    [Authorize]
    public class ProtectedController : ControllerBase
    {
        [NonAction]
        public IActionResult GetData()
        {
            var status = new Status();
            status.StatusCode = 1;
            status.Message = "Data from protected controller";
            return Ok(status);
        }

        private static readonly string[] Summaries = new[]
   {
        "Protected Freezing", "Protected Bracing", "Protected  Chilly", " Protected Cool", " Protected Mild", "Protected Warm", "Protected Balmy", "Protected Hot", "Protected Sweltering", "Protected Scorching"
    };
        [HttpGet]

        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
