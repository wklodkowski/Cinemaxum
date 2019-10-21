using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaxum.Movie.Dal.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Premiere { get; set; }
        public int DurationTime { get; set; }
        public string ProductionPlace { get; set; }
        public int ProductionYear { get; set; }

        public ICollection<MovieGenre> MovieGenres { get; set; }
        public ICollection<MoviePerson> MoviePersons { get; set; }
    }
}
