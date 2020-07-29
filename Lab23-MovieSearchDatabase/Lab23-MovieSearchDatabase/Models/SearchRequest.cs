﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Lab23_MovieSearchDatabase.Models
{
    public class SearchRequest
    {
        [Required]
        [NotNull]
        public string Title { get; set; }

        public MovieGenre Genre { get; set; }
    }
}
