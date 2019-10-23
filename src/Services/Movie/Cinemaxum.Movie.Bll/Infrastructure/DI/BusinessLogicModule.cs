using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Cinemaxum.Movie.Bll.Movie.V1.Extensions;
using Cinemaxum.Movie.Dal.Infrastructure.DI;

namespace Cinemaxum.Movie.Bll.Infrastructure.DI
{
    public class BusinessLogicModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new DataAccessModule());
            builder.AddMovie();
        }
    }
}
