using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;

namespace CatFactApp.Services
{
    public class CatFactService : ICatFactService
{
    private readonly HttpClient _httpClient;

    public CatFactService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> GetCatFactAsync()
    {
        var response = await _httpClient.GetStringAsync("https://catfact.ninja/fact");
        var json = JsonDocument.Parse(response);
        return json.RootElement.GetProperty("fact").GetString();
    }
}
}
