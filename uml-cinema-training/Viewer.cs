namespace UmlCinemaTraining
{
    public class Viewer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Viewer(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public void Display()
        {
            System.Console.WriteLine($"Viewer: {FirstName} {LastName} - {Email}");
        }
    }
}
