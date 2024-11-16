namespace _3_Paskaita_OOP_Inheritance_and_Virtual_Methods
{
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }


        public Employee()
        {

        }
        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}
