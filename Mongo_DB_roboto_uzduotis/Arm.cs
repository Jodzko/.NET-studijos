namespace Mongo_DB_roboto_uzduotis
{
    public class Arm
    {
        public string Material { get; set; }
        public int NumberOfJoints { get; set; }
        public int NumberOfFingers { get; set; }

        public Arm(string material, int numberOfJoints, int numberOfFingers)
        {
            Material = material;
            NumberOfJoints = numberOfJoints;
            NumberOfFingers = numberOfFingers;
        }
    }
}
