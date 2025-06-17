using System.Text.Json.Serialization;

namespace OpenWeatherMap.OneCall.Models;

public record Hourly(
    [property: JsonPropertyName("dt")] int Dt,
    [property: JsonPropertyName("temp")] double Temp,
    [property: JsonPropertyName("feels_like")] double FeelsLike,
    [property: JsonPropertyName("pressure")] int Pressure,
    [property: JsonPropertyName("humidity")] int Humidity,
    [property: JsonPropertyName("dew_point")] double DewPoint,
    [property: JsonPropertyName("uvi")] int Uvi,
    [property: JsonPropertyName("clouds")] int Clouds,
    [property: JsonPropertyName("visibility")] int Visibility,
    [property: JsonPropertyName("wind_speed")] double WindSpeed,
    [property: JsonPropertyName("wind_deg")] int WindDeg,
    [property: JsonPropertyName("wind_gust")] double WindGust,
    [property: JsonPropertyName("weather")] IReadOnlyList<Weather> Weather,
    [property: JsonPropertyName("pop")] double Pop
);