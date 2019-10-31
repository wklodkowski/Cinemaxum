using Cinemaxum.ApiGateway.Bll.Infrastructure.Config;
using Cinemaxum.ApiGateway.Bll.Movie.V1.Helpers.Interfaces;
using Microsoft.Extensions.Options;

namespace Cinemaxum.ApiGateway.Bll.Movie.V1.Helpers
{
    public class MovieUriHelper : IMovieUriHelper
    {
        private const string GetMovieByIdSuffix = "/api/v1/movie";
        private readonly string _movieEnvironment;

        public MovieUriHelper(IOptions<ServiceUrlsConfig> urlsConfig)
        {
            _movieEnvironment = urlsConfig.Value.MovieBaseUrl;
        }

        public string GetMovieById(int movieId)
        {
            return $"{_movieEnvironment}{GetMovieByIdSuffix}/{movieId}";
        }
    }
}
