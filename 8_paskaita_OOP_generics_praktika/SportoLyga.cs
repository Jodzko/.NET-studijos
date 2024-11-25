namespace _8_paskaita_OOP_generics_praktika
{
    public class SportoLyga<T1, T2, T3, T4>
    {
        private T1[] BasketballTeams;
        private T2[] FootballTeams;
        private T3[] VolleyballTeams;
        private T4[] HandballTeams;
        private int Size = 10;
        private int Index1 = 0;
        private int Index2 = 0;
        private int Index3 = 0;
        private int Index4 = 0;

        public SportoLyga()
        {
            BasketballTeams = new T1[Size];
            FootballTeams = new T2[Size];
            VolleyballTeams = new T3[Size];
            HandballTeams = new T4[Size];
        }

        public void AddBasketBallTeam(int sportNumber, T1 name)
        {
            if (sportNumber == 1)
            {
                BasketballTeams[Index1] = name;
                Index1++;
            }
            else
            {
                Console.WriteLine("Wrong sport!");
            }
        }
        public void AddFootballTeams(int sportNumber, T2 name)
        {
            if (sportNumber == 2)
            {
                FootballTeams[Index2] = name;
                Index2++;
            }
            else
            {
                Console.WriteLine("Wrong sport!");
            }
        }
        public void AddVolleyballTeams(int sportNumber, T3 name)
        {
            if (sportNumber == 3)
            {
                VolleyballTeams[Index3] = name;
                Index3++;
            }
            else
            {
                Console.WriteLine("Wrong sport!");
            }
        }
        public void AddHandballTeams(int sportNumber, T4 name)
        {
            if (sportNumber == 4)
            {
                HandballTeams[Index4] = name;
                Index4++;
            }
            else
            {
                Console.WriteLine("Wrong sport!");
            }

        }
        public void ShowTeamsBasketball()
        {
            foreach (var item in BasketballTeams)
            {
                Console.WriteLine(item);
            }
        } 
        public void ShowTeamsFootball()
        {
            foreach (var item in FootballTeams)
            {
                Console.WriteLine(item);
            }
        } 
        public void ShowTeamsVolleyball()
        {
            foreach (var item in VolleyballTeams)
            {
                Console.WriteLine(item);
            }
        } 
        public void ShowTeamsHandball()
        {
            foreach (var item in HandballTeams)
            {
                Console.WriteLine(item);
            }
        }

    }
}
