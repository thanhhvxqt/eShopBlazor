using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


public interface IGetNameOrEmailSvc
{
    Task<bool> Get(string path);
}
public class GetNameOrEmailSvc : IGetNameOrEmailSvc
{
    private readonly HttpClient _httpClient;

    public GetNameOrEmailSvc(HttpClient httpClient)
    {
        this._httpClient = httpClient;
    }

    public async Task<bool> Get(string path)
    {
        
        HttpResponseMessage response = await _httpClient.GetAsync("https://localhost:5002/api/GetEmailOrUserName/"+path);
        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            return true;
        }
        return false;
    }

}

