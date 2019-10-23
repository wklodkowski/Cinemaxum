using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cinemaxum.Movie.Bll.Movie.V1.Models;

namespace Cinemaxum.Movie.Bll.Movie.V1.Services.Interfaces
{
    public interface IMovieService
    {
        Task<MovieModel> GetMovieByIdAsync(int movieId);
    }
}
