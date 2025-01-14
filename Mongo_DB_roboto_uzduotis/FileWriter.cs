namespace Mongo_DB_roboto_uzduotis
{
    public class FileWriter
    {
        public readonly static string path = "C:\\Users\\AJodz\\OneDrive\\Desktop\\Paskaitos\\SavingRobots.txt";


        public static void WritingToFile(Robot robot)
        {
            using (var writer = new StreamWriter(path))
            {
                writer.Write("Robot" + robot.Id);
                foreach (var item in robot.Arms)
                {
                    writer.Write($" {item.Material} {item.NumberOfJoints} {item.NumberOfFingers}");
                }
                foreach (var item in robot.Legs)
                {
                    writer.Write($" {item.Material} {item.NumberOfJoints} {item.SizeOfFoot}");
                }
                writer.Write($" {robot.Torso.ChestMeasurement} {robot.Torso.WaistMeasurement}");
                writer.Write($" {(int)robot.Head}");
            }
        }
    }
}
