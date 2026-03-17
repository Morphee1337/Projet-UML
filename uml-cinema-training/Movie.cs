using System;

namespace UmlCinemaTraining
{
    public class Movie
    {
        public string Title { get; set; }
        public int Duration { get; set; }
        public Studio? Studio { get; set; }
        public Director? Director { get; set; }

        public Movie(string title, int duration, Studio? studio = null, Director? director = null)
        {
            Title = title;
            Duration = duration;
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
