using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Cinemaxum.ApiGateway.Bll.Movie.V1.Config;
using Cinemaxum.ApiGateway.Bll.Movie.V1.Models;
using Cinemaxum.ApiGateway.Bll.Movie.V1.Services.Interfaces;
using Newtonsoft.Json;

namespace Cinemaxum.ApiGateway.Bll.Movie.V1.Services
{
    public class MovieApiClientService : IMovieApiClientService
    {
        private readonly HttpClient _httpClient;

        public MovieApiClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<MovieModel> GetMovieByIdAsync(int movieId)
        {
            var stringContent = await _httpClient.GetStringAsync($"environment{MovieUriConfig.GetMovieById}/{movieId}");
            return JsonConvert.DeserializeObject<MovieModel>(stringContent);
        }
    }
}
