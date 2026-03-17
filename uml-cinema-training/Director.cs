namespace UmlCinemaTraining
{
    public class Director
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }

        public Director(string firstName, string lastName, string country)
        {
            FirstName = firstName;
            LastName = lastName;
            Country = country;
        }

        public void Display()
        {
            System.Console.WriteLine($"Director: {FirstName} {LastName} ({Country})");
        }
    }
}
