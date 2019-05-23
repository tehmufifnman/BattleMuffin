using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class PvPTier
    {
        [JsonProperty("key")]
        public Key? Key { get; set; }

        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("min_rating")]
        public int MinRating { get; set; }

        [JsonProperty("max_rating")]
        public int MaxRating { get; set; }

        [JsonProperty("media")]
        public Media? Media { get; set; }

        [JsonProperty("bracket")]
        public PvPBracket? Bracket { get; set; }

        [JsonProperty("rating_type")]
        public int RatingType { get; set; }
    }
}
