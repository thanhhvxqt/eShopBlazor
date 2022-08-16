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
using System.Text.Json;

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
            builder.Services.AddHttpClient<ICallProductSvc, CallProductSvc>(client =>
            {
                client.BaseAddress = new Uri(builder.Configuration.GetSection("API")["APIUrl"].ToString());
                client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            });
            builder.Services.AddHttpClient<ILoginAndRegisterService, LoginAndRegisterService>(client =>
            {
                client.BaseAddress = new Uri(builder.Configuration.GetSection("API")["APIUrl"].ToString());
                client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            });
            builder.Services.AddScoped<ICartService, CartServices>();
            builder.Services.AddScoped<IGetNameOrEmailSvc, GetNameOrEmailSvc>();
            
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddScoped<HttpContextAccessor>();

            await builder.Build().RunAsync();
        }
    }
}
