namespace BlueShorts.Models;

public class WeatherForecast
{
    public IEnumerable<ForecastDay> Forecastday { get; set; } = Enumerable.Empty<ForecastDay>();
}