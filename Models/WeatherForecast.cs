using System.Collections.Generic;

namespace BlueShorts.Models
{
    public class WeatherForecast
    {
        public IEnumerable<ForecastDay> Forecastday { get; set; }
    }
}