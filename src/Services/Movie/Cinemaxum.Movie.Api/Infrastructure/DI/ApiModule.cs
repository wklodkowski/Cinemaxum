using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Cinemaxum.Movie.Api.Movie.V1.Extensions;
using Cinemaxum.Movie.Bll.Infrastructure.DI;

namespace Cinemaxum.Movie.Api.Infrastructure.DI
{
    public class ApiModule : Module
    {
        public string ConnectionString { get; set; }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new BussinessLogicModule{ConnectionString = ConnectionString});
            builder.AddApiMovie();
        }
    }
}
