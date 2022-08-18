using Blazored.SessionStorage;
using eShopShare.Models.ApiModels;
using eShopShare.Models.ViewModels;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace eShopClient.Services
{
    public interface IUserService
    {
        Task<HttpResponseMessage> Login(ViewWebClientLogin model);
        Task<HttpResponseMessage> Register(StringContent content);
        Task<HttpResponseMessage> GetExist(string content);
        Task<HttpResponseMessage> ChangePassword(ChangePasswordViewModel model);
        Task<HttpResponseMessage> ResetPassword(string email);

    }
    public class UserService : IUserService
    {

        private readonly HttpClient _httpClient;
        private readonly ISyncSessionStorageService _syncSessionStorageService;
        

        public UserService(HttpClient httpClient, ISyncSessionStorageService syncSessionStorageService)
        {
            this._httpClient = httpClient;
            this._syncSessionStorageService = syncSessionStorageService;
        }

        public async Task<HttpResponseMessage> ChangePassword(ChangePasswordViewModel model)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), System.Text.Encoding.UTF8, "application/json");
            string accesstoken = _syncSessionStorageService.GetItem<string>("AccessToken");
            _httpClient.DefaultRequestHeaders.Authorization = new
                    System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accesstoken);
            var response = await _httpClient.PostAsync("User/change-password", content);
            return response;
        }

        public async Task<HttpResponseMessage> GetExist(string content)
        {
            var response = await _httpClient.GetAsync("User/" + content);
            return response;
        }

        public async Task<HttpResponseMessage> Login(ViewWebClientLogin model)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), System.Text.Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("Token", content);
            return response;
        }

        public async Task<HttpResponseMessage> Register(StringContent content)
        {
            var response = await _httpClient.PostAsync("User/dangky", content);
            return response;
        }

        public async Task<HttpResponseMessage> ResetPassword(string email)
        {
            StringContent content = new StringContent(email);
            var response = await _httpClient.PostAsync($"User/ForgetPassword?email={email}", content);
        
            return response;
        }
    }
}
