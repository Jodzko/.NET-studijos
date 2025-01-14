namespace Mongo_DB_roboto_uzduotis
{
    public class Leg
    {
        public string Material { get; set; }
        public int NumberOfJoints { get; set; }
        public int SizeOfFoot { get; set; }

        public Leg(string material, int numberOfJoints, int sizeOfFoot)
        {
            Material = material;
            NumberOfJoints = numberOfJoints;
            SizeOfFoot = sizeOfFoot;
        }
    }
}
