using _5_paskaita_OOP_accessibility;

var person = new Person("Jonas", 27);
var balance = new BankAccount(25000);


var square = new Shape(10, 12);
var squareArea = square.CalculateArea();
Console.WriteLine(squareArea);
var circle = new Circle(12);
var circleArea = circle.CalculateArea();
Console.WriteLine(circleArea);

var dog = new Dog("Fido", "Woof Woof!");
dog.MakeSound();
var cat = new Animal("Whiskers", "Meow Meow!");
cat.MakeSound();
var dog2 = new Dog("Jack", "Woof");
dog2.MakeSound();

var employee = new Employee("Thomas", 1100);
employee.GetSalary();
var manager = new Manager("Jill", 1600);
manager.GetSalary();
var developer = new Developer("Jane", 2000);
developer.GetSalary();

Console.WriteLine(developer.Salary);
Console.WriteLine(manager.Salary);
Console.WriteLine(employee.Salary);
