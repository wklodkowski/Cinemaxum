using System;
using System.Collections.Generic;
using System.Text;
using Cinemaxum.Movie.Bll.Movie.V1.Mappers.Interfaces;
using Cinemaxum.Movie.Bll.Movie.V1.Models;
using Cinemaxum.Movie.Dal.Models;

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
            throw new NotImplementedException();
        }

        public RatingModel ToRatingModel(Rating rating)
        {
            throw new NotImplementedException();
        }
    }
}
