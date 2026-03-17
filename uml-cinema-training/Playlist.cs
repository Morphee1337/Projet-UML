using System;
using System.Collections.Generic;

namespace UmlCinemaTraining
{
    public class Playlist
    {
        public string Name { get; set; }
        public List<Movie> Movies { get; set; } = new();

        public Playlist(string name)
        {
            Name = name;
        }

        public void AddMovie(Movie movie)
        {
            Movies.Add(movie);
        }

        public void DisplayMovies()
        {
            Console.WriteLine($"Playlist: {Name}");
            if (Movies.Count == 0)
            {
                Console.WriteLine("  (no movies)");
                return;
            }

            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {Movies[i].Title} ({Movies[i].Duration} min)");
            }
        }
    }
}
