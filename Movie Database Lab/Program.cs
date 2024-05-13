using Movie_Database_Lab;
Movie movie1 = new Movie("Star Wars", "Scifi");
Movie movie2 = new Movie("Spirited Away", "Animated");
Movie movie3 = new Movie("Friday the 13th", "Horror");
Movie movie4 = new Movie("The Godfather", "Drama");
Movie movie5 = new Movie("Dune", "Scifi");
Movie movie6 = new Movie("Shrek", "Animated");
Movie movie7 = new Movie("IT", "Horror");
Movie movie8= new Movie("Schindler's List", "Drama");
Movie movie9= new Movie("BladeRunner", "Scifi");
Movie movie0 = new Movie("Finding Nemo", "Animated");

List<Movie> movies = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie0};
List<string> genres = new List<string>() { "scifi", "animated", "horror", "drama" };
List<int> genrenum = new List<int>() { 1, 2, 3, 4 };

while (true)
{
    Console.WriteLine("What kind of movie would you like?\n 1. Scifi\n 2. Animated\n 3. Horror\n 4. Drama");
    string input;
    Validation.GetInput(genres,genrenum, out input);

    List<Movie> result = movies.Where(m => m.catagory.ToLower() == input).ToList();
    result.OrderBy(x => x);
    foreach (Movie movie in result)
    {
        Console.WriteLine(movie.title);
    }
    Console.WriteLine("Would you like to select another category? y/n");
    if (Validation.GetInput(Console.ReadLine()))
    {
        continue;
    }
    break;
}