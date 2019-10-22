using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaxum.Movie.Dal.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        public int UserId { get; set; }
        public int Rate { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
