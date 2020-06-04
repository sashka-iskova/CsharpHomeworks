using System.Collections.Generic;
using System;
namespace Models
{
    public class Cinema
    {
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> ListOfMovies { get; set; }
        public Cinema (string name)
        {
            Name = name;
            Halls = new List<int>();
            ListOfMovies = new List<Movie>();
        }

        public void AddMovie(Movie movie)
        {
            ListOfMovies.Add(movie);
        }
        public string MoviePlaying(Movie movie)
        {
            return $"The movie {movie.Title} is playing at the moment";
        }
       
    }
}
