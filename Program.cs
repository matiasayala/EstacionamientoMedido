using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EstacionamientoMedido.Helpers;
using EstacionamientoMedido.Services;
using FisSst.BlazorMaps.DependencyInjection;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EstacionamientoMedido
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient
            {
                BaseAddress = new Uri("https://infraccionesweb.herokuapp.com")
            });

            builder.Services.AddBlazorLeafletMaps();

            ConfigureServices(builder.Services);

            await builder.Build().RunAsync();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ComercioService>();
            services.AddScoped<InfraccionesService>();
            services.AddSingleton<SessionManager>();

        }
    }
}
