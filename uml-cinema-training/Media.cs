namespace UmlCinemaTraining
{
    public class Media
    {
        public string Title { get; set; }
        public int Duration { get; set; }

        public Media(string title, int duration)
        {
            Title = title;
            Duration = duration;
        }

        public virtual void Display()
        {
            System.Console.WriteLine($"Media: {Title} ({Duration} min)");
        }
    }
}
