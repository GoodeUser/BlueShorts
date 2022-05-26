using BlueShorts.Data;

namespace BlueShorts.Services;

public class WeatherService
{
    private readonly WeatherRepository _weatherRepository;

    public WeatherService(WeatherRepository weatherRepository)
    {
        _weatherRepository = weatherRepository;
    }

    public async Task Run()
    {
        Console.Write("What US city would you like to get weather for? [Ex: Phoenix, AZ or ZIP Code]  ");
        var location = Console.ReadLine() ?? "";

        var weather = await _weatherRepository.GetWeatherForecast(location);
        Console.WriteLine($"The current weather is {weather.Current.TempF} degrees Fahrenheit.");
    }
}