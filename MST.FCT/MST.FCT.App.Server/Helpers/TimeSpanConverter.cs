using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MST.FCT.App.Server.Helpers
{
    public class TimeSpanConverter : JsonConverter<TimeSpan>
    {
        public override TimeSpan Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            //return TimeSpan.Parse(reader.GetString());
            using (var jsonDoc = JsonDocument.ParseValue(ref reader))
            {
                return TimeSpan.Parse(jsonDoc.RootElement.GetRawText());
            }
        }

        public override void Write(Utf8JsonWriter writer, TimeSpan value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
