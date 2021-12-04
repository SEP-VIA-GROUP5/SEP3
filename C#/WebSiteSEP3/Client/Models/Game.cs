using System;
using System.Text.Json.Serialization;

namespace Client.Models
{
    public class Game
    {
        [JsonPropertyName("gameId")]
        public int GameId { get; set; }
        [JsonPropertyName("gameName")]
        public string GameName { get; set; }
        [JsonPropertyName("price")]
        public double Price { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        
        [JsonPropertyName("specifications")]
        public string Specifications { get; set; }
        
        [JsonPropertyName("photoURL")]
        public string Photo { get; set; }
        
        [JsonPropertyName("releaseDate")]
        public string ReleaseDate { get; set; }
        [JsonPropertyName("esrbrating")]
        public string ESRB { get; set; }
        [JsonPropertyName("ignrating")]
        public int IGN { get; set; }
        
        public GameKey GameKey { get; set; }
        
       
        
        
    }
}