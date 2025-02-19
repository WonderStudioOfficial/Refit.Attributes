using Microsoft.AspNetCore.Mvc;
using Wonder.Refit.Attributes.Sample.ApiStores;

namespace Wonder.Refit.Attributes.Sample.Controllers;

[ApiController]
[Route(ApiStore.WeatherForecasts.RoutePath)]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries =
    [
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    ];

    [HttpGet(ApiStore.WeatherForecasts.GetRandom)]
    public ActionResult<IEnumerable<WeatherForecast>> GetRandomWeatherForecasts(int number)
    {
        return Enumerable.Range(1, number).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        }).ToArray();
    }
}
