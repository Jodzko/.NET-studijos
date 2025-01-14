namespace Mongo_DB_roboto_uzduotis
{
    public class FileReader
    {
        public readonly static string Path = "C:\\Users\\AJodz\\OneDrive\\Desktop\\Paskaitos\\RobotParts.txt";

        public static string[] ReadAllFileLines(string robotName)
        {
            string[] parts = default;           
            var reader = File.ReadAllLines(Path);           
                foreach (var item in reader)
                {
                parts = item.Split(" ");
                if (parts[0] == robotName)
                {
                    return parts;
                }
                }
            Console.WriteLine("There is no robot with that name on file");
                return default;


        }
    }
}
