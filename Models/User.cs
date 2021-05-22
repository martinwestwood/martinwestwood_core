using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace martinwestwood.Models
{
    public class User
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        public string sId { get; set; }
        public string IdentityProvider { get; set; }
        [Required]
        public string Email { get; set; }
    }

}
