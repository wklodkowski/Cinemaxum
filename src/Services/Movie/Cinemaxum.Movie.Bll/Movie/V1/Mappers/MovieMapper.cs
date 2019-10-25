using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cinemaxum.Movie.Bll.Common.Extensions;
using Cinemaxum.Movie.Bll.Movie.V1.Mappers.Interfaces;
using Cinemaxum.Movie.Bll.Movie.V1.Models;
using Cinemaxum.Movie.Dal.Models;
using Microsoft.EntityFrameworkCore.Internal;

namespace Cinemaxum.Movie.Bll.Movie.V1.Mappers
{
    public class MovieMapper : IMovieMapper
    {
        public MovieModel ToMovieModel(Dal.Models.Movie movie)
        {
            var result = new MovieModel
            {
                MovieId = movie.MovieId,
                Title = movie.Title,
                Premiere = movie.Premiere,
                Description = movie.Description,
                AgeLimit = movie.AgeLimit,
                DurationTime = movie.DurationTime,
                ProductionPlace = movie.ProductionPlace,
                ProductionYear = movie.ProductionYear,
                PictureFileName = movie.PictureFileName,
                PictureUri = movie.PictureUri
            };

            if (!movie.MovieGenres.IsNullOrEmpty())
            {
                result.Genres = movie.MovieGenres.Select(x => ToGenreModel(x.Genre)).ToList();
            }

            return result;
        }

        public GenreModel ToGenreModel(Genre genre)
        {
            var result = new GenreModel
            {
                GenreId = genre.GenreId,
                Title = genre.Title
            };

            return result;
        }

        public PersonModel ToPersonModel(Person person)
        {
            var result = new PersonModel
            {

            };

            return result;
        }

        public RatingModel ToRatingModel(Rating rating)
        {
            throw new NotImplementedException();
        }
    }
}
