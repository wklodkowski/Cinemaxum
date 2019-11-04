using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinemaxum.ApiGateway.Api.Movie.V1.Models;
using Cinemaxum.ApiGateway.Bll.Movie.V1.Models;

namespace Cinemaxum.ApiGateway.Api.Movie.V1.Mappers.Interfaces
{
    public interface IMovieApiMapper
    {
        MovieViewModel ToMovieViewModel(MovieModel movieModel);
    }
}
