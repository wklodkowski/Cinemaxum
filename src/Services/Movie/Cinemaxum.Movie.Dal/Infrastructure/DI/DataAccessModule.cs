using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace Cinemaxum.Movie.Dal.Infrastructure.DI
{
    public class DataAccessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MovieDbContext>().AsSelf().InstancePerLifetimeScope();
        }
    }
}
