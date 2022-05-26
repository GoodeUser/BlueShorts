using BlueShorts.Models;

namespace BlueShorts.Data
{
    public class WeatherRepository
    {
        public async Task<Weather> GetWeatherForecast(string location)
        {
            var current = new CurrentWeather
            {
                LastUpdated = DateTime.Now,
                TempF = 70
            };

            var forecast = new WeatherForecast
            {
                Forecastday = new[]
                {
                    new ForecastDay
                    {
                        MaxtempF = 100,
                        MintempF = 50,
                    }
                },
            };

            return new Weather(forecast, current);
        }
    }
}