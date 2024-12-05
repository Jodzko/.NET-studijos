namespace _15_paskaita_OOP_interface_tasks
{
    public class File2 : IWriteableToFile
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsAnAdult { get; set; }

        public File2(string name, int age)
        {
            Name = name;
            Age = age;
            if (Age >= 18)
            {
                IsAnAdult = true;
            }
            else IsAnAdult = false;
        }

        public void WriteToFile(string fileName)
        {
            File.AppendAllText(fileName, ToString());
        }

        public override string ToString()
        {
            return $"\n Name of the object: {Name} and objects' age: {Age} and is he/she an adult?: {IsAnAdult} \n";
        }
    }
}
