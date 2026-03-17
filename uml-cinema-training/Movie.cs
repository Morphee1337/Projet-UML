using System;

namespace UmlCinemaTraining
{
    public class Movie
    {
        public string Title { get; set; }
        public int Duration { get; set; }
        public Studio? Studio { get; set; }
        public Director? Director { get; set; }

        public Movie(string title, int duration)
        {
            Title = title;
            Duration = duration;
        }

        public Movie(string title, int duration, Director director)
            : this(title, duration)
        {
            Director = director;
        }

        public Movie(string title, int duration, Studio studio)
            : this(title, duration)
        {
            Studio = studio;
        }

        public Movie(string title, int duration, Studio studio, Director director)
            : this(title, duration)
        {
            Studio = studio;
            Director = director;
        }

        public void Display()
        {
            var studioPart = Studio != null ? $" - Studio: {Studio.Name}" : string.Empty;
            var directorPart = Director != null ? $" - Director: {Director.FirstName} {Director.LastName}" : string.Empty;
            Console.WriteLine($"Movie: {Title} ({Duration} min){studioPart}{directorPart}");
        }
    }
}
