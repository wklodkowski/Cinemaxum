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
                MovieId = movieModel.MovieId,
                Title = movieModel.Title,
                Premiere = movieModel.Premiere.ToShortDateString(),
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
