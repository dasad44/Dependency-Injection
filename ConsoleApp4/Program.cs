using Microsoft.Extensions.Hosting;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp4
{
    class Program
    {
        private readonly ServiceA _serviceA;
        public Program(ServiceA service)
        {
            _serviceA = service;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("program starting");
            var host = CreateHostBuilder(args).Build();
            host.Services.GetRequiredService<Program>().Run();
            Console.ReadKey();
        }

        public void Run()
        {
            _serviceA.dosomethinga();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddScoped<IServiceC, ServiceC>();
                    services.AddScoped<IServiceB, ServiceB>();
                    services.AddTransient<ServiceA>();
                    services.AddTransient<Program>();
                });
        }
    }
}
