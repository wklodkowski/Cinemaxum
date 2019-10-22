using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinemaxum.Movie.Bll.Movie.V1.Services.Interfaces;
using Cinemaxum.Movie.Dal;
using Cinemaxum.Movie.Dal.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinemaxum.Movie.Bll.Movie.V1.Services
{
    public class MovieService : IMovieServices
    {
        private readonly MovieDbContext _movieDbContext;

        public MovieService(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }

        public Task GetMovieByIdAsync(int movieId)
        {
            
        }
    }
}
