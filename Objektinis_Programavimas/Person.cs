namespace Objektinis_Programavimas
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        

       
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Person( string name, int age, double height) : this(name, age)
        {
            Height = height;
        }

        
    }



    
}
