using BlueShorts.Data;
using BlueShorts.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BlueShorts;

public class Startup
{
    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        var hostBuilder = Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((context, builder) =>
            {
                builder.SetBasePath(Directory.GetCurrentDirectory());
            })
            .ConfigureServices(ConfigureServices);

        return hostBuilder;
    }

    public static void ConfigureServices(HostBuilderContext context, IServiceCollection services)
    {
        // add services
        services.AddTransient<WeatherRepository>();
        services.AddTransient<WeatherService>();
    }
}