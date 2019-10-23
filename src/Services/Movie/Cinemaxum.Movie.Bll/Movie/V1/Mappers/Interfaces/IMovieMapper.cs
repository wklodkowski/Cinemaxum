using System;
using System.Collections.Generic;
using System.Text;
using Cinemaxum.Movie.Bll.Movie.V1.Models;
using Cinemaxum.Movie.Dal.Models;

namespace Cinemaxum.Movie.Bll.Movie.V1.Mappers.Interfaces
{
    public interface IMovieMapper
    {
        MovieModel ToMovieModel(Dal.Models.Movie movie);
        GenreModel ToGenreModel(Genre genre);
        PersonModel ToPersonModel(Person person);
        RatingModel ToRatingModel(Rating rating);
    }
}
