namespace _13_paskaita_OOP_Linq_Lambda
{
    public class Person1
    {
        public string Name { get; set; }
        public List<Pets> ListOfPets { get; set; }

        public Person1(string name, List<Pets> listOfPets)
        {
            Name = name;
            ListOfPets = listOfPets;
        }
    }
}
