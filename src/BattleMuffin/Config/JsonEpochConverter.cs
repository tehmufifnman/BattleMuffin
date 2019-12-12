using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BattleMuffin.Config
{
    public class JsonEpochConverter : JsonConverter<DateTime?>
    {
        /// <summary>
        ///     The base date for the Unix epoch.
        /// </summary>
        private static readonly DateTime EpochStart = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        ///     Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="System.Text.Json.Utf8JsonReader" /> to read from.</param>
        /// <param name="typeToConvert">Type of the object.</param>
        /// <param name="options">Json Serialization Options</param>
        /// <returns>
        ///     <see cref="DateTime" /> representation of the object.
        /// </returns>
        public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.GetString() == null) return null;

            return long.TryParse(reader.GetString(), out var milliseconds)
                ? EpochStart.AddMilliseconds(milliseconds)
                : DateTime.Parse(reader.GetString());
        }

        /// <summary>
        ///     Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="System.Text.Json.Utf8JsonWriter" /> to write to.</param>
        /// <param name="value"><see cref="DateTime" /> representation of the object.</param>
        /// <param name="options">Json Serialization Options</param>
        public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        {
            if (value != null)
                writer.WriteStringValue(((DateTime) value - EpochStart).TotalMilliseconds.ToString("N0"));
        }
    }
}
