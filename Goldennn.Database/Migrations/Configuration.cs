namespace Goldennn.Database.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Goldennn.Entities;
    using Goldennn.Database;

    internal sealed class Configuration : DbMigrationsConfiguration<Goldennn.Database.MyDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Goldennn.Database.MyDatabase context)
        {
            Actor a1 = new Actor() { FirstName = "Leonardo Dicpario" };
            Actor a2 = new Actor() { FirstName = "Joseph Gordon-Levitt" };
            Actor a3 = new Actor() { FirstName = "Ellen Page" };

            Actor a4 = new Actor() { FirstName = "Arnold Schwarzenegger" };
            Actor a5 = new Actor() { FirstName = "Linda Hamilton" };

            Actor a6 = new Actor() { FirstName = "Kate Winslet" };

            Genre g1 = new Genre() { Kind = "Drama" };
            Genre g2 = new Genre() { Kind = "Action" };


            Director d1 = new Director() { FirstName = "Christopher Nolan" };
            Director d2 = new Director() { FirstName = "James Cameron" };

            Movie m1 = new Movie() { Title = "Inception" };
            Movie m2 = new Movie() { Title = "The Terminator" };
            Movie m3 = new Movie() { Title = "Titanic" };

            d1.Movies = new List<Movie>() { m1 };
            d2.Movies = new List<Movie>() { m2, m3 };

            m1.Actors = new List<Actor>() { a1, a2, a3 };
            m2.Actors = new List<Actor>() { a4, a5 };
            m3.Actors = new List<Actor>() { a1, a6 };

            m1.Director = d1;
            m2.Director = d2;
            m3.Director = d2;

            m1.Genre = g1;
            m2.Genre = g2;
            m3.Genre = g2;

            context.Directors.AddOrUpdate(x => x.FirstName, d1, d2);  // δ1 --μ1
            context.Genres.AddOrUpdate(x => x.Kind, g1, g2);
            context.Actors.AddOrUpdate(x => x.FirstName, a1, a2, a3, a4, a5, a6);
            // m1 -- > ψαχνει καποιο ελευθερο id, denτο βρισκει και εχει προβλημα

            context.SaveChanges();


        }
    }
}
