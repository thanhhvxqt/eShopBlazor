using Blazored.LocalStorage;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Authentication;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

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
        string name =   _SyncSessionStorageService.GetItem<string>("Name");

        if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(assestoken) 
            && !string.IsNullOrEmpty(khachid) && !string.IsNullOrEmpty(email))
        {
            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, name),
                new Claim("UserName", username),
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

