using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinemaxum.ApiGateway.Api.Movie.V1.Mappers.Interfaces;
using Cinemaxum.ApiGateway.Api.Movie.V1.Models;
using Cinemaxum.ApiGateway.Bll.Movie.V1.Models;

namespace Cinemaxum.ApiGateway.Api.Movie.V1.Mappers
{
    public class MovieApiMapper : IMovieApiMapper
    {
        public MovieViewModel ToMovieViewModel(MovieModel movieModel)
        {
            var result = new MovieViewModel
            {
                MovieId = movieModel.MovieId,
                Title = movieModel.Title,
                Premiere = movieModel.Premiere,
                Description = movieModel.Description,
                AgeLimit = movieModel.AgeLimit,
                DurationTime = movieModel.DurationTime,
                ProductionPlace = movieModel.ProductionPlace,
                ProductionYear = movieModel.ProductionYear,
                PictureFileName = movieModel.PictureFileName,
                PictureUri = movieModel.PictureUri,
                Genres = movieModel.Genres.Select(ToGenreViewModel).ToList(),
                Persons = movieModel.Persons.Select(ToPersonViewModel).ToList()
            };

            return result;
        }

        public GenreViewModel ToGenreViewModel(GenreModel genreModel)
        {
            var result = new GenreViewModel
            {
                GenreId = genreModel.GenreId,
                Title = genreModel.Title
            };

            return result;
        }

        public PersonViewModel ToPersonViewModel(PersonModel personModel)
        {
            var result = new PersonViewModel
            {
                PersonId = personModel.PersonId,
                FirstName = personModel.FirstName,
                LastName = personModel.LastName,
                Role = personModel.Role
            };

            return result;
        }
    }
}
