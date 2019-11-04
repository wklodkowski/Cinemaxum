using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Cinemaxum.ApiGateway.Api.Movie.V1.Mappers.Interfaces;
using Cinemaxum.ApiGateway.Api.Movie.V1.Models;
using Cinemaxum.ApiGateway.Bll.Movie.V1.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cinemaxum.ApiGateway.Api.Movie.V1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly IMovieApiMapper _movieApiMapper;

        public MovieController(IMovieService movieService, IMovieApiMapper movieApiMapper)
        {
            _movieService = movieService;
            _movieApiMapper = movieApiMapper;
        }

        [HttpGet("{movieId}")]
        [ProducesResponseType(typeof(MovieViewModel), (int) HttpStatusCode.OK)]
        public async Task<ActionResult<MovieViewModel>> GetMovieAsync(string movieId)
        {
            var movieModel = await _movieService.GetMovieAsync(int.Parse(movieId));
            return _movieApiMapper.ToMovieViewModel(movieModel);
        }
    }
}