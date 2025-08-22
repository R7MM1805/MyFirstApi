using Microsoft.AspNetCore.Mvc;
using MyFirstApi.DTO;

namespace MyFirstApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class WeatherForecastController : Controller
    {
        private static readonly List<string> summaries = ["Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"];

        [HttpGet("GetWeatherForecast")]
        public List<WeatherForecastDTO> GetWeatherForecast() => [.. Enumerable.Range(1, 5).Select(i => new WeatherForecastDTO
            (
                DateOnly.FromDateTime(DateTime.Now.AddDays(i)),
                Random.Shared.Next(-20, 55),
                summaries[Random.Shared.Next(summaries.Count - 1)]
            ))];
    }
}