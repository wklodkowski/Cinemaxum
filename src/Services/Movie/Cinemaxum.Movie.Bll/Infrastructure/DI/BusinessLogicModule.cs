﻿using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Cinemaxum.Movie.Bll.Movie.V1.Extensions;
using Cinemaxum.Movie.Dal.Infrastructure.DI;

namespace Cinemaxum.Movie.Bll.Infrastructure.DI
{
    public class BusinessLogicModule : Module
    {
        public string ConnectionString { get; set; }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new DataAccessModule{ConnectionString = ConnectionString});
            builder.AddMovie();
        }
    }
}
