using CatWikiApp.Api.Models;

namespace CatWikiApp.Api.Clients;

public interface IBreedClient
{
    public Task<List<BreedModel>?> GetBreeds();
    public Task<ImageModel?> GetImageForBreed(string imageId);
}
