using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.ConfigureAppConfiguration((hostingContext, config) =>
                    {
                        config.AddXmlFile("myConfig.xml", optional: false, reloadOnChange: true);
                        config.AddJsonFile("myConfig.json", optional: true, reloadOnChange: true);
                        config.AddInMemoryCollection(new Dictionary<string, string>
                        {
                            {"StartedAtUtc", DateTime.UtcNow.ToString("O")}
                        });
                    });
                });
    }
}