using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
         .ConfigureServices((context, services) =>
         {
             services.Configure<KestrelServerOptions>(
                 context.Configuration.GetSection("Kestrel"));
         }).ConfigureLogging(logging =>
         {
             // clear default logging providers
             logging.ClearProviders();

             // add built-in providers manually, as needed 
             logging.AddConsole();
             logging.AddDebug();
             logging.AddEventLog();
             logging.AddEventSourceLogger();
         })
         .ConfigureWebHostDefaults(webBuilder =>
         {
             webBuilder.UseStartup<Startup>();
         });
    }
}
