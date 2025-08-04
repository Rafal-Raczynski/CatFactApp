using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using CatFactApp.Models;

namespace CatFactApp.Services
{
    public class CatFactService : ICatFactService
    {
        private readonly HttpClient _httpClient;

        public CatFactService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CatFact> GetCatFactAsync()
        {
            var response = await _httpClient.GetStringAsync("https://catfact.ninja/fact");
            var factObj = JsonSerializer.Deserialize<CatFact>(response);
            return factObj;
        }
    }
}