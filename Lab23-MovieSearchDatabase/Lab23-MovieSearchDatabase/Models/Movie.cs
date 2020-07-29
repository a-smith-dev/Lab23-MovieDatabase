using System.ComponentModel.DataAnnotations;

namespace Lab23_MovieSearchDatabase.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required]
        public string Title { get; set; }

        public MovieGenre Genre { get; set; }

        public double Runtime { get; set; }

        public Movie()
        {
        }

        public Movie(string title, MovieGenre genre, double runtime)
        {
            Title = title;
            Genre = genre;
            Runtime = runtime;
        }
    }
}
