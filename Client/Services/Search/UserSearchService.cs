using System.Text.Json;
using GoogleClone.Shared.Models;

namespace GoogleClone.Client.Services
{
    public class UserSearchService : IUserSearchService
    {
        private readonly HttpClient _http;
        private readonly JsonSerializerOptions _options;

        public UserSearchService(HttpClient Http)
        {
            _http = Http;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }
        public async Task<ResultObject[]?> GetSearchResults(string searchkey)
        {
            if (!string.IsNullOrEmpty(searchkey))
            {
                try
                {
                    var response = await _http.GetAsync($"/api/GoogleSearch/{searchkey}");
                    var content = await response.Content.ReadAsStringAsync();
                    
                    if (response.IsSuccessStatusCode)
                    {
                        var objects = JsonSerializer.Deserialize<ResultObject[]>(content, _options);
                        return objects;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return null;
        }
    }
}