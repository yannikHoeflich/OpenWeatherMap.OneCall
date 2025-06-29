using System.Text.Json.Serialization;
using OpenWeatherMap.OneCall.Converter;

namespace OpenWeatherMap.OneCall.Models;

public record Current(
    [property: JsonPropertyName("dt"), JsonConverter(typeof(UnixConverter))] DateTime DateTime,
    [property: JsonPropertyName("sunrise"), JsonConverter(typeof(UnixConverter))] DateTime Sunrise,
    [property: JsonPropertyName("sunset"), JsonConverter(typeof(UnixConverter))] DateTime Sunset,
    [property: JsonPropertyName("temp")] double Temperature,
    [property: JsonPropertyName("feels_like")] double FeelsLike,
    [property: JsonPropertyName("pressure")] int Pressure,
    [property: JsonPropertyName("humidity")] int Humidity,
    [property: JsonPropertyName("dew_point")] double DewPoint,
    [property: JsonPropertyName("uvi")] double UvIndex,
    [property: JsonPropertyName("clouds")] int Clouds,
    [property: JsonPropertyName("visibility")] int Visibility,
    [property: JsonPropertyName("wind_speed")] double WindSpeed,
    [property: JsonPropertyName("wind_deg")] int WindDegree,
    [property: JsonPropertyName("wind_gust")] double WindGust,
    [property: JsonPropertyName("weather")] IReadOnlyList<Weather> Weather
);