using System.Text.Json.Serialization;

namespace OpenWeatherMap.OneCall.Models;

public record Alert(
    [property: JsonPropertyName("sender_name")] string SenderName,
    [property: JsonPropertyName("event")] string Event,
    [property: JsonPropertyName("start")] int Start,
    [property: JsonPropertyName("end")] int End,
    [property: JsonPropertyName("description")] string Description,
    [property: JsonPropertyName("tags")] IReadOnlyList<object> Tags
);