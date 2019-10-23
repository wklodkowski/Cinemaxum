using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Cinemaxum.Movie.Bll.Movie.V1.Mappers;
using Cinemaxum.Movie.Bll.Movie.V1.Mappers.Interfaces;
using Cinemaxum.Movie.Bll.Movie.V1.Services;
using Cinemaxum.Movie.Bll.Movie.V1.Services.Interfaces;

namespace Cinemaxum.Movie.Bll.Movie.V1.Extensions
{
    public static class MovieExtensions
    {
        public static void AddMovie(this ContainerBuilder builder)
        {
            builder.RegisterType<MovieService>().As<IMovieService>();
            builder.RegisterType<MovieMapper>().As<IMovieMapper>();
        }
    }
}
