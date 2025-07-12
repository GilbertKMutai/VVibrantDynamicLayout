using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using VVibrantDynamicLayout.Client.Configuration;

namespace VVibrantDynamicLayout.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            builder.Services.Configure<LayoutSettings>(builder.Configuration.GetSection("Layout"));

            var tm = builder.Configuration.GetSection("");

            await builder.Build().RunAsync();
        }
    }
}
