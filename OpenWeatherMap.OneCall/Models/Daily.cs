using System.Text.Json.Serialization;
using OpenWeatherMap.OneCall.Converter;

namespace OpenWeatherMap.OneCall.Models;

public record Daily(
    [property: JsonPropertyName("dt"), JsonConverter(typeof(UnixConverter))]
    DateTime DateTime,
    [property: JsonPropertyName("sunrise"), JsonConverter(typeof(UnixConverter))]
    DateTime Sunrise,
    [property: JsonPropertyName("sunset"), JsonConverter(typeof(UnixConverter))]
    DateTime Sunset,
    [property: JsonPropertyName("moonrise"), JsonConverter(typeof(UnixConverter))]
    DateTime Moonrise,
    [property: JsonPropertyName("moonset"), JsonConverter(typeof(UnixConverter))]
    DateTime Moonset,
    [property: JsonPropertyName("moon_phase")]
    double MoonPhase,
    [property: JsonPropertyName("summary")]
    string Summary,
    [property: JsonPropertyName("temp")] Temp Temperature,
    [property: JsonPropertyName("feels_like")]
    FeelsLikeTemp FeelsLike,
    [property: JsonPropertyName("pressure")]
    int Pressure,
    [property: JsonPropertyName("humidity")]
    int Humidity,
    [property: JsonPropertyName("dew_point")]
    double DewPoint,
    [property: JsonPropertyName("wind_speed")]
    double WindSpeed,
    [property: JsonPropertyName("wind_deg")]
    int WindDeg,
    [property: JsonPropertyName("wind_gust")]
    double WindGust,
    [property: JsonPropertyName("weather")]
    IReadOnlyList<Weather> Weather,
    [property: JsonPropertyName("clouds")] int Clouds,
    [property: JsonPropertyName("pop")] double Pop,
    [property: JsonPropertyName("uvi")] double UvIndex,
    [property: JsonPropertyName("rain")] double Rain = 0
);