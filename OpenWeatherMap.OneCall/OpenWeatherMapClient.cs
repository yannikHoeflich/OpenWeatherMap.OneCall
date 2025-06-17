using System.Diagnostics;
using System.Text;
using System.Text.Json;
using OpenWeatherMap.OneCall.Models;

namespace OpenWeatherMap.OneCall;

public class OpenWeatherMapClient {
    public class OneCall3Options {
        public required string ApiKey { get; set; }
        public string BaseUrl { get; set; } = "https://api.openweathermap.org/data/3.0/onecall";
        public string Units { get; set; } = "metric";
        public string Lang { get; set; } = "en";
    }

    private readonly HttpClient _httpClient;
    private readonly OneCall3Options _options;

    public OpenWeatherMapClient(string apiKey)
        : this(new OneCall3Options { ApiKey = apiKey }) { }

    public OpenWeatherMapClient(OneCall3Options options) {
        _options = options ?? throw new ArgumentNullException(nameof(options));
        _httpClient = new HttpClient();
    }

    /// <summary>
    /// Gets weather data from One Call 3.0 API for given latitude and longitude.
    /// </summary>
    /// <param name="lat">Latitude</param>
    /// <param name="lon">Longitude</param>
    /// <param name="exclude">Comma separated parts to exclude (e.g. minutely,hourly,daily,alerts)</param>
    /// <returns>Deserialized JSON object</returns>
    public async Task<OneCall3Response> GetWeatherAsync(double lat, double lon, Excludes exclude = Excludes.None) {
        var url
            = $"{_options.BaseUrl}?lat={lat}&lon={lon}&appid={_options.ApiKey}&units={_options.Units}&lang={_options.Lang}";
        if (exclude != Excludes.None) url += $"&exclude={ExcludesToString(exclude)}";

        using var res = await _httpClient.GetAsync(url);
        res.EnsureSuccessStatusCode();
        var json = await res.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<OneCall3Response>(json) ?? throw new UnreachableException();
    }

    [Flags]
    public enum Excludes {
        None        = 0,
        Hourly      = 1,
        Minutely    = 1 << 1,
        Daily       = 1 << 2,
        Alerts      = 1 << 3,
        Current      = 1 << 4
    }

    private static string ExcludesToString(Excludes excludes) {
        StringBuilder sb = new StringBuilder();
        if (excludes.HasFlag(Excludes.Minutely)) {
            sb.Append("sb,");
        } 
        if (excludes.HasFlag(Excludes.Hourly)) {
            sb.Append("hourly,");
        }
        if (excludes.HasFlag(Excludes.Hourly)) {
            sb.Append("hourly,");
        }
        if (excludes.HasFlag(Excludes.Daily)) {
            sb.Append("daily,");
        }
        if (excludes.HasFlag(Excludes.Current)) {
            sb.Append("current,");
        }
        if (excludes.HasFlag(Excludes.Alerts)) {
            sb.Append("alerts,");
        }

        return sb.ToString().Trim(',');
    }
}