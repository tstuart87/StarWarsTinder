using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SwapiAPI.Models
{
    public class Starship
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("model")]
        public string? Model { get; set; }

        [JsonProperty("manufacturer")]
        public string? Manufacturer { get; set; }

        [JsonProperty("max_atmosphering_speed")]
        public string? MaxSpeed { get; set; }

        [JsonProperty("cargo_capacity")]
        public string? CargoCapacity { get; set; }

        [JsonProperty("consumables")]
        public string? Consumables { get; set; }

        [JsonProperty("hyperdrive_rating")]
        public string? HyperdriveRating { get; set; }

        [JsonProperty("starship_class")]
        public string? StarshipClass { get; set; }
    }
}