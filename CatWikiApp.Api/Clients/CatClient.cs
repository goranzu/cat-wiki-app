using CatWikiApp.Api.Models;

namespace CatWikiApp.Api.Clients;

public sealed class CatClient : ICatClient
{
    private readonly IConfiguration _configuration;
    private readonly HttpClient _httpClient;

    public CatClient(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;
        var apiKey = _configuration["CatApi:ApiKey"];
        _httpClient.DefaultRequestHeaders.Add("x-api-key", apiKey);
    }

    public async Task<BreedModel[]?> GetCat()
    {
        return await _httpClient.GetFromJsonAsync<BreedModel[]?>("breeds");
    }
}
