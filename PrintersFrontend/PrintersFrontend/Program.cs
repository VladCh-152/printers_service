using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using PrintersFrontend.Services;

namespace PrintersFrontend
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => {
                var http = new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
                return http;
            });

            builder.Services.AddScoped<LocalStorageService>();
            builder.Services.AddScoped<AuthService>();
            builder.Services.AddScoped<PrinterService>();

            await builder.Build().RunAsync();
        }
    }
}
