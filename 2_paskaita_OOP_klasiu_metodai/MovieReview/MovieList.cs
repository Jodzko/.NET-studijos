using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_paskaita_OOP_klasiu_metodai.MovieReview
{
    internal class MovieList
    {
        public List<Movie> ListOfMovies { get; set; }

        public MovieList()
        {
            ListOfMovies = new List<Movie>();
        }

        public void AddMovieToList(string name, string genre, double rating)
        {
            ListOfMovies.Add(new Movie(name, genre, rating));
        }

        public string IsItWorthToWatch(string name)
        {
            foreach (var movie in ListOfMovies)
            {
                if (movie.Rating > 5)
                {
                    return $"{ movie.Title} It is worth watching";
                }
                else
                {

                }
            }
        }
    }
}
