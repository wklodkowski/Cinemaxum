using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Microsoft.EntityFrameworkCore;

namespace Cinemaxum.Movie.Dal.Infrastructure.DI
{
    public class DataAccessModule : Module
    {
        public string ConnectionString { get; set; }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MovieDbContext>().AsSelf().InstancePerLifetimeScope();
            builder.Register(s =>
            {
                var opt = new DbContextOptionsBuilder<MovieDbContext>();
                opt.UseSqlServer(ConnectionString);
                return new MovieDbContext(opt.Options);
            });
        }
    }
}
