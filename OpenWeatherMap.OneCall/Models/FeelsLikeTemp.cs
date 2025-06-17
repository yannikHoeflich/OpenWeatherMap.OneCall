using System.Text.Json.Serialization;

namespace OpenWeatherMap.OneCall.Models;

public record FeelsLikeTemp(
    [property: JsonPropertyName("day")] double Day,
    [property: JsonPropertyName("night")] double Night,
    [property: JsonPropertyName("eve")] double Eve,
    [property: JsonPropertyName("morn")] double Morn
);