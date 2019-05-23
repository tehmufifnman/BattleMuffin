using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class BattlePet
    {
        [JsonProperty("key")]
        public Key? Key { get; set; }

        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("creature_display")]
        public CreatureDisplay? CreatureDisplay { get; set; }

        [JsonProperty("battle_pet_type")]
        public BattlePetType? BattlePetType { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("is_capturable")]
        public bool IsCapturable { get; set; }

        [JsonProperty("is_tradable")]
        public bool IsTradable { get; set; }

        [JsonProperty("is_battlepet")]
        public bool IsBattlePet { get; set; }

        [JsonProperty("is_alliance_only")]
        public bool IsAllianceOnly { get; set; }

        [JsonProperty("is_horde_only")]
        public bool IsHordeOnly { get; set; }

        [JsonProperty("abilities")]
        public IEnumerable<BattlePetAbility>? Abilities { get; set; }

        [JsonProperty("source")]
        public BattlePetSource? Source { get; set; }

        [JsonProperty("icon")]
        public string? Icon { get; set; }
    }
}
