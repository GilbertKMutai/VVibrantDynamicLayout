using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using VVibrantDynamicLayout.Client.Models;

namespace VVibrantDynamicLayout.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            builder.Services.Configure<LayoutViewModel>(builder.Configuration.GetSection("Layout"));

            await builder.Build().RunAsync();
        }
    }
}
