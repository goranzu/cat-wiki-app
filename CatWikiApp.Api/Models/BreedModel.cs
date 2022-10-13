using System.Text.Json.Serialization;

namespace CatWikiApp.Api.Models;

public sealed class BreedModel
{
    // [JsonPropertyName("alt_names")]
    // public string? AltNames { get; init; }
    // public int Experimental { get; init; }
    // public int Hairless { get; init; }
    // public int Hypoallergenic { get; init; }
    public string Id { get; init; } = null!;
    // [JsonPropertyName("life_span")]
    // public string? LifeSpan { get; init; }
    public string Name { get; init; } = null!;
    // public int Natural { get; init; }
    // public string? Origin { get; init; }
    // public int Rare { get; init; }
    [JsonPropertyName("reference_image_id")]
    public string ReferenceImageId { get; init; } = null!;
    // public int Rex { get; init; }
    // [JsonPropertyName("short_legs")]
    // public int ShortLegs { get; init; }
    // [JsonPropertyName("suppressed_tail")]
    // public int SuppressedTail { get; init; }
    // public string? Temperament { get; init; }
    // [JsonPropertyName("weight_imperial")]
    // public string? WeightImperial { get; init; }
    // [JsonPropertyName("wikipedia_url")]
    // public string? WikipediaUrl { get; init; }
}
