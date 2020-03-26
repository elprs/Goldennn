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

            Director d1 = new Director() { FirstName = "Bernard"};
            Director d2 = new Director() { FirstName = "Sofich"};
            Director d3 = new Director() { FirstName = "Salvador"};

            Genre g1 = new Genre() { Kind = "Fantasy"};
            Genre g2 = new Genre() { Kind = "Drama"};
            Genre g3 = new Genre() { Kind = "Children's Action"};


            Actor a1 = new Actor() {FirstName= "Marios"};
            Actor a2 = new Actor() {FirstName= "Sofia"};
            Actor a3 = new Actor() {FirstName= "Katerina"};

            context.Movies.AddOrUpdate(x => x.Title, m1, m2, m3);
        }
    }
}
