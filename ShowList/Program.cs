using System.ComponentModel.Design;

namespace ShowList
{
    public class Program
    {
        static void Main(string[] args)
        {
            //examples movies and drama
            /*Console.WriteLine("Choose an option:");
            Console.WriteLine("[1]Show List");
            Console.WriteLine("\n[2]Library");
            Console.WriteLine("\n[3]Favorites");
            */

            Show show1 = new Show("The Vampire", Genre.Drama, 2012, 18177);
            Console.WriteLine(show1);
            Movie movie1 = new Movie("Ehu", Genre.Comedy, 1882, 9287, 82);
            Console.WriteLine(movie1);
            //Movie movie2 = new Movie("Ehu", Genre.Comedy, 1882, 9287, 82);
            //Movie movie3 = new Movie("Ehu", Genre.Comedy, 1882, 9287, 82);
            //Movie movie4 = new Movie("Ehu", Genre.Comedy, 1882, 9287, 82);

            // Drama drama1 = new Drama { Title = "Breaking Bad", Genre = Genre.Drama, ReleaseYear = 2008, EpisodeCount = 62 };

            //add or remove in the library
            /* Library library = new Library();
             library.AddShow(movie1);
             library.AddShow(movie2);
             library.AddShow(drama1);

             //users
             User user1 = new User { Username = "Alice" };
             Favorites.AddFavorite(user1, movie1);
             Favorites.AddFavorite(user1, drama1);

             // Display the user's list of favorite movies
             Console.WriteLine("Before removal:");
             Console.WriteLine(user1.GetFavorites());

             // Remove a movie from the user's list of favorite movies
             user1.RemoveFavorite(movie2);

             // Display the user's list of favorite movies again
             Console.WriteLine("After removal:");
             Console.WriteLine(user1.GetFavorites());
            */
        }
    }
}