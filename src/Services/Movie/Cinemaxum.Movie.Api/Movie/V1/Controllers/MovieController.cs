using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Cinemaxum.Movie.Api.Movie.V1.Mappers.Interfaces;
using Cinemaxum.Movie.Api.Movie.V1.ViewModels;
using Cinemaxum.Movie.Bll.Movie.V1.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cinemaxum.Movie.Api.Movie.V1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly IMovieApiMapper _movieApiMapper;

        public MovieController(IMovieService movieServices, IMovieApiMapper movieApiMapper)
        {
            _movieService = movieServices;
            _movieApiMapper = movieApiMapper;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(MovieItemViewModel), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<MovieItemViewModel>> GetMovieAsync(int movieId)
        {
            var movieModel = await _movieService.GetMovieByIdAsync(movieId);
            var response = _movieApiMapper.ToMovieItemResponse(movieModel);

            return Ok(response);
        }
    }
}