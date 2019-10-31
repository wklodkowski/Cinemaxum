using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaxum.ApiGateway.Bll.Movie.V1.Helpers.Interfaces
{
    public interface IMovieUriHelper
    {
        string GetMovieById(int movieId);
    }
}
