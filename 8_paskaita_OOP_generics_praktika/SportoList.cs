using System.Drawing;

namespace _8_paskaita_OOP_generics_praktika
{
    public class SportoList
    {
        private List<FootBallTeam> FootballTeams = new();
        private List<BasketBallTeams> BasketballTeams = new();
        public SportoList()
        {
        }

        public void AddTeam<T>(T team)
        {
           if(team == null)
            {
                Console.WriteLine("Passed a null team");
            }
           if(team is BasketBallTeams basketballTeam)
            {
                BasketballTeams.Add(basketballTeam);
            }
           else if (team is FootBallTeam footballTeam)
            {
                FootballTeams.Add(footballTeam);
            }
            else
            {
                Console.WriteLine("This sport doesnt have a List");
            }
        }


        public void ShowFootballTeams()
        {
            Console.WriteLine("Football teams: ");
            foreach (var item in FootballTeams)
            {               
                Console.WriteLine("Team name:   " + item.Name);
                Console.WriteLine("Players currently in the team:  " + item.PlayerCount);
            }
        }
        public void ShowBaskteballTeams()
        {
            Console.WriteLine("Basketball teams: ");
            foreach (var item in BasketballTeams)
            {
                Console.WriteLine("Team name:   " + item.Name);
                Console.WriteLine("Players currently in the team:  " + item.PlayerCount);
            }
        }
    }
}
