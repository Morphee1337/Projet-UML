namespace UmlCinemaTraining
{
    public class Studio
    {
        public string Name { get; set; }
        public string City { get; set; }

        public Studio(string name, string city)
        {
            Name = name;
            City = city;
        }

        public void Display()
        {
            System.Console.WriteLine($"Studio: {Name} ({City})");
        }
    }
}
