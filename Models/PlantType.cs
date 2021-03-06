using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace martinwestwood.Models
{
    public class PlantType
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [Required]
        [JsonPropertyName("plant")]
        public string Plant { get; set; }

    }
}
