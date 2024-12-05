using System.Threading.Channels;

namespace _15_paskaita_OOP_interface_tasks
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var cat = new Cat("Whiskers", 4);
            //var dog = new Dog("Woofers", 5);
            //var bass = new Bass("Fishy", 12);
            //var carp = new Carp("Fishers", 15);
            //var listOfAnimals = new List<IAnimal>
            //{
            //    cat,
            //    dog,
            //    bass,
            //    carp
            //};
            //var listOfMammals = new List<IMammal>
            //{
            //    cat,
            //    dog
            //};
            //var listOfFish = new List<IFish>
            //{
            //    bass,
            //    carp
            //};
            //listOfAnimals.ForEach(x =>
            //{
            //    if (x.GetType().Name == "Dog")
            //    {
            //        var y = (Dog)x;
            //        y.Eat("dog food");
            //        y.GiveBirth();
            //    }
            //    else if(x.GetType().Name == "Cat")
            //    {
            //        var z = (Cat)x;
            //        z.Eat("cat food");
            //        z.GiveBirth();
            //    }
            //    else if(x.GetType().Name == "Carp")
            //    {
            //        var c = (Carp)x;
            //        c.Eat("carp food");
            //        c.Swim();
            //    }
            //    else if (x.GetType().Name == "Bass")
            //    {
            //        var v = (Bass)x;
            //        v.Eat("bass food");
            //        v.Swim();
            //    }
            //});
            //listOfMammals.ForEach(x =>
            //{
            //    if (x.GetType().Name == "Dog")
            //    {
            //        var y = (Dog)x;
            //        y.Eat("dog food");
            //        y.GiveBirth();
            //    }
            //    else if (x.GetType().Name == "Cat")
            //    {
            //        var z = (Cat)x;
            //        z.Eat("cat food");
            //        z.GiveBirth();
            //    }
            //});
            //listOfFish.ForEach(x =>
            //{
            //    if (x.GetType().Name == "Carp")
            //    {
            //        var c = (Carp)x;
            //        c.Eat("carp food");
            //        c.Swim();
            //    }
            //    else if (x.GetType().Name == "Bass")
            //    {
            //        var v = (Bass)x;
            //        v.Eat("bass food");
            //        v.Swim();
            //    }
            //});
            //var listOfCarps = new List<Carp>
            //{
            //    new Carp("Carpe Retractum", 45),
            //    new Carp("Whomper", 77),
            //    carp,
            //    new Carp("SomeName", 16)
            //};
            //var carpComparer = new CarpComparerByBiggestCaught();
            //listOfCarps.Sort(carpComparer);
            //listOfCarps.ForEach(x => Console.WriteLine(x.Name));

            var path = "C:\\Users\\AJodz\\OneDrive\\Desktop\\Add.txt";

            var person1 = new File2("Artur", 29);
            var person2 = new File2("John", 7);
            var person3 = new File2("Jessica", 35);

            var text1 = new File1("Something valuable", 25);
            var text2 = new File1("Something important", 10);
            var text3 = new File1("A collection of the most important information in the world", 55);
            var text4 = new File1("The information about the creation of the universe", 2);

            var listOfPeople = new List<File2>
            {
                person1,
                person2,
                person3
            };
            var listOfObjects = new List<File1>
            {
                text1,
                text2,
                text3,
                text4
            };

            //listOfPeople.ForEach(x => x.WriteToFile(path));
            //listOfObjects.ForEach(x => x.WriteToFile(path));

            var listOfEverything = new List<Object>
            {
                listOfPeople,
                listOfObjects
            };

            listOfEverything.ForEach(x =>
            {
                if(x is List<File1>)
                {
                    var files = (List<File1>)x;
                    foreach (var item in files)
                    {
                        item.WriteToFile(path);
                    }
                                                     
                }
                else if(x is List<File2>)
                {
                    var files1 = (List<File2>)x;
                    foreach (var item in files1)
                    {
                        item.WriteToFile(path);
                    }     
                }
            });

            //File.WriteAllText(path, string.Empty);


        }
    }
}
