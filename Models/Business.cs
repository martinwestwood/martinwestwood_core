using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace martinwestwood.Models
{
    public class Business
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("sid")]
        public string sId { get; set; }
        [JsonPropertyName("identityprovider")]
        public string IdentityProvider { get; set; }
        [Required]
        [JsonPropertyName("businessname")]
        public string BusinessName { get; set; }
        [JsonPropertyName("plantingzone")]
        public string PlantingZone { get; set; }
    }
}
