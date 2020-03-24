namespace Goldennn.Database.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Goldennn.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<Goldennn.Database.MyDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Goldennn.Database.MyDatabase context)
        {
            Movie m1 = new Movie() { Title = "Avatar" };
            Movie m2 = new Movie() { Title = "Seven" };
            Movie m3 = new Movie() { Title = "Harry Potter" };

            context.Movies.AddOrUpdate(x => x.Title, m1, m2, m3);
        }
    }
}
