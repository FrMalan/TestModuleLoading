using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BlazorLazyLoading.Wasm;

namespace Stratos.Workbench.WebClient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddLazyLoading(new LazyLoadingOptions
            {
                ModuleHints = new[] { "Stratos.Workbench.ModuleHost" }
            });

            await builder.Build().RunAsync();
        }
    }
}
