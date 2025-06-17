using System.Text.Json.Serialization;
using OpenWeatherMap.OneCall.Converter;

namespace OpenWeatherMap.OneCall.Models;

public record Minutely(
    [property: JsonPropertyName("dt"), JsonConverter(typeof(UnixConverter))] DateTime DateTime,
    [property: JsonPropertyName("precipitation")] int Precipitation
);