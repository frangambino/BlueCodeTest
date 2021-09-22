namespace CoreLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CoreLayer.BluecodeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CoreLayer.BluecodeDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Persons.AddOrUpdate(new Person() { Id = 1, Age = 20, Country = "Argentina", Name = "Francisco" },
                new Person() { Id = 2, Age = 30, Country = "Brazil", Name = "Arthur" });
        }
    }
}
