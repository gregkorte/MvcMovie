namespace MvcMovie.Migrations
{
    using MvcMovie.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MvcMovie.Models.MovieDBContext";
        }

        protected override void Seed(MvcMovie.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title, 
         new Movie
            {
                Title = "Braveheart",
                ReleaseDate = DateTime.Parse("1995-01-01"),
                Genre = "Action",
                Price = 0,
                Rating = "R"
            },

         new Movie
         {
             Title = "Star Wars ",
             ReleaseDate = DateTime.Parse("1977-01-01"),
             Genre = "SciFi",
             Price = 0,
             Rating = "PG"
         },

         new Movie
         {
             Title = "Empire Strikes Back",
             ReleaseDate = DateTime.Parse("1980-01-01"),
             Genre = "SciFi",
             Price = 0,
             Rating = "PG"
         },

       new Movie
       {
           Title = "Return of the Jedi",
           ReleaseDate = DateTime.Parse("1983-01-01"),
           Genre = "SciFi",
           Price = 0,
           Rating = "PG"
       }
            );
        }
    }
}
