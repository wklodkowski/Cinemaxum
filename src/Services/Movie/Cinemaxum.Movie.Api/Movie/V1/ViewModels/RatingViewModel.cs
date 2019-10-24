using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinemaxum.Movie.Api.Movie.V1.ViewModels
{
    public class RatingViewModel
    {
        public int RatingId { get; set; }
        public int UserId { get; set; }
        public int Rate { get; set; }
    }
}
