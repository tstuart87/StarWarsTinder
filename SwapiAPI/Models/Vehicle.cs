using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SwapiAPI.Models
{
    public class Vehicle
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("model")]
        public string? Model { get; set; }

        [JsonProperty("manufacturer")]
        public string? Manufacturer { get; set; }

        [JsonProperty("max_atmosphering_speed")]
        public string? MaxSpeed { get; set; }

        [JsonProperty("vehicle_class")]
        public string? VehicleClass { get; set; }
    }
}