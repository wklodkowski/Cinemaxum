using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Cinemaxum.Movie.Api.Movie.V1.Mappers;
using Cinemaxum.Movie.Api.Movie.V1.Mappers.Interfaces;

namespace Cinemaxum.Movie.Api.Movie.V1.Extensions
{
    public static class MovieApiExtension
    {
        public static void AddApiMovie(this ContainerBuilder builder)
        {
            builder.RegisterType<MovieApiMapper>().As<IMovieApiMapper>();
        }
    }
}
