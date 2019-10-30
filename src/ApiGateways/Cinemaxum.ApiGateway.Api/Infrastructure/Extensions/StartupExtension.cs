﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Cinemaxum.ApiGateway.Api.Infrastructure.Config;
using Cinemaxum.ApiGateway.Bll.Infrastructure.Consts;
using Cinemaxum.ApiGateway.Bll.Movie.V1.Services;
using Cinemaxum.ApiGateway.Bll.Movie.V1.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Polly;
using Polly.Extensions.Http;

namespace Cinemaxum.ApiGateway.Api.Infrastructure.Extensions
{
    public static class StartupExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, ServiceUrlsConfig urlsConfig)
        {
            services.AddHttpClient();

            services.AddHttpClient(ApiClientNameConst.MovieApiClientName, c =>
            {
                c.BaseAddress = new Uri(urlsConfig.MovieBaseUrl);
                c.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
                c.DefaultRequestHeaders.Add("User-Agent", "HttpClientFactory-Sample");
            }).AddPolicyHandler(GetRetryPolicy())
                .AddPolicyHandler(GetCircuitBreakerPolicy());

            services.AddHttpClient(ApiClientNameConst.CatalogApiClientName, c =>
                {
                    c.BaseAddress = new Uri(urlsConfig.CatalogBaseUrl);
                    c.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
                    c.DefaultRequestHeaders.Add("User-Agent", "HttpClientFactory-Sample");
                }).AddPolicyHandler(GetRetryPolicy())
                .AddPolicyHandler(GetCircuitBreakerPolicy());

            return services;
        }

        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Version = "v1",
                    Title = "Cinemaxum - API Gateway",
                    Description = "The Cinemaxum API Gateway.",
                    TermsOfService = new Uri("https://api.cinemaxum.com/terms")
                });
            });

            return services;
        }

        private static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
        {
            return HttpPolicyExtensions
                .HandleTransientHttpError()
                .OrResult(msg => msg.StatusCode == System.Net.HttpStatusCode.NotFound)
                .WaitAndRetryAsync(6, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));
        }

        private static IAsyncPolicy<HttpResponseMessage> GetCircuitBreakerPolicy()
        {
            return HttpPolicyExtensions
                .HandleTransientHttpError()
                .CircuitBreakerAsync(5, TimeSpan.FromSeconds(30));
        }
    }
}
