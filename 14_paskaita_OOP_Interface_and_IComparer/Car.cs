namespace _14_paskaita_OOP_Interface_and_IComparer
{
    public abstract class Car : IVehicle
    {
        public string Model { get; set; }
        public int Fuel { get; set; }
        public int MaxCapacityOfFuel { get; set; }

        public Car(string model, int fuel, int maxCapacity)
        {
            Model = model;
            Fuel = fuel;
            MaxCapacityOfFuel = maxCapacity;
        }

        public void Drive(int fuel)
        {
            
            if(fuel > MaxCapacityOfFuel / 3)
            {
                Console.WriteLine("You can drive with no worries!");
            }
            else
            {
                Console.WriteLine("You need to refuel before going anywhere");
            }
        }

        public string Refuel(int reFuel)
        {
            if (reFuel > 0 && reFuel + Fuel <= MaxCapacityOfFuel)
            {
                Console.WriteLine("You can refuel");
                return "You can refuel";
            }
            else if (Fuel + reFuel > MaxCapacityOfFuel)
            {
                Console.WriteLine("You cannot put in that much fuel!");
                return "You cannot put in that much fuel!";
            }
            else
                Console.WriteLine("Are you trying te refuel or steal fuel?");
                return "Are you trying te refuel or steal fuel?";
        }
    }
}
