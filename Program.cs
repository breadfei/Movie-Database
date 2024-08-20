using Movie_Database;

List<Movie> movies = new List<Movie>
{
    new Movie("Star Wars: Revenge of the Sith", "action"),
    new Movie("ET", "sci-fi"),
    new Movie("The Shining", "horror"),
    new Movie("If", "comedy"),
    new Movie("Deadpool & Wolverine", "comedy"),
    new Movie("Borderlands", "action"),
    new Movie("Jurassic Park", "sci-fi"),
    new Movie("Kung Fu Panda", "action"),
    new Movie("Despicable Me 4", "comedy"),
    new Movie("Fall Guy", "action")
};

bool continueProgram = true;

while (continueProgram)
{
    Console.WriteLine("Please pick a category:");
    Console.WriteLine("1. Action");
    Console.WriteLine("2. Horror");
    Console.WriteLine("3. Comedy");
    Console.WriteLine("4. Sci-Fi");
    Console.WriteLine("Enter the number of the category you wish to see: ");

    string input = Console.ReadLine();
    string selectedGenre;

    switch (input)
    {
        case "1":
            selectedGenre = "action";
            break;
        case "2":
            selectedGenre = "horror";
            break;
        case "3":
            selectedGenre = "comedy";
            break;
        case "4":
            selectedGenre = "sci-fi";
            break;
        default:
            Console.WriteLine("Invalid input, please try again.");
            continue;
    }

    Console.WriteLine($"\nMovies in the '{selectedGenre}' genre:");
    bool foundMovies = false;

    foreach (var movie in movies)
    {
        if (movie.Genre == selectedGenre)
        {
            Console.WriteLine(movie.Title);
            foundMovies = true;
        }
    }
    if (!foundMovies)
    {
        Console.WriteLine("No movies found in this category.");
    }

    Console.Write("\nDo you want to search again? (y/n): ");
    string continueInput = Console.ReadLine().ToLower();
    continueProgram = continueInput == "y";
}