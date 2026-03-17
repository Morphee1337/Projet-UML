namespace UmlCinemaTraining
{
    public class Series : Media
    {
        public int SeasonCount { get; set; }

        public Series(string title, int duration, int seasonCount)
            : base(title, duration)
        {
            SeasonCount = seasonCount;
        }

        public override void Display()
        {
            System.Console.WriteLine($"Series: {Title} ({Duration} min) - Seasons: {SeasonCount}");
        }
    }
}
