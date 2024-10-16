using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Hosted.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddHttpClient("", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
            builder.RootComponents.Add<App>("#app");
            await builder.Build().RunAsync();
        }
    }
}
