using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace martinwestwood.Models
{
    public class PlantingZone
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [Required]
        [JsonPropertyName("zipcode")]
        public int ZipCode { get; set; }

        [JsonPropertyName("zone")]
        public string Zone { get; set; }

        [JsonPropertyName("trange")]
        public string TRange { get; set; }

        [JsonPropertyName("zonetitle")]
        public string ZoneTitle { get; set; }
    }
}
