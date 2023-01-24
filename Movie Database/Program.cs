using System.ComponentModel.DataAnnotations;
using Movie_Database;

List<Movie> movies = new List<Movie>()
{
    new Movie("Smile", "Horror"),
    new Movie("Avengers", "Action"),
    new Movie("Lion King", "Animated"),
    new Movie("One Punch Man", "Animated"),
    new Movie("I Am Legend", "Scifi"),
    new Movie("IT", "Horror"),
    new Movie("Interstellar", "Scifi"),
    new Movie("Dragon Ball Super: Broly", "Animated"),
    new Movie("The Fast and The Furious", "Action"),
    new Movie("Jujutsu Kaisen 0", "Animated")
};

bool restart = true;
while (restart)
{
    Console.WriteLine("Welcome to the MOVIE DATABASE!");
    int choice = Validation.GetUserNumber();

    Console.WriteLine();

    if (choice == 1) //View All
    {
        foreach (Movie m in movies)
        {
            Console.WriteLine(m.GetDetails());
        }
    }
    else if (choice == 2) //View by Catagory
    {
        Console.WriteLine("Which Catagory would you like to view? Action, Animated, Horror, Scifi.");
        string catagory = Console.ReadLine().ToLower().Trim();

        Console.WriteLine();

        foreach (Movie m in movies.Where(s => s.Category.ToLower() == catagory))
        {
            Console.WriteLine(m.GetDetails());
        }
    }
 
    Console.WriteLine();
    restart = Validation.GetContinue("Continue?");
}

Console.WriteLine("Thank you and Goodbye!");