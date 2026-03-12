namespace UmlCinemaTraining
{
    public class Director
    {
        private string _firstName;
        private string _lastName;
        private string _country;

        public Director(string firstName, string lastName, string country)
        {
            _firstName = firstName;
            _lastName = lastName;
            _country = country;
        }

        public void Display()
        {
            System.Console.WriteLine($"Director: {_firstName} {_lastName} ({_country})");
        }
    }
}
