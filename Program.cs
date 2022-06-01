using BlueShorts.Services;
using System.Threading.Tasks;

namespace BlueShorts
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            var host = Startup.CreateHostBuilder(args).Build();
            var weatherService = (WeatherService)host.Services.GetService(typeof(WeatherService))!;
            await weatherService.Run();
        }
    }
}