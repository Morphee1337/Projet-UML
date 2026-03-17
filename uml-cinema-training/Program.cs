using UmlCinemaTraining;

// Exercise 5: Studio + Playlist
var studio = new Studio("CineArt", "Lyon");
var movie1 = new Movie("Le Voyage", 125, studio);
var movie2 = new Movie("Lumières", 98, studio);

var playlist = new Playlist("Favorites");
playlist.AddMovie(movie1);
playlist.AddMovie(movie2);

playlist.DisplayMovies();

// Display studio for each movie
Console.WriteLine($"Studio for {movie1.Title}: {movie1.Studio?.Name}");
Console.WriteLine($"Studio for {movie2.Title}: {movie2.Studio?.Name}");
