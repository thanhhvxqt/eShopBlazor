using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


public interface ICallProductSvc
{
    Task<List<MonAn>> GetAll();
    Task<MonAn> Get(string path);
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
}

