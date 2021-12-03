using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Client.Models
{
    public class GameCluster
    {
        [JsonPropertyName("gameStack")]
        public IList<Game> GamesStack { get; set; }

        public GameCluster()
        {
            GamesStack = new List<Game>();
        }
    }
}