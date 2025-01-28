namespace DB_Atsiskaitymas
{
    public static class Validation
    {


        public static string YesOrNo()
        {
            var choosing = false;
            while (!choosing)
            {                
                var answer = Console.ReadLine().Trim().ToUpper();
                if (answer == "Y" || answer == "N")
                {
                    choosing = true;
                    return answer;
                }
                else if(answer == "0")
                {
                    choosing = true;
                    break;
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
                var input = int.TryParse(Console.ReadLine().Trim(), out int choice);
                if (choice > 0 && choice < 11)
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Incorrect input, try again.");
                    Console.ReadLine();
                }
            }
            return default;
        }
    }
}
