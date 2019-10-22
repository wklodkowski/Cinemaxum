using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Cinemaxum.Movie.Dal.Models;

namespace Cinemaxum.Movie.Dal
{
    public class MovieDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieGenre>().HasKey(mg => new { mg.MovieId, mg.GenreId });
            modelBuilder.Entity<MoviePerson>().HasKey(mp => new { mp.MovieId, mp.PersonId });
        }

        public DbSet<Models.Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<MoviePerson> MoviePersons { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}
