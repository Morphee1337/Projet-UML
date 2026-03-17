using System;
using System.Collections.Generic;

namespace UmlCinemaTraining
{
    public class WatchList
    {
        public string Name { get; set; }
        public Viewer Viewer { get; set; }
        public List<Movie> Movies { get; set; } = new();

        public WatchList(string name, Viewer viewer)
        {
            Name = name;
            Viewer = viewer;
        }

        public void AddMovie(Movie movie)
        {
            Movies.Add(movie);
        }

        public void DisplayMovies()
        {
            Console.WriteLine($"Watchlist: {Name} (Owner: {Viewer.FirstName} {Viewer.LastName})");
            if (Movies.Count == 0)
            {
                Console.WriteLine("  (no movies)");
                return;
            }

            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {Movies[i].Title} ({Movies[i].Duration} min) - Studio: {Movies[i].Studio?.Name ?? "(none)"}");
            }
        }
    }
}
