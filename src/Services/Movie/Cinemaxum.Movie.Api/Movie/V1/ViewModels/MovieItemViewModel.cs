using System.Collections.Generic;

namespace Cinemaxum.Movie.Api.Movie.V1.ViewModels
{
    public class MovieItemViewModel
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Premiere { get; set; }
        public string Description { get; set; }
        public int AgeLimit { get; set; }
        public int DurationTime { get; set; }
        public string ProductionPlace { get; set; }
        public int ProductionYear { get; set; }
        public string PictureFileName { get; set; }
        public string PictureUri { get; set; }
        public List<GenreViewModel> Genres { get; set; }
        public List<PersonViewModel> Persons { get; set; }
        public List<RatingViewModel> Ratings { get; set; }
    }
}
