using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenWeatherMap.OneCall.Converter;

public class SecondsToTimeSpanConverter : JsonConverter<TimeSpan> {
    public override TimeSpan Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
        if (!reader.TryGetInt64(out long seconds)) {
            return default;
        }

        return TimeSpan.FromSeconds(seconds);
    }

    public override void Write(Utf8JsonWriter writer, TimeSpan value, JsonSerializerOptions options) {
        writer.WriteNumberValue((long)value.TotalSeconds);
    }
}