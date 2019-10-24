using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Cinemaxum.Movie.Api.Infrastructure.Extensions
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Version = "v1",
                    Title = "Cinemaxum - Movie Rest API",
                    Description = "The Movie Microservice HTTP API. This is a Data-Driven/CRUD microservice sample",
                    TermsOfService = new Uri("https://api.cinemaxum.com/terms")
                });
            });

            return services;
        }
    }
}
