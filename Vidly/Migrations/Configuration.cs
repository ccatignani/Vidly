namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Vidly.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Vidly.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Vidly.Models.ApplicationDbContext context)
        {
            context.Genres.AddOrUpdate(x => x.Id,
                new Genre(1, "Comedy"),
                new Genre(2, "Action"),
                new Genre(3, "Family"),
                new Genre(4, "Romance"),
                new Genre(5, "Anime")
                );

            context.Movies.AddOrUpdate(x => x.Id,
                new Movie(1, "Pet Detective", new Genre{ Id = 1 }, Convert.ToDateTime("01/01/1980"), Convert.ToDateTime("02/02/1981"), 5),
                new Movie(2, "Blazing Saddles", new Genre { Id = 1 }, Convert.ToDateTime("12/31/1975"), Convert.ToDateTime("12/31/1976"), 5),
                new Movie(3, "Ninja Warriors", new Genre { Id = 2 }, Convert.ToDateTime("03/01/1980"), Convert.ToDateTime("03/02/1981"), 5),
                new Movie(4, "Charlie Brown", new Genre { Id = 3 }, Convert.ToDateTime("06/06/1960"), Convert.ToDateTime("07/07/1987"), 5),
                new Movie(5, "First Kiss", new Genre { Id = 4 }, Convert.ToDateTime("09/01/1989"), Convert.ToDateTime("09/02/1989"), 5),
                new Movie(6, "Norato", new Genre { Id = 5 }, Convert.ToDateTime("05/01/2015"), Convert.ToDateTime("02/02/2015"), 5),
                new Movie(7, "Initial 'D'", new Genre { Id = 5 }, Convert.ToDateTime("11/11/2011"), Convert.ToDateTime("12/12/2012"), 5)
                );

        }
    }
}
