namespace Mongo_DB_roboto_uzduotis
{
    public class Robot
    {
        public int Id { get; set; }
        public List<Arm> Arms { get; set; }
        public List<Leg> Legs { get; set; }
        public Torso Torso { get; set; }
        public Head Head { get; set; }
        public string TestProperty { get; set; }

        public Robot(int id)
        {
            Id = id;
            Arms = new List<Arm>();
            Legs = new List<Leg>();            
        }
    }
}
