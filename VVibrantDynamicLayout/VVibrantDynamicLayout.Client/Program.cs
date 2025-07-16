using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using VVibrantDynamicLayout.Client.Configuration;
using VVibrantDynamicLayout.Client.Services;

namespace VVibrantDynamicLayout.Client;

internal class Program
{
    static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);

        builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        builder.Services.Configure<LayoutSettings>(builder.Configuration.GetSection("Layout"));

        builder.Services.AddSingleton<ComponentRegistryService>();

        await builder.Build().RunAsync();
    }
}
