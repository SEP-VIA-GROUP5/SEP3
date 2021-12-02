using System.Text.Json;
using System.Text.Json.Serialization;

namespace Client.Models
{
    public class GameKey
    {
        [JsonPropertyName("gameKey")]
        public string Key { get; set; }
    }
}