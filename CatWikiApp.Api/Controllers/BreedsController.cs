using CatWikiApp.Api.Clients;
using CatWikiApp.Api.Contracts;
using CatWikiApp.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace CatWikiApp.Api.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class BreedsController : ControllerBase
{
    private readonly IBreedClient _breedClient;

    public BreedsController(IBreedClient catClient)
    {
        _breedClient = catClient;
    }

    [HttpGet]
    public async Task<IActionResult> GetBreeds()
    {
        var breeds = await _breedClient.GetBreeds();

        if (breeds is null || breeds.Count == 0)
        {
            return Problem();
        }

        // use shuffle extension method to randomize the result per request.
        breeds.Shuffle();

        var topFourBreeds = breeds.Take(4);
        List<RandomBreedsWithImageResponse> response = new();

        foreach (var breed in topFourBreeds)
        {
            var image = await _breedClient.GetImageForBreed(breed.ReferenceImageId);
            if (image == null)
            {
                return Problem();
            }
            response.Add(new RandomBreedsWithImageResponse(breed.Id, breed.Name, image.Url));
        }

        return Ok(response);
    }
}