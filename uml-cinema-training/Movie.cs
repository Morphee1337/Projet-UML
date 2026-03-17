using System;

namespace UmlCinemaTraining
{
    public class Movie
    {
        public string Title { get; set; }
        public int Duration { get; set; }
        public Director? Director { get; set; }

        public Movie(string title, int duration, Director? director = null)
        {
            Title = title;
            Duration = duration;
            Director = director;
        }

        public void Display()
        {
            Console.WriteLine($"Movie: {Title} ({Duration} min){(Director != null ? $" - Director: {Director.FirstName} {Director.LastName}" : string.Empty)}");
        }
    }
}
