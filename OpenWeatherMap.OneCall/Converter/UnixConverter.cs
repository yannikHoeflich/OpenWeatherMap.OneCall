using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenWeatherMap.OneCall.Converter;

internal class UnixConverter: JsonConverter<DateTime> {
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
        if (!reader.TryGetInt64(out long unixTime)) {
            return default;
        }
        return DateTime.UnixEpoch.AddMilliseconds(unixTime);
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options) {
        writer.WriteNumberValue((long)(value - DateTime.UnixEpoch).TotalMilliseconds);
    }
}