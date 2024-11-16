namespace _3_Paskaita_OOP_Inheritance_and_Virtual_Methods
{
    public class Manager : Employee
    {
        

        public List<Employee> Employees { get; set; }
        public List<Programmer> Programmers { get; set; } = new List<Programmer>();


        public Manager()
        {

        }
        public Manager(string name, int salary) : base(name, salary)
        {
           
            Employees = new List<Employee>();
        }

        


        
        public void ShowEmployees()
        {
            Console.WriteLine(Name + " " + Salary);
            foreach (var item in Employees)
            {
                Console.WriteLine(item.Name + item.Salary);
            }
        }
        public void ShowProgrammers()
        {
            foreach (var item in Programmers)
            {
                Console.WriteLine(item.ProgrammingLanguage + item.Name + item.Salary);
            }
        }
    }
}
