using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using AdminPanel.Client.Services;
using System.Net.Http;

namespace AdminPanel.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddBaseAddressHttpClient();

            builder.Services.AddTransient<HttpClient>();

            builder.Services.AddTransient<ITransferService, TransferService>();
            builder.Services.AddTransient<IBankingService, BankingService>();

            await builder.Build().RunAsync();
        }
    }
}
