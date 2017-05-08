namespace DotNetAssesment3.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DotNetAssesment3.DAL.MovieContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        //protected override void Seed(DotNetAssesment3.DAL.MovieContext context)
        //{
        //    //  This method will be called after migrating to the latest version.

        //    //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
        //    //  to avoid creating duplicate seed data. E.g.
        //    //
        //    //    context.People.AddOrUpdate(
        //    //      p => p.FullName,
        //    //      new Person { FullName = "Andrew Peters" },
        //    //      new Person { FullName = "Brice Lambson" },
        //    //      new Person { FullName = "Rowan Miller" }
        //    //    );
        //    //
        //}

        protected override void Seed(DotNetAssesment3.DAL.MovieContext context)
        {


            var movies = new List<Movie>
            {
                new Movie{Title="Interstellar", Director="Christopher Nolan", ReleaseYear=DateTime.Parse("2014-01-01"), Price=179 },
                new Movie{Title="Hobbit:Battle of the five armies", Director="Peter Jackson", ReleaseYear=DateTime.Parse("2014-01-01"), Price=179  },
                new Movie{Title="The Wolf Of Wall Street", Director="Martin Scorcese", ReleaseYear=DateTime.Parse("2013-01-01"), Price=119   },
                new Movie{Title="Pulp Fiction", Director="Quentin Tarantino", ReleaseYear=DateTime.Parse("1994-01-01"), Price=49  },
            };

            movies.ForEach(s => context.Movies.Add(s));
            context.SaveChanges();


            var customers = new List<Customer>
            {
                new Customer{FirstName="Jonas", LastName="Grey", BillingAddress="23 Green Corner Street", BillingZip=56743 , BillingCity="Birmingham", DelieveryAddress="23 Green Corner Street", DelieveryZip=56743 , DelieveryCity="Birmingham", EmailAddress="jonas.gray@hotmail.com", PhoneNo="0708123456" },
                new Customer{FirstName="Jane", LastName="Harolds", BillingAddress="10 West Street", BillingZip=43213 , BillingCity="London", DelieveryAddress="10 West Street", DelieveryZip=43213 , DelieveryCity="London", EmailAddress="jane_h77@gmail.com", PhoneNo="0701245512" },
                new Customer{FirstName="Peter", LastName="Birro", BillingAddress="12 Fox Street", BillingZip= 45681, BillingCity="New York", DelieveryAddress="89 Moose Plaza", DelieveryZip=45321 , DelieveryCity="Seattle", EmailAddress="peter_the_great@hotmail.com", PhoneNo="0739484322" },
            };

            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();

            var orders = new List<Order>
            {
                new Order {OrderDate=DateTime.Parse("2015-01-01"), CustomerId=1 },
                new Order {OrderDate=DateTime.Parse("2015-01-15"), CustomerId=3 },
                new Order {OrderDate=DateTime.Parse("2014-12-20"), CustomerId=1 },
            };

            orders.ForEach(s => context.Orders.Add(s));
            context.SaveChanges();


            var orderRows = new List<OrderRow>
            {
                new OrderRow {OrderId=1 , MovieId=1 , Price=179 },
                new OrderRow {OrderId=1 , MovieId=4 , Price=49 },
                new OrderRow {OrderId=2 , MovieId=3 , Price=119 },
                new OrderRow {OrderId=2 , MovieId=3 , Price=119 },
                new OrderRow {OrderId=3 , MovieId=3 , Price=119 },
            };

            orderRows.ForEach(s => context.OrderRows.Add(s));
            context.SaveChanges();
        }

    }
}
