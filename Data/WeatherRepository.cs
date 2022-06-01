using BlueShorts.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace BlueShorts.Data
{
    public class WeatherRepository
    {
        // The response from the API will be in snake_case format
        private readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            },
        };

        public Weather GetWeatherForecast(string location)
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