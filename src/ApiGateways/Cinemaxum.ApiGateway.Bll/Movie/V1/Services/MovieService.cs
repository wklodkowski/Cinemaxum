using Cinemaxum.ApiGateway.Bll.Movie.V1.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Cinemaxum.ApiGateway.Bll.Movie.V1.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieApiClientService _movieApiClientService;

        public MovieService(IMovieApiClientService movieApiClientService)
        {
            _movieApiClientService = movieApiClientService;
        }

        public void GetMovieAsync(int movieId)
        {

        }
    }
}
