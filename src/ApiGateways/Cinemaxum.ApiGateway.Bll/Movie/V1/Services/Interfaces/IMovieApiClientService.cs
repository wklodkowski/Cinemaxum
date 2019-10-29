using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cinemaxum.ApiGateway.Bll.Movie.V1.Models;

namespace Cinemaxum.ApiGateway.Bll.Movie.V1.Services.Interfaces
{
    public interface IMovieApiClientService
    {
        Task<MovieModel> GetMovieByIdAsync(int movieId);
    }
}
