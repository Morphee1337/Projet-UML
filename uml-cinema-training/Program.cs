using UmlCinemaTraining;

// Exercise 4: Playlist with multiple movies
var director = new Director("Christopher", "Nolan", "UK");
var movie1 = new Movie("Inception", 148, director);
var movie2 = new Movie("Tenet", 150, director);

var playlist = new Playlist("Favorites");
playlist.AddMovie(movie1);
playlist.AddMovie(movie2);

playlist.DisplayMovies();
