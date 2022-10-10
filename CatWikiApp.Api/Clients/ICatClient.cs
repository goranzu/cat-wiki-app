using CatWikiApp.Api.Models;

namespace CatWikiApp.Api.Clients;

public interface ICatClient {
    public Task<BreedModel[]?> GetCat();
}
