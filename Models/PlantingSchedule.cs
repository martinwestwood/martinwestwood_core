using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace disruptGrow_blazor.Client.Models
{
    public class PlantingSchedule
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("plant")]
        public PlantType Plant { get; set; }

        [Required]
        [JsonPropertyName("plantingzone")]
        public string PlantingZone { get; set; }

        [JsonPropertyName("plantindoorsby")]
        public DateTime? PlantIndoorsBy { get; set; }

        [JsonPropertyName("transplantby")]
        public DateTime? TransplantBy { get; set; }

        [JsonPropertyName("sowoutdoorsby")]
        public DateTime? SowOutdoorsBy { get; set; }
    }
}
