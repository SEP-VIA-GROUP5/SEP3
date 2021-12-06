using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Client.Models
{
    public class Game
    {
        [JsonPropertyName("gameId")]
        public int GameId { get; set; }
        [JsonPropertyName("gameName")]
        [Required]
        public string GameName { get; set; }
        [JsonPropertyName("price")]
        [Required, Range(0, 1000, ErrorMessage = "Please enter a valid Price")]
        public double Price { get; set; }
        [JsonPropertyName("description")]
        [Required]
        public string Description { get; set; }
        
        [JsonPropertyName("specifications")]
        [Required]
        public string Specifications { get; set; }
        
        [JsonPropertyName("photoURL")]
        [Required]
        public string Photo { get; set; }
        
        [JsonPropertyName("releaseDate")]
        // [Required]
        public string ReleaseDate { get; set; }
        [JsonPropertyName("esrbrating")]
        [Required]
        public string ESRB { get; set; }
        [JsonPropertyName("ignrating")]
        [Required, Range(0, 10, ErrorMessage = "Please enter a valid IGN rating")]
        public int IGN { get; set; }
        
        [JsonPropertyName("gameKey")]
        public GameKey GameKey { get; set; }
    }
}