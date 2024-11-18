using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace _4_paskaita_OOP_abstrakcios_klases
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var dog = new Dog(50);
            //var cat = new Cat(10);

            //var animals = new List<Animal> { dog, cat };


            //foreach (var animal in animals)
            //{
            //    Console.WriteLine(animal.Weight);
            //    animal.MakeNoise();
            //}


            //var square = new Square(4);
            //square.GetArea();
            //square.GetPerimeter();
            //var triangle = new Triangle(4, 5, 3, 6);
            //triangle.GetArea();
            //triangle.GetPerimeter();
            //var shapeList = new List<GeometricShape> { square, triangle };
            //foreach (var shape in shapeList)
            //{
            //    shape.GetArea();
            //    shape.GetPerimeter();
            //}
            var bus = new Bus("Bus", 6, "Volvo", 'D', 23);
            var bike = new Bike("Bike", 2, "BMW", 'A', true);
            var human = new LesserHuman("Artur");
            human.AddVehicle(bus);
            human.AddVehicle(bike);
            human.ShowVehicles();



            int vehicleCount = VehicleCount(human.ListOfVehicles);
            Console.WriteLine(vehicleCount);
        }
        public static int VehicleCount(List<Vehicle> vehicles)
        {
            return vehicles.Count;
        }

        
    }
}
