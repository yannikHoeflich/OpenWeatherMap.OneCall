using System.Text.Json.Serialization;

namespace OpenWeatherMap.OneCall.Models;

public record Weather(
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("main")] string Main,
    [property: JsonPropertyName("description")] string Description,
    [property: JsonPropertyName("icon")] string Icon
);