using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MigrateCosmosDBContainers
{
    public class Car
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("Wheels")]
        public int NumberOfWheels { get; set; }

        [JsonPropertyName("Doors")]
        public int NumberOfDoors { get; set; }

        [JsonPropertyName("UniqueKey")]
        public string UniqueKey { get; set; }
    }
}
