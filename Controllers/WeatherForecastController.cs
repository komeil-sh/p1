using System.ComponentModel;
using System;
using DevExpress.Xpo;
using Microsoft.AspNetCore.Mvc;
using p1.DbModels;

namespace p1.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async IEnumerable<WeatherForecast> Get()
    {
        var ddd = new List<string>();
        var unit = new UnitOfWork();
        var rr = await unit.Query<Users>().Where(c => c.FirstName == "komeil").AnyAsync();

        // validate email a string

    


        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();

    }
}
