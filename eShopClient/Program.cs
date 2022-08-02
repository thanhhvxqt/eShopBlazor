using Blazored.SessionStorage;
using eShopClient.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Blazored.Toast;


namespace eShopClient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddBlazoredSessionStorage();

            builder.Services.AddHttpClient();

            //builder.Services.AddTransient<HttpContext>();
            builder.Services.AddScoped<IOnChangeService, OnChangeService>();

            builder.Services.AddScoped<AuthenticationStateProvider,CustomAuthStateProvider>();

            builder.Services.AddBlazoredToast();
            builder.Services.AddAuthorizationCore(); 
 

            await builder.Build().RunAsync();
        }
    }
}
