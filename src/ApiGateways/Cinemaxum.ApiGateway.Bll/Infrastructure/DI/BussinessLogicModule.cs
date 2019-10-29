using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Cinemaxum.ApiGateway.Bll.Movie.V1.Extensions;

namespace Cinemaxum.ApiGateway.Bll.Infrastructure.DI
{
    public class BussinessLogicModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.AddMovie();
        }
    }
}
