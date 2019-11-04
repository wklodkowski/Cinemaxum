using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Cinemaxum.ApiGateway.Api.Movie.V1.Mappers;
using Cinemaxum.ApiGateway.Api.Movie.V1.Mappers.Interfaces;

namespace Cinemaxum.ApiGateway.Api.Movie.V1.Extensions
{
    public static class MovieExtension
    {
        public static void AddApiMovie(this ContainerBuilder builder)
        {
            builder.RegisterType<MovieApiMapper>().As<IMovieApiMapper>();
        }
    }
}
