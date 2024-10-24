using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace PokeApiApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var services = CreateServices();
            Application app = services.GetRequiredService<Application>();
            app.MyLogic();
        }

        private static ServiceProvider CreateServices()
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<Application>(new Application())
                .AddLogging(logging=> logging.AddSimpleConsole())
                //.AddLogging(logging => logging.AddConsole())
                .BuildServiceProvider();

            return serviceProvider;
        }
    }

    public class Application
    {
        public void MyLogic()
        {
            Console.WriteLine("Hello World."); 
        }
    }
}