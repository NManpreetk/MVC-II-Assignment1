namespace Assignment1.Migrations
{
    using Assignment1.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment1.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Assignment1.Models.ApplicationDbContext context)
        {
            context.Products.AddOrUpdate(x => x.Id,
               new Product() { Name = "A", Quantity = 1, Price = 100 },
               new Product() { Name = "B", Quantity = 2, Price = 200 },
               new Product() { Name = "C", Quantity = 3, Price = 300 });

            context.Customers.AddOrUpdate(x => x.Id,
               new Customer() { Name = "A", Email= "abc@gmail.com"});

            context.StoreLocations.AddOrUpdate(x => x.Id,
              new StoreLocation() { LocationName = "A"});

            context.Employees.AddOrUpdate(x => x.Id,
              new Employee() { RegistrationNumber = "123a" });

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
