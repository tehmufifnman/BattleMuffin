using System.Text.Json;
using System.Text.Json.Serialization;

namespace BattleMuffin.Config
{
    public static class DefaultJsonSerializerOptions
    {
        private static JsonSerializerOptions _options;

        public static JsonSerializerOptions Options
        {
            get
            {
                if (_options != null)
                    return _options;

                _options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = false
                };
                _options.Converters.Add(new JsonEpochConverter());
                _options.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));

                return _options;
            }
        }
    }
}
