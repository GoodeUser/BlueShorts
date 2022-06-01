namespace BlueShorts.Models
{
    public class Weather
    {
        public Weather(WeatherForecast forecast, CurrentWeather current)
        {
            Forecast = forecast;
            Current = current;
        }

        public WeatherForecast Forecast { get; set; }
        public CurrentWeather Current { get; set; }
    }
}