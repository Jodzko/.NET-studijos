namespace _8_paskaita_OOP_generics_praktika
{
    public class BasketBallTeams 
    {
        public string Name { get; set; }
        public int PlayerCount { get; set; }

        public BasketBallTeams(string name, int playerCount)
        {
            Name = name;
            PlayerCount = playerCount;
        }

        
    }
}
