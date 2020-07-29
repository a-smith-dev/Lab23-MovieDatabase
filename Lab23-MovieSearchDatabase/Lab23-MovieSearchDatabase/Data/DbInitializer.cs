using Lab23_MovieSearchDatabase.Models;
using System.Collections.Generic;
using System.Linq;

namespace Lab23_MovieSearchDatabase.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DB_Context context)
        {
            context.Database.EnsureCreated();

            if (context.Movies.Any())
            {
                return;
            }

            var MovieList = new List<Movie>() {
                    new Movie("Godzilla: King of the Monsters", MovieGenre.Action, 132),
                    new Movie("Avengers: Infinity War", MovieGenre.Action, 160),
                    new Movie("Jumper", MovieGenre.Action, 90),
                    new Movie("Sonic the Hedgehog", MovieGenre.Action, 100),
                    new Movie("Deadpool 2", MovieGenre.Comedy, 134),
                    new Movie("Men In Black: International", MovieGenre.Comedy, 115),
                    new Movie("Step Brothers", MovieGenre.Comedy, 106),
                    new Movie("Bruce Almighty", MovieGenre.Comedy, 101),
                    new Movie("A Star is Born", MovieGenre.Drama, 136),
                    new Movie("Bohemian Rhapsody", MovieGenre.Drama, 134),
                    new Movie("Joker", MovieGenre.Drama, 122),
                    new Movie("It Chapter 2", MovieGenre.Horror, 169),
                    new Movie("Slender Man", MovieGenre.Horror, 93),
                    new Movie("A Quiet Place", MovieGenre.Horror, 90),
                    new Movie("Jigsaw", MovieGenre.Horror, 92),
                };
            
            foreach (var movie in MovieList)
            {
                context.Movies.Add(movie);
            }

            context.SaveChanges();
        }
    }
}
