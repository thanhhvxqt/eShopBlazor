using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eShopClient.Services
{
    public interface IOnChangeService
    {
        event Action OnChange;
        void Invoke();
    }
    public class OnChangeService : IOnChangeService
    {

        public event Action OnChange;
        
        public void Invoke()
        {
            OnChange.Invoke();
        }
    }
}

