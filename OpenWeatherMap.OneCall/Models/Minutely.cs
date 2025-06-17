using System.Text.Json.Serialization;

namespace OpenWeatherMap.OneCall.Models;

public record Minutely(
    [property: JsonPropertyName("dt")] int Dt,
    [property: JsonPropertyName("precipitation")] int Precipitation
);