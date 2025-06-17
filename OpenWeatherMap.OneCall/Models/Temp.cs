using System.Text.Json.Serialization;

namespace OpenWeatherMap.OneCall.Models;

public record Temp(
    [property: JsonPropertyName("day")] double Day,
    [property: JsonPropertyName("min")] double Min,
    [property: JsonPropertyName("max")] double Max,
    [property: JsonPropertyName("night")] double Night,
    [property: JsonPropertyName("eve")] double Eve,
    [property: JsonPropertyName("morn")] double Morn
);