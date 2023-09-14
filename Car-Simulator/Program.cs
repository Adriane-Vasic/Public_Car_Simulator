
using Microsoft.Extensions.DependencyInjection;
using Car_Simulator;
using CarLibrary;
using Microsoft.Extensions.Hosting;
using ServiceLibrary.Services;
using ServiceLibrary.Services.Menu;
using ServiceLibrary.Services.Direction;

public class Program
{
    public static void Main(string[] args)
    {

        using (var host = CreateHostBuilder(args).Build())
        {
            var app = host.Services.GetRequiredService<Application>();

            app.Run();
        }


    }

    static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                services.AddTransient<Application>();

                services.AddTransient<IDriverService, DriverService>();
                services.AddTransient<ICarService, CarService>();

                services.AddTransient<ISimulatorService, SimulatorService>();
                services.AddTransient<IStatusService, StatusService>();

                services.AddTransient<IForwardDirectionService, ForwardDirectionService>();
                services.AddTransient<IReverseDirectionService, ReverseDirectionService>();
                
            });
    }

}





