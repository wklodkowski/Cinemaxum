using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaxum.Movie.Dal.Models
{
    public class MoviePerson
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
