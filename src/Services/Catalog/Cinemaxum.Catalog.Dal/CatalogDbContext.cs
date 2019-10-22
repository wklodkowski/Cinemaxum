using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Cinemaxum.Catalog.Dal
{
    public class CatalogDbContext : DbContext
    {
        public DbSet<Models.Catalog> Catalogs { get; set; }
    }
}
