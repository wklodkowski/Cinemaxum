using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaxum.Movie.Dal.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Title { get; set; }

        public ICollection<MovieGenre> MovieGenres { get; set; }
    }
}
