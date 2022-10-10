using CatWikiApp.Api.Clients;
using Microsoft.AspNetCore.Mvc;

namespace CatWikiApp.Api.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class CatController : ControllerBase
{
    private readonly ICatClient _catClient;

    public CatController(ICatClient catClient)
    {
        _catClient = catClient;
    }

    [HttpGet]
    public async Task<IActionResult> GetBreeds()
    {
        var cats = await _catClient.GetCat();

        return Ok(cats);
    }
}