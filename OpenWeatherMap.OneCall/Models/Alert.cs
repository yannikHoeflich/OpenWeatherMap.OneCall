using System.Text.Json.Serialization;
using OpenWeatherMap.OneCall.Converter;

namespace OpenWeatherMap.OneCall.Models;

public record Alert(
    [property: JsonPropertyName("sender_name")] string SenderName,
    [property: JsonPropertyName("event")] string Event,
    [property: JsonPropertyName("start"), JsonConverter(typeof(UnixConverter))] DateTime Start,
    [property: JsonPropertyName("end"), JsonConverter(typeof(UnixConverter))] DateTime End,
    [property: JsonPropertyName("description")] string Description,
    [property: JsonPropertyName("tags")] IReadOnlyList<object> Tags
);