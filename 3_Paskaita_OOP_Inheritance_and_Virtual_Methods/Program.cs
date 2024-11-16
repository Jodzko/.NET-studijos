namespace _3_Paskaita_OOP_Inheritance_and_Virtual_Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var polygon = new Polygon(6);
            //Console.WriteLine(polygon.NumberOfAngles);
            //var square = new Square(6);
            //Console.WriteLine($"{square.NumberOfAngles} {square.Size}" );


            //var car = new Car(250);
            //car.ShowSpeed();
            //var bike = new Bike(150);
            //bike.ShowSpeed();



            //var manager = new Manager("Jill", 5000);            
            //manager.Employees.Add(new Employee("John", 2500));
            //manager.Employees.Add(new Employee("Jack", 2950));
            //manager.ShowEmployees();
            //manager.Programmers.Add(new Programmer("C#", "Thomas", 3500));

            //Console.ReadLine();
            //manager.ShowProgrammers();

            //var transport = new Transport(350);
            //transport.MeasureSpeed();
            //var car = new Car1(250);
            //car.MeasureSpeed();


            //var employee = new Employee1("John");
            //employee.Greeting();
            //var manager = new Manager1("Thomas");
            //manager.Greeting();

            var food = new Food("Banana", 2, 25);
            food.ShowInfo();
            var electronic = new Warranty(30, "Computer", 2500);
            electronic.ShowInfo();

            


        }
    }
}
