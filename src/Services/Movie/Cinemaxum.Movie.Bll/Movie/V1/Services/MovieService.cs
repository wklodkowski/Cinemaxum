using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinemaxum.Movie.Bll.Movie.V1.Mappers.Interfaces;
using Cinemaxum.Movie.Bll.Movie.V1.Models;
using Cinemaxum.Movie.Bll.Movie.V1.Services.Interfaces;
using Cinemaxum.Movie.Dal;
using Cinemaxum.Movie.Dal.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinemaxum.Movie.Bll.Movie.V1.Services
{
    public class MovieService : IMovieService
    {
        private readonly MovieDbContext _movieDbContext;
        private readonly IMovieMapper _movieMapper;

        public MovieService(MovieDbContext movieDbContext, IMovieMapper movieMapper)
        {
            _movieDbContext = movieDbContext;
            _movieMapper = movieMapper;
        }

        public async Task<MovieModel> GetMovieByIdAsync(int movieId)
        {
            //var result = _movieDbContext.Movies.Where(m => m.MovieId == movieId).Select(m => _movieMapper.ToMovieModel(m));

            //var result = from m in _movieDbContext.Movies
            //    select new MovieModel
            //    {
            //        Genres = (from mg in _movieDbContext.MovieGenres join g in _movieDbContext.Genres on mg.GenreId equals g.GenreId where mg.MovieId == m.MovieId select new GenreModel()).ToList()
            //    };

            var resultQuery = await _movieDbContext.Movies
                .Join(_movieDbContext.MovieGenres, movie => movie.MovieId, movieGenre => movieGenre.MovieId, (movie, movieGenre) => new {movie, movieGenre})
                .Where(movie => movie.movie.MovieId == movieId)
                .Join(_movieDbContext.Genres, movieMovieGenre => movieMovieGenre.movieGenre.GenreId, genre => genre.GenreId, (movieMovieGenre, genre) => new { movieMovieGenre.movie, genre})
                .Select(x => new { Movies = x.movie, Genres = x.genre}).ToListAsync();

            var singleMovie = resultQuery.Select(m => _movieMapper.ToMovieModel(m.Movies)).First();
            singleMovie.Genres = resultQuery.Select(m => _movieMapper.ToGenreModel(m.Genres)).ToList();

            return singleMovie;
        }
    }
}
