using System;
using System.Collections.Generic;

namespace Lab23_MovieSearchDatabase.Models
{
    public class SearchResult
    {
        public List<Movie> MovieList { get; set; }
        public string Genre { get; set; }

        public string Term { get; set; }

        public SearchResult()
        {
            MovieList = new List<Movie>();
        }

        public void SearchGenre(string genre)
        {
            Enum.TryParse(genre, out MovieGenre g);
            Genre = g.ToString();

            var result = new List<Movie>();

            foreach (var movie in MovieList)
            {
                if (movie.Genre == g)
                {
                    result.Add(movie);
                }
            }

            MovieList = result;
        }

        public void SearchTitle(string title)
        {
            Term = title;

            var result = new List<Movie>();

            foreach (var movie in MovieList)
            {
                if (movie.Title.Contains(title, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(movie);
                }
            }

            MovieList = result;
        }
    }
}