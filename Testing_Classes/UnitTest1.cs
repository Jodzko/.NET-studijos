using _4_paskaita_OOP_abstrakcios_klases;

namespace Testing_Classes
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int expected = 2;
            var bus = new Bus("Bus", 6, "Volvo", 'D', 23);
            var bike = new Bike("Bike", 2, "BMW", 'A', true);
            var human = new LesserHuman("Artur");
            human.AddVehicle(bus);
            human.AddVehicle(bike);
            int actual = Program.VehicleCount(human.ListOfVehicles);
            Assert.AreEqual(expected, actual);


            
        }
    }
}