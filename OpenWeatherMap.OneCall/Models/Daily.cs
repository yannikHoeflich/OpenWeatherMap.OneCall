using System.Text.Json.Serialization;

namespace OpenWeatherMap.OneCall.Models;

public record Daily(
    [property: JsonPropertyName("dt")] int Dt,
    [property: JsonPropertyName("sunrise")] int Sunrise,
    [property: JsonPropertyName("sunset")] int Sunset,
    [property: JsonPropertyName("moonrise")] int Moonrise,
    [property: JsonPropertyName("moonset")] int Moonset,
    [property: JsonPropertyName("moon_phase")] double MoonPhase,
    [property: JsonPropertyName("summary")] string Summary,
    [property: JsonPropertyName("temp")] Temp Temp,
    [property: JsonPropertyName("feels_like")] FeelsLike FeelsLike,
    [property: JsonPropertyName("pressure")] int Pressure,
    [property: JsonPropertyName("humidity")] int Humidity,
    [property: JsonPropertyName("dew_point")] double DewPoint,
    [property: JsonPropertyName("wind_speed")] double WindSpeed,
    [property: JsonPropertyName("wind_deg")] int WindDeg,
    [property: JsonPropertyName("wind_gust")] double WindGust,
    [property: JsonPropertyName("weather")] IReadOnlyList<Weather> Weather,
    [property: JsonPropertyName("clouds")] int Clouds,
    [property: JsonPropertyName("pop")] double Pop,
    [property: JsonPropertyName("rain")] double Rain,
    [property: JsonPropertyName("uvi")] double Uvi
);