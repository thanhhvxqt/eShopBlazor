using Blazored.LocalStorage;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


public class CustomAuthStateProvider : AuthenticationStateProvider
{

    public CustomAuthStateProvider(ISyncSessionStorageService syncSessionStorageService)
    {
      
        _SyncSessionStorageService = syncSessionStorageService;
    }

    public ISyncSessionStorageService _SyncSessionStorageService { get; }

    public override async Task< AuthenticationState> GetAuthenticationStateAsync()
    {
        var state = new AuthenticationState(new ClaimsPrincipal());

        string username =   _SyncSessionStorageService.GetItem<string>("UserName");
        string assestoken =   _SyncSessionStorageService.GetItem<string>("AccessToken");
        string khachid =   _SyncSessionStorageService.GetItem<string>("KhachhangId");
        string email =   _SyncSessionStorageService.GetItem<string>("Email");

        if (!string.IsNullOrEmpty(username))
        {
            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, username),
                new Claim("id", khachid),
                new Claim(ClaimTypes.Email, email),
                new Claim("token",assestoken),
            }, "test authentication type");

            state = new AuthenticationState(new ClaimsPrincipal(identity));
        }
        NotifyAuthenticationStateChanged(Task.FromResult(state));
        return state;
    }
}

