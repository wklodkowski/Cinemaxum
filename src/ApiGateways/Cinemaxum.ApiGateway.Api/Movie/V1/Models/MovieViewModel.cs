using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinemaxum.ApiGateway.Api.Movie.V1.Models
{
    public class MovieViewModel
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public DateTime Premiere { get; set; }
        public string Description { get; set; }
        public int AgeLimit { get; set; }
        public int DurationTime { get; set; }
        public string ProductionPlace { get; set; }
        public int ProductionYear { get; set; }
        public string PictureFileName { get; set; }
        public string PictureUri { get; set; }
        public List<GenreViewModel> Genres { get; set; }
        public List<PersonViewModel> Persons { get; set; }
        public RatingViewModel Rating { get; set; }
    }
}
