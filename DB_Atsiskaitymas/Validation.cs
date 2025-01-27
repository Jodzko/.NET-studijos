namespace DB_Atsiskaitymas
{
    public static class Validation
    {


        public static string YesOrNo()
        {
            var choosing = false;
            while (!choosing)
            {
                Console.Clear();
                var answer = Console.ReadLine().Trim().ToUpper();
                if (answer == "Y" || answer == "N")
                {
                    choosing = true;
                    return answer;
                }
                else
                {
                    Console.WriteLine("Incorrect input, try again.");
                    Console.ReadLine();
                }
            }
            return default;
        }

        public static int MenuInput()
        {
            var choosing = false;
            while (!choosing)
            {
                var choice = int.Parse(Console.ReadLine().Trim());
                if (choice > 0 && choice < 11)
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Incorrect input, try again.");
                }
            }
            return default;
        }
    }
}
