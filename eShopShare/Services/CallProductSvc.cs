using eShopClient.Paging;
using eShopShare.Models.Paging;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


public interface ICallProductSvc
{
    Task<List<MonAn>> GetAll();
    Task<PagingResponse<MonAn>> GetProducts(ProductParameters productParameters);
    Task<MonAn> Get(string path);
    Task<List<MonAn>> SearchMonAn(string text);
}
public class CallProductSvc : ICallProductSvc
{
    private readonly HttpClient _httpClient;

    public CallProductSvc(HttpClient httpClient)
    {
        this._httpClient = httpClient;
    }

    public async Task<MonAn> Get(string path)
    {
        HttpResponseMessage response = await _httpClient.GetAsync(path);
        string apiResponse = await response.Content.ReadAsStringAsync();
        return Newtonsoft.Json.JsonConvert.DeserializeObject<MonAn>(apiResponse);
    }

    public async Task<List<MonAn>> GetAll()
    {
        List<MonAn> monan = null;
        HttpResponseMessage response = await _httpClient.GetAsync("MonAn");
        string apiResponse = await response.Content.ReadAsStringAsync();
        monan = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MonAn>>(apiResponse);
        return monan;
    }

    public async Task<PagingResponse<MonAn>> GetProducts(ProductParameters productParameters)
    {
        var queryStringParam = new Dictionary<string, string>
        {
            ["pageNumber"] = productParameters.PageNumber.ToString()
        };
        var response = await _httpClient.GetAsync(QueryHelpers.AddQueryString("MonAn", queryStringParam));
        var content = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException(content);
        }
        var pagingResponse = new PagingResponse<MonAn>
        {
            Items = JsonConvert.DeserializeObject<List<MonAn>>(content),
            MetaData = JsonConvert.DeserializeObject<MetaData>(response.Headers.GetValues("X-Pagination").First())
        };

        return pagingResponse;
    }

    public async Task<List<MonAn>> SearchMonAn(string text)
    {
        List<MonAn> monan = null;
        HttpResponseMessage response = await _httpClient.GetAsync("MonAn/Search/"+text);
        string apiResponse = await response.Content.ReadAsStringAsync();
        monan = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MonAn>>(apiResponse);
        return monan;
    }
}

