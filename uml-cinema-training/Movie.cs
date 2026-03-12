using System;

namespace UmlCinemaTraining
{
    public class Movie
    {
        public string Title { get; set; }
        public int Duration { get; set; }
        public Studio? Studio { get; set; }

        public Movie(string title, int duration, Studio? studio = null)
        {
            Title = title;
            Duration = duration;
            Studio = studio;
        }

        public void Display()
        {
            Console.WriteLine($"Movie: {Title} ({Duration} min){(Studio != null ? $" - Studio: {Studio.Name}" : string.Empty)}");
        }
    }
}
