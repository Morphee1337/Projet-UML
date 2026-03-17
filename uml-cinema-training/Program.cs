using UmlCinemaTraining;

// Exercise 7: Final streaming model
var viewer = new Viewer("Emma", "Lacroix", "emma.lacroix@example.com");
viewer.Display();

var studio = new Studio("CineArt", "Lyon");
studio.Display();

var movie1 = new Movie("Le Voyage", 125, studio);
var movie2 = new Movie("Lumières", 98, studio);

movie1.Display();
movie2.Display();

var watchList = new WatchList("Favoris", viewer);
watchList.AddMovie(movie1);
watchList.AddMovie(movie2);
watchList.DisplayMovies();
