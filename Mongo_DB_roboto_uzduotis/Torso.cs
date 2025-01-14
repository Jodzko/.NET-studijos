namespace Mongo_DB_roboto_uzduotis
{
    public class Torso
    {
        public int ChestMeasurement { get; set; }
        public int WaistMeasurement { get; set; }

        public Torso(int chestMeasurement, int waistMeasurement)
        {
            ChestMeasurement = chestMeasurement;
            WaistMeasurement = waistMeasurement;
        }
    }
}
