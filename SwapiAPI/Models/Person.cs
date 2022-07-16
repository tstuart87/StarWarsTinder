using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SwapiAPI.Models
{
    public class Person
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("height")]
        public string? Height { get; set; }

        [JsonProperty("mass")]
        public string? Mass { get; set; }

        [JsonProperty("hair_color")]
        public string? HairColor { get; set; }

        [JsonProperty("skin_color")]
        public string? SkinColor { get; set; }

        [JsonProperty("eye_color")]
        public string? EyeColor { get; set; }

        [JsonProperty("birth_year")]
        public string? BirthYear { get; set; }

        [JsonProperty("gender")]
        public string? Gender { get; set; }

        [JsonProperty("homeworld")]
        public string? Homeworld { get; set; }

        [JsonProperty("vehicles")]
        public List<string> VehicleRequestURLs;

        [JsonProperty("starships")]
        public List<string> StarshipRequestURLs;

        public List<Vehicle> Vehicles { get; set; }
        public List<Starship> Starships { get; set; }
        public int Id { get; set; }
    }
}

