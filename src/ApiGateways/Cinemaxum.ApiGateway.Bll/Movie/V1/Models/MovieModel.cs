using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaxum.ApiGateway.Bll.Movie.V1.Models
{
    public class MovieModel
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
    }
}
