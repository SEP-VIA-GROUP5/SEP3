namespace Client.Models
{
    public class Game
    {

        public int GameId { get; set; }
        public string GameName { get; set; }
        public double Price { get; set; }
        public string Photo { get; set; }
        public string ESRB { get; set; }
        public string IGN { get; set; }
        public string ShortDescription { get; set; }
        public string Specifications { get; set; }
        public string ReleaseDate { get; set; }
        
    }
}