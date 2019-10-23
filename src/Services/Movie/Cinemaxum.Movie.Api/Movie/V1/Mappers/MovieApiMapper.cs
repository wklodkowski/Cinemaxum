using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinemaxum.Movie.Api.Movie.V1.Mappers.Interfaces;
using Cinemaxum.Movie.Api.Movie.V1.ViewModels;
using Cinemaxum.Movie.Bll.Movie.V1.Models;

namespace Cinemaxum.Movie.Api.Movie.V1.Mappers
{
    public class MovieApiMapper : IMovieApiMapper
    {
        public MovieItemViewModel ToMovieItemResponse(MovieModel movieModel)
        {
            var result = new MovieItemViewModel
            {

            };

            return result;
        }
    }
}
