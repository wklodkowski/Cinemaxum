using Cinemaxum.ApiGateway.Bll.Movie.V1.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Cinemaxum.ApiGateway.Bll.Movie.V1.Models;

namespace Cinemaxum.ApiGateway.Bll.Movie.V1.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieApiClientService _movieApiClientService;

        public MovieService(IMovieApiClientService movieApiClientService)
        {
            _movieApiClientService = movieApiClientService;
        }

        public async Task<MovieModel> GetMovieAsync(int movieId)
        {
           var movieModel = await _movieApiClientService.GetMovieByIdAsync(movieId);
           return movieModel;
        }
    }
}
