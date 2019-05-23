using System.Collections.Generic;
using Newtonsoft.Json;

namespace BattleMuffin.Models.Warcraft.GameData
{
    public class PlayableSpecializationIndex
    {
        [JsonProperty("_links")]
        public Links? Links { get; set; }

        [JsonProperty("character_specializations")]
        public IList<PlayableSpecialization>? CharacterSpecializations { get; set; }

        [JsonProperty("pet_specializations")]
        public IList<PlayableSpecialization>? PetSpecializations { get; set; }
    }
}
