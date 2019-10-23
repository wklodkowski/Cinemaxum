using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaxum.Movie.Bll.Movie.V1.Models
{
    public class RatingModel
    {
        public int RatingId { get; set; }
        public int UserId { get; set; }
        public int Rate { get; set; }
    }
}
