using System.Security.Cryptography.X509Certificates;

namespace _14_paskaita_OOP_Interface_and_IComparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var Cars = new List<IVehicle> { new Car("Toyota", 25, 49), new Car("Honda", 15, 55) };
            //Cars.ForEach(x => x.Refuel(25));
            var bmw = new BmwCar(true, "X5", 50, 120);
            var audi = new AudiCar(false, "100", 25, 80);

            var Cars = new List<IVehicle>();
            var slyva = new BmwCar(true, "Slyva", 45, 100);
            var bulka = new AudiCar(false, "Bulka", 15, 65);
            Cars.Add(slyva);
            Cars.Add(bulka);
            Cars.ForEach(x =>
            {
                if(x.GetType().Name == "BmwCar")
                {
                    var y = (BmwCar)x;
                    y.Refuel(y.Fuel);
                }  
                else if (x.GetType().Name == "AudiCar")
                {
                    var z = (AudiCar)x;
                    z.Refuel(z.Fuel);
                }
                
            });            

            var bmwCars = new List<BmwCar> { new BmwCar(true, "Slyva", 25, 100), new BmwCar(true, "X3", 75, 110), new BmwCar(false, "3 series", 55, 75) };
            var audiCars = new List<AudiCar> { new AudiCar(false, "Bulka", 15, 65), new AudiCar(false, "Q7", 75, 120), new AudiCar(false, "100", 30, 100) };

            var comparer = new CarComparer();
            bmwCars.Sort(comparer);
            audiCars.Sort(comparer);


            bmw.Drive(bmw.Fuel);
            bmw.Refuel(50);

            audi.Drive(audi.Fuel);
            audi.Refuel(52);

            Console.WriteLine(bmw.Model);
            Console.WriteLine(audi.Model);

        }
    }
}
