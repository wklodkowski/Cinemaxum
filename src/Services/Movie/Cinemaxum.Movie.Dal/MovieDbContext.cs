using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Cinemaxum.Movie.Dal.Models;

namespace Cinemaxum.Movie.Dal
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieGenre>().HasKey(mg => new { mg.MovieId, mg.GenreId });
            modelBuilder.Entity<MovieGenre>()
                .HasOne(mg => mg.Movie)
                .WithMany(m => m.MovieGenres)
                .HasForeignKey(mg => mg.MovieId);
            modelBuilder.Entity<MovieGenre>()
                .HasOne(mg => mg.Genre)
                .WithMany(m => m.MovieGenres)
                .HasForeignKey(mg => mg.GenreId);

            modelBuilder.Entity<MoviePerson>().HasKey(mp => new { mp.MovieId, mp.PersonId });
            modelBuilder.Entity<MoviePerson>()
                .HasOne(mp => mp.Movie)
                .WithMany(m => m.MoviePersons)
                .HasForeignKey(mg => mg.MovieId);
            modelBuilder.Entity<MoviePerson>()
                .HasOne(mp => mp.Person)
                .WithMany(m => m.MoviePersons)
                .HasForeignKey(mg => mg.PersonId);
        }

        public DbSet<Models.Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<MoviePerson> MoviePersons { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}
