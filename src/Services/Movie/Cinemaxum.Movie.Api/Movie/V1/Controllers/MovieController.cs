using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Cinemaxum.Movie.Api.Movie.V1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cinemaxum.Movie.Api.Movie.V1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(MovieItemResponse), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<object>> GetMovieAsync(string movieId)
        {

        }
    }
}