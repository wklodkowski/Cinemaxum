using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Autofac;
using Cinemaxum.ApiGateway.Bll.Infrastructure.Consts;
using Cinemaxum.ApiGateway.Bll.Movie.V1.Services;
using Cinemaxum.ApiGateway.Bll.Movie.V1.Services.Interfaces;

namespace Cinemaxum.ApiGateway.Bll.Movie.V1.Extensions
{
    public static class MovieExtension
    {
        public static void AddMovie(this ContainerBuilder builder)
        {
            builder.RegisterType<MovieService>().As<IMovieService>();
            builder.AddMovieApiClient();
        }

        private static void AddMovieApiClient(this ContainerBuilder builder)
        {
            builder.RegisterType<MovieApiClientService>().As<IMovieApiClientService>().WithParameter(
                (p, ctx) => p.ParameterType == typeof(HttpClient),
                (p, ctx) => ctx.Resolve<IHttpClientFactory>().CreateClient(ApiClientNameConst.MovieApiClientName)
                    .BaseAddress = new Uri("test"));
        }
    }
}
