using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Cinemaxum.ApiGateway.Bll.Movie.V1.Helpers;
using Cinemaxum.ApiGateway.Bll.Movie.V1.Helpers.Interfaces;
using Cinemaxum.ApiGateway.Bll.Movie.V1.Models;
using Cinemaxum.ApiGateway.Bll.Movie.V1.Services.Interfaces;
using Newtonsoft.Json;

namespace Cinemaxum.ApiGateway.Bll.Movie.V1.Services
{
    public class MovieApiClientService : IMovieApiClientService
    {
        private readonly HttpClient _httpClient;
        private readonly IMovieUriHelper _movieUriHelper;

        public MovieApiClientService(HttpClient httpClient, IMovieUriHelper movieUriHelper)
        {
            _httpClient = httpClient;
            _movieUriHelper = movieUriHelper;
        }

        public async Task<MovieModel> GetMovieByIdAsync(int movieId)
        {
            var stringContent = await _httpClient.GetStringAsync(_movieUriHelper.GetMovieById(movieId));
            return JsonConvert.DeserializeObject<MovieModel>(stringContent);
        }
    }
}
