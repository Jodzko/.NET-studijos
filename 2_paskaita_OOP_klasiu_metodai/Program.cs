using _2_paskaita_OOP_klasiu_metodai.Library;
using _2_paskaita_OOP_klasiu_metodai.Models;
using _2_paskaita_OOP_klasiu_metodai.MovieReview;
using _2_paskaita_OOP_klasiu_metodai.MusicPlayer;
using _2_paskaita_OOP_klasiu_metodai.Numbers;

namespace _2_paskaita_OOP_klasiu_metodai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var humanOne = new Human("Artur", "Jodz", 29);

            //Console.WriteLine(humanOne.GetFullName());

            //humanOne.Pets.Add(new Pet("", "", 3));

            //var humanTwo = new Human("Antanas", "Antan", 22);
            //humanTwo.Pets.Add(new Pet("vardas1", "Suo", 3));
            //humanTwo.Pets.Add(new Pet("vardas2", "Kate", 3));
            //humanTwo.Pets.Add(new Pet("vardas3", "Papuga", 3));


            //humanTwo.PrintPets();



            //var numberList = new NumberList();
            //numberList.AddNumberToList(5);
            //numberList.AddNumberToList(8);
            //numberList.AddNumberToList(7);
            //numberList.AddNumberToList(5);
            //numberList.AddNumberToList(4);
            //numberList.PrintNumberList();

            //var rectangle = new Rectangle(4, 5);
            //rectangle.CalculatePerimeter(rectangle.Height, rectangle.Width);
            //rectangle.CalculateArea(rectangle.Height, rectangle.Width);


            //var circle = new Circle(5);
            //Console.WriteLine(circle.CalculateCircumference());
            //Console.WriteLine(circle.CalculateArea());


            //var listOfBooks = new Library.Library();
            //listOfBooks.AddBookToList("Harry Potter");
            //listOfBooks.AddBookToList("Moby-Dick");
            //listOfBooks.AddBookToList("Art of War");
            //listOfBooks.AddBookToList("12 Rules of Life");
            //listOfBooks.RemoveBookFromList("12 Rules of Life");
            //listOfBooks.ShowLibraryContent();


            //var bookList = new Library.Library();            
            //bookList.AddBook("Harry Potter", "J.K. Rowling");
            //bookList.AddBook("Art of War", "Sun-Tzu");
            //bookList.AddBook("12 Rules of Life", "Jordan Peterson");
            //bookList.RemoveBook("Art of War", "Sun Tzu");
            //bookList.ShowLibraryContent();

            //var playlist = new Playlist();            
            //playlist.AddSong("Cradle to the grave", "Five Finger Death Punch", 4.2);
            //playlist.AddSong("By the way", "Red Hot Chili Peppers", 3.5);
            //playlist.AddSong("Welcome to the Jungle", "Guns n'Roses", 4.8);
            //playlist.ReviewPlaylist();

            var listOfMovies = new MovieList();
            var movie1 = new Movie("Shawshank Redemption", "Classic", 9.3);
            var movie2 = new Movie("8 Mile", "Hip-Hop", 7.2);
            var movie3 = new Movie("The Nun", "Horror", 3.5);


            //var humans = GetHumans();
        }


        //public static List<Human> GetHumans()
        //{
        //    return new List<Human>();
        //}
    }
}
