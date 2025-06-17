using System.Text.Json.Serialization;
using OpenWeatherMap.OneCall.Converter;

namespace OpenWeatherMap.OneCall.Models;

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);

public record OneCall3Response(
        [property: JsonPropertyName("lat")] double Lat,
        [property: JsonPropertyName("lon")] double Lon,
        [property: JsonPropertyName("timezone")] string Timezone,
        [property: JsonPropertyName("timezone_offset"), JsonConverter(typeof(SecondsToTimeSpanConverter))] TimeSpan TimezoneOffset,
        [property: JsonPropertyName("current")] Current Current,
        [property: JsonPropertyName("minutely")] IReadOnlyList<Minutely> Minutely,
        [property: JsonPropertyName("hourly")] IReadOnlyList<Hourly> Hourly,
        [property: JsonPropertyName("daily")] IReadOnlyList<Daily> Daily,
        [property: JsonPropertyName("alerts")] IReadOnlyList<Alert> Alerts
    );