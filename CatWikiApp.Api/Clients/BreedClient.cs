using CatWikiApp.Api.Models;

namespace CatWikiApp.Api.Clients;

public sealed class BreedClient : IBreedClient
{
    private readonly IConfiguration _configuration;
    private readonly HttpClient _httpClient;

    public BreedClient(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;
        var apiKey = _configuration["CatApi:ApiKey"];
        _httpClient.DefaultRequestHeaders.Add("x-api-key", apiKey);
    }

    public async Task<List<BreedModel>?> GetBreeds()
    {
        return await _httpClient.GetFromJsonAsync<List<BreedModel>?>("breeds");
    }

    public async Task<ImageModel?> GetImageForBreed(string imageId)
    {
        return await _httpClient.GetFromJsonAsync<ImageModel?>($"images/{imageId}");
    }
}
