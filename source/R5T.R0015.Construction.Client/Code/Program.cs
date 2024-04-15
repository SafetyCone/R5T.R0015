using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


namespace R5T.R0015.Construction.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            await builder.Build().RunAsync();
        }
    }
}