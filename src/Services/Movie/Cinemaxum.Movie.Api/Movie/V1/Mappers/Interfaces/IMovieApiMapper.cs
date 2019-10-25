using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinemaxum.Movie.Api.Movie.V1.ViewModels;
using Cinemaxum.Movie.Bll.Movie.V1.Models;

namespace Cinemaxum.Movie.Api.Movie.V1.Mappers.Interfaces
{
    public interface IMovieApiMapper
    {
        MovieItemViewModel ToMovieItemResponse(MovieModel movieModel);
        GenreViewModel ToGenreViewModel(GenreModel genreModel);
        PersonViewModel ToPersonViewModel(PersonModel personModel);
    }
}
